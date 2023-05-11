// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateOTAVerifyJobRequest : TeaModel {
        /// <summary>
        /// The download protocol of the update package. Valid values: **HTTPS** and **MQTT**. Default value: HTTPS. After the device receives the update package information pushed by IoT Platform, this protocol is used to download the update package.
        /// 
        /// > If you want to download the update package over MQTT, take note of the following items:
        /// >*   The following regions are supported: China (Shanghai), China (Beijing), and China (Shenzhen).
        /// >*   The OTA update package can contain only one file and the size of the file cannot exceed 16 MB.
        /// >*   You must use the latest version of Link SDK for C to develop the device features to perform OTA updates and download files over MQTT. For more information, see [Sample code](~~330985~~).
        /// </summary>
        [NameInMap("DownloadProtocol")]
        [Validation(Required=false)]
        public string DownloadProtocol { get; set; }

        /// <summary>
        /// The ID of the update package.
        /// 
        /// The **FirmwareId** parameter is returned when you call the [CreateOTAFirmware](~~147311~~) operation to create an OTA update package.
        /// 
        /// You can also call the [ListOTAFirmware](~~147450~~) operation to obtain the ID.
        /// </summary>
        [NameInMap("FirmwareId")]
        [Validation(Required=false)]
        public string FirmwareId { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the ID of an instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.****
        /// >*   If no **Overview** page or **ID** is generated for your instance, you do not need to configure this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// Specifies whether to control the update by using a mobile app. You must develop the mobile app as needed.
        /// 
        /// *   **false** (default): no. A device obtains the information about the OTA update task based on the **NeedPush** parameter.
        /// *   **true**: yes To perform an OTA update on a device, you must confirm the update by using your mobile app. Then, the device can obtain the information about the OTA update task based on the **NeedPush** parameter.
        /// </summary>
        [NameInMap("NeedConfirm")]
        [Validation(Required=false)]
        public bool? NeedConfirm { get; set; }

        /// <summary>
        /// Specifies whether to automatically push update tasks from IoT Platform to devices.
        /// 
        /// *   **true** (default): yes. After an update batch is created, IoT Platform automatically pushes update tasks to the specified online devices.
        /// 
        ///     In this case, a device can still initiate a request to obtain the information about the over-the-air (OTA) update task from IoT Platform.
        /// 
        /// *   **false**: no. A device must initiate a request to obtain the information about the OTA update task from IoT Platform.
        /// </summary>
        [NameInMap("NeedPush")]
        [Validation(Required=false)]
        public bool? NeedPush { get; set; }

        /// <summary>
        /// The ProductKey of the product to which the OTA update package belongs.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateOTAVerifyJobRequestTag> Tag { get; set; }
        public class CreateOTAVerifyJobRequestTag : TeaModel {
            /// <summary>
            /// The key of the update batch tag. The key must be 1 to 30 characters in length and can contain letters, digits, and periods (.). You can add up to 10 tags for each update batch.
            /// 
            /// The tags of an update batch are sent to devices when IoT Platform pushes update notifications to the devices.
            /// 
            /// >  Update batch tags are optional. If you want to specify a tag, you must specify the Tag.N.Value and Tag.N.Key parameters in pair.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the update batch tag. The value must be 1 to 1,024 characters in length. You can add up to 10 tags for each update batch. The total length of the tag keys and tag values of all update batches cannot exceed 4,096 characters.
            /// 
            /// >  Update batch tags are optional. If you want to specify a tag, you must specify the Tag.N.Value and Tag.N.Key parameters in pair.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TargetDeviceName")]
        [Validation(Required=false)]
        public List<string> TargetDeviceName { get; set; }

        /// <summary>
        /// The timeout period for a device to update the firmware. Unit: minutes. Valid values: 1 to 1440.
        /// </summary>
        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public int? TimeoutInMinutes { get; set; }

    }

}
