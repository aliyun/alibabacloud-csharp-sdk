// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateOTAFirmwareRequest : TeaModel {
        /// <summary>
        /// The version number of the OTA update package. The value can contain letters, digits, periods (.), hyphens (-), and underscores (\_). The version number must be 1 to 64 characters in length.
        /// </summary>
        [NameInMap("DestVersion")]
        [Validation(Required=false)]
        public string DestVersion { get; set; }

        /// <summary>
        /// The description of the OTA update package. The description must be 1 to 100 characters in length.
        /// </summary>
        [NameInMap("FirmwareDesc")]
        [Validation(Required=false)]
        public string FirmwareDesc { get; set; }

        /// <summary>
        /// The name of the OTA update package. The name must be unique within an Alibaba Cloud account. The name cannot be modified after the OTA update package is created. The name must be 1 to 40 characters in length, and can contain letters, digits, hyphens (-), underscores (\_), and parentheses (). The name must start with a letter or a digit.
        /// </summary>
        [NameInMap("FirmwareName")]
        [Validation(Required=false)]
        public string FirmwareName { get; set; }

        /// <summary>
        /// The signature of the OTA update package. The value is calculated by using the specified **signature algorithm** to sign the OTA update package.
        /// 
        /// > If you add only one file to the OTA update package, you can configure this parameter. If you do not configure this parameter, the MD5 value of the OTA update package in OSS is used as the package signature.
        /// </summary>
        [NameInMap("FirmwareSign")]
        [Validation(Required=false)]
        public string FirmwareSign { get; set; }

        /// <summary>
        /// The size of the OTA update package. Unit: bytes.
        /// 
        /// > If you add only one file to the OTA update package, you can configure this parameter. If you do not configure this parameter, the size of the OTA update package in OSS is used.
        /// </summary>
        [NameInMap("FirmwareSize")]
        [Validation(Required=false)]
        public int? FirmwareSize { get; set; }

        /// <summary>
        /// The URL of the OTA update package. This parameter specifies the storage location of the OTA update package in OSS. You can call the [GenerateOTAUploadURL](~~147310~~) operation to generate a URL for the OTA update package.
        /// 
        /// >If you add only one file to the OTA update package, you must configure this parameter.
        /// </summary>
        [NameInMap("FirmwareUrl")]
        [Validation(Required=false)]
        public string FirmwareUrl { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the ID of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.
        /// >*   If no **Overview** page or **ID** is generated for your instance, you do not need to configure this parameter.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The name of the OTA module. OTA modules are the updatable units of devices that belong to the same product.
        /// 
        /// > *   If you do not configure this parameter, the default OTA module is used. The default value indicates that the complete device firmware is updated.
        /// >*   You can call the [CreateOTAModule](~~186066~~) operation to create a custom OTA module. You can call the [ListOTAModuleByProduct](~~186532~~) operation to query the existing OTA modules of a product.
        /// </summary>
        [NameInMap("ModuleName")]
        [Validation(Required=false)]
        public string ModuleName { get; set; }

        [NameInMap("MultiFiles")]
        [Validation(Required=false)]
        public List<CreateOTAFirmwareRequestMultiFiles> MultiFiles { get; set; }
        public class CreateOTAFirmwareRequestMultiFiles : TeaModel {
            /// <summary>
            /// The MD5 value of the file.
            /// 
            /// >  If you want to add multiple files to the OTA update package, you can configure this parameter. If you do not configure this parameter, the MD5 value of the file in OSS is used.
            /// </summary>
            [NameInMap("FileMd5")]
            [Validation(Required=false)]
            public string FileMd5 { get; set; }

            /// <summary>
            /// The name of the file in the update package. The name must be 1 to 32 characters in length. You can specify up to 20 file names. Each name must be unique in the OTA update package.
            /// 
            /// > If you want to add multiple files to the OTA update package, you must configure this parameter.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The signature of the file. The value is calculated by using the specified **signature algorithm** to sign the file.
            /// 
            /// >  If you want to add multiple files to the OTA update package, you can configure this parameter. If you do not configure this parameter, the MD5 value of the file in OSS is used as the file signature.
            /// </summary>
            [NameInMap("SignValue")]
            [Validation(Required=false)]
            public string SignValue { get; set; }

            /// <summary>
            /// The size of the file in the OTA update package. Unit: bytes.
            /// 
            /// >  If you want to add multiple files to the OTA update package, you can configure this parameter. If you do not configure this parameter, the size of the file in OSS is used.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// The URL of the file. This parameter specifies the storage location of the file in OSS. You can call the [GenerateOTAUploadURL](~~147310~~) operation to generate a URL for each file in the OTA update package.
            /// 
            /// > If you want to add multiple files to the OTA update package, you must configure this parameter.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// Specifies whether to verify the OTA update package before you create a batch update task.
        /// 
        /// *   **true** The system verifies the OTA update package before you create a batch update task. This is the default value.
        /// *   **false**: The system does not verify the OTA update package before you create a batch update task.
        /// </summary>
        [NameInMap("NeedToVerify")]
        [Validation(Required=false)]
        public bool? NeedToVerify { get; set; }

        /// <summary>
        /// The **ProductKey** of the product to which the OTA update package belongs.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The signature algorithm of the OTA update package. Set the value to **MD5**. The value indicates an MD5 signature.
        /// 
        /// Default value: **MD5**.
        /// </summary>
        [NameInMap("SignMethod")]
        [Validation(Required=false)]
        public string SignMethod { get; set; }

        /// <summary>
        /// The version number of the OTA module of the device to be updated.
        /// 
        /// You can call the [QueryDeviceDetail](~~69594~~) operation and view the **FirmwareVersion** parameter in the response.
        /// 
        /// > *   If you set the **Type** parameter to **1**, you must configure this parameter, and the value cannot be the same as the update package version that is specified by the **DestVersion** parameter.
        /// >*   If you set the **Type** parameter to **0**, this parameter is optional.
        /// </summary>
        [NameInMap("SrcVersion")]
        [Validation(Required=false)]
        public string SrcVersion { get; set; }

        /// <summary>
        /// The type of the OTA update package. Valid values:
        /// 
        /// *   **0**: The uploaded file contains a full update package. IoT Platform pushes the full update package to a device for update.
        /// *   **1**: The uploaded file contains only the differences between the latest update package and the previous update package. IoT Platform pushes only the differences to a device for update.
        /// 
        /// Default value: **0**.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// The custom information that you want to send to a device. The format of the custom information has no limits. However, the information cannot exceed 4,096 characters in length.
        /// 
        /// After you add the OTA update package and create an update task, IoT Platform sends the custom information to the specified device when IoT Platform pushes an update notification.
        /// </summary>
        [NameInMap("Udi")]
        [Validation(Required=false)]
        public string Udi { get; set; }

    }

}
