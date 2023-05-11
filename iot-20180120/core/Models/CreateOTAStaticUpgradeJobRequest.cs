// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateOTAStaticUpgradeJobRequest : TeaModel {
        /// <summary>
        /// The URL of the device list file that is used to perform a specific update.
        /// 
        /// > *   If you set the TargetSelection parameter to `SPECIFIC`, you must specify this parameter or the **TargetDeviceName.N** parameter. You cannot specify the two parameters at the same time.
        /// >*   You can call the [GenerateDeviceNameListURL](~~186062~~) operation to generate a file URL. Then, you can perform the operations as prompted to upload the device list file.
        /// >*   During a full update, the devices that have been updated are skipped.
        /// >*   During a delta update, the devices that have been updated and the devices whose initial version numbers are different from the update package are skipped.
        /// </summary>
        [NameInMap("DnListFileUrl")]
        [Validation(Required=false)]
        public string DnListFileUrl { get; set; }

        /// <summary>
        /// The download protocol of the update package. Valid values: **HTTPS** and **MQTT**. Default value: HTTPS. After the device receives the update package information pushed by IoT Platform, this protocol is used to download the update package.
        /// 
        /// >If you need to download the update package over MQTT, take note of the following items:
        /// >*   Your service must be deployed in the China (Shanghai), China (Beijing), or China (Shenzhen) region.
        /// >*   The OTA update package can contain only one file, and the size of the file cannot exceed 16 MB.
        /// >*   You must use the latest version of Link SDK for C to develop the device features to perform OTA updates and download files over MQTT. For more information, see [Sample code](~~330985~~).
        /// </summary>
        [NameInMap("DownloadProtocol")]
        [Validation(Required=false)]
        public string DownloadProtocol { get; set; }

        /// <summary>
        /// The ID of the update package.
        /// 
        /// An update package ID is returned when you call the [CreateOTAFirmware](~~147311~~) operation to create the update package.
        /// 
        /// You can also call the [ListOTAFirmware](~~147450~~) operation to obtain the ID.
        /// </summary>
        [NameInMap("FirmwareId")]
        [Validation(Required=false)]
        public string FirmwareId { get; set; }

        /// <summary>
        /// The ratio of the phased update. The value is a percentage in the string format. It can be up to three decimal places. The calculated number of devices is rounded down to the nearest integer. You must specify at least one device for a phased update.
        /// 
        /// For example, if you set the phased update ratio to 33.33 for 100 devices, the number of devices to be updated is 33.
        /// 
        /// You must specify this parameter if you set the TargetSelection parameter to `GRAY`.
        /// </summary>
        [NameInMap("GrayPercent")]
        [Validation(Required=false)]
        public string GrayPercent { get; set; }

        /// <summary>
        /// The ID of the group.
        /// 
        /// If you set the TargetSelection parameter to `GROUP`, you must specify this parameter and the **GroupType** parameter.
        /// 
        /// You can call the [QueryDeviceGroupList](~~93356~~) operation to query the **GroupId** parameter.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The type of the group. Valid value: **LINK_PLATFORM**.
        /// 
        /// If you set the TargetSelection parameter to `GROUP`, you must specify this parameter and the **GroupId** parameter.
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the ID of an instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must specify the ID for this parameter. If you do not specify the instance ID, the call fails.****
        /// >*   If no **Overview** page or **ID** is generated for your instance, you do not need to configure this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The maximum number of devices to which the download URL of the update package is pushed per minute. Valid values: 10 to 10000.
        /// 
        /// Default value: 10000.
        /// </summary>
        [NameInMap("MaximumPerMinute")]
        [Validation(Required=false)]
        public int? MaximumPerMinute { get; set; }

        /// <summary>
        /// Specifies whether the device supports simultaneous updates of multiple modules. Default value: false. Valid values:
        /// 
        /// *   **false**
        /// 
        /// *   **true**: In this case, do not set **OverwriteMode** to **2**.********
        /// 
        ///     The update tasks for the same module are overwritten. The update tasks that are in progress are not overwritten. The update tasks of the modules do not affect each other.
        /// 
        /// >*   Only Enterprise Edition instances and new public instances are supported.
        /// >*   You must use Link SDK for C 4.x to develop the device.
        /// 
        /// For more information, see [Overview](~~58328~~).
        /// </summary>
        [NameInMap("MultiModuleMode")]
        [Validation(Required=false)]
        public bool? MultiModuleMode { get; set; }

        /// <summary>
        /// Specifies whether to control the update by using a mobile app. You must develop the mobile app as needed. Default false: true. Valid values:
        /// 
        /// *   **false**: A device obtains the information about the OTA update task based on the **NeedPush** parameter.
        /// *   **true**: To perform an OTA update on a device, you must confirm the update by using your mobile app. Then, the device can obtain the information about the OTA update task based on the **NeedPush** parameter.
        /// </summary>
        [NameInMap("NeedConfirm")]
        [Validation(Required=false)]
        public bool? NeedConfirm { get; set; }

        /// <summary>
        /// Specifies whether to automatically push update tasks from IoT Platform to devices. Default value: true. Valid values:
        /// 
        /// *   **true**: After an update batch is created, IoT Platform automatically pushes update tasks to the specified online devices.
        /// 
        ///     In this case, a device can still initiate a request to obtain the information about the over-the-air (OTA) update task from IoT Platform.
        /// 
        /// *   **false**: A device must initiate a request to obtain the information about the OTA update task from IoT Platform.
        /// </summary>
        [NameInMap("NeedPush")]
        [Validation(Required=false)]
        public bool? NeedPush { get; set; }

        /// <summary>
        /// Specifies whether to overwrite the previous update task. Default value: 1. Valid values:
        /// 
        /// *   **1**: The previous update task is not overwritten. If a device already has an update task, the previous update task is implemented.
        /// *   **2**: The previous update task is overwritten. Only the current update task is implemented. In this case, you cannot set **MultiModuleMode** to **true**.
        /// 
        /// >  The update task that is in progress is not overwritten.
        /// </summary>
        [NameInMap("OverwriteMode")]
        [Validation(Required=false)]
        public int? OverwriteMode { get; set; }

        /// <summary>
        /// The **ProductKey** of the product to which the update package belongs.
        /// 
        /// A **ProductKey** is the unique identifier of a product in IoT Platform. You can view the information about all products within the current Alibaba Cloud account in the IoT Platform console or by calling the [QueryProductList](~~69271~~) operation.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The number of automatic retries.
        /// 
        /// If you specify the **RetryInterval** parameter, you must specify this parameter.
        /// 
        /// Valid values:
        /// 
        /// *   **1**: retries once.
        /// *   **2**: retries twice.
        /// *   **5**: retries five times.
        /// </summary>
        [NameInMap("RetryCount")]
        [Validation(Required=false)]
        public int? RetryCount { get; set; }

        /// <summary>
        /// The automatic retry interval if a device fails to be updated. Unit: minutes. Valid values:
        /// 
        /// *   **0**: An automatic retry is immediately performed.
        /// *   **10**: An automatic retry is performed after 10 minutes.
        /// *   **30**: An automatic retry is performed after 30 minutes.
        /// *   **60**: An automatic retry is performed after 60 minutes (1 hour).
        /// *   **1440**: An automatic retry is performed after 1,440 minutes (24 hours).
        /// 
        /// > The value of the **RetryInterval** parameter must be less than the value of the **TimeoutInMinutes** parameter. Examples:
        /// >*   If the value of the **TimeoutInMinutes** parameter is set to 60, the maximum value of the **RetryInterval** parameter is 30.
        /// >*   If the value of the **TimeoutInMinutes** parameter is set to 1440, the maximum value of the **RetryInterval** parameter is 60.
        /// 
        /// If the value of the **RetryInterval** parameter is set to 1440, we recommend that you do not specify the **TimeoutInMinutes** parameter. If an update times out, no retry is performed.
        /// 
        /// If you do not specify this parameter, no retry is performed.
        /// </summary>
        [NameInMap("RetryInterval")]
        [Validation(Required=false)]
        public int? RetryInterval { get; set; }

        /// <summary>
        /// The time to end the update.
        /// 
        /// The end time must be 1 hour to 30 days later than the start time that is specified by the **ScheduleTime** parameter. The value must be a 13-digit timestamp.
        /// 
        /// If you do not specify this parameter, the update is not forcibly ended.
        /// </summary>
        [NameInMap("ScheduleFinishTime")]
        [Validation(Required=false)]
        public long? ScheduleFinishTime { get; set; }

        /// <summary>
        /// The time to start the over-the-air (OTA) update.
        /// 
        /// The scheduled time ranges from 5 minutes to 7 days later than the current time. The value must be a 13-digit timestamp.
        /// 
        /// If you do not specify this parameter, the update immediately starts.
        /// </summary>
        [NameInMap("ScheduleTime")]
        [Validation(Required=false)]
        public long? ScheduleTime { get; set; }

        [NameInMap("SrcVersion")]
        [Validation(Required=false)]
        public List<string> SrcVersion { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateOTAStaticUpgradeJobRequestTag> Tag { get; set; }
        public class CreateOTAStaticUpgradeJobRequestTag : TeaModel {
            /// <summary>
            /// The key of the update batch tag. The key must be 1 to 30 characters in length and can contain letters, digits, and periods (.). You can add up to 10 tags for each update batch.
            /// 
            /// The tags of an update batch are sent to devices when IoT Platform pushes update notifications to these devices.
            /// 
            /// >  Update batch tags are optional. If you want to specify a tag, you must specify the Tag.N.Value and Tag.N.Key parameters in pair.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the update batch tag. The value must be 1 to 1,024 characters in length. You can add up to 10 tags for each update batch. The total length of the tag keys and tag values of all update batches cannot exceed 4,096 characters in length.
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
        /// The scope of the update batch. Valid values:
        /// 
        /// *   **ALL**: updates all devices.
        /// *   **SPECIFIC**: updates specified devices.
        /// *   **GRAY**: performs a phased update.
        /// *   **GROUP**: updates specified groups.
        /// </summary>
        [NameInMap("TargetSelection")]
        [Validation(Required=false)]
        public string TargetSelection { get; set; }

        /// <summary>
        /// The timeout period of the update. If the device is not updated within the specified period, a timeout error occurs. Unit: minutes. Valid values: 1 to 1440.
        /// 
        /// > *   The timeout period starts from the time when the specified device submits the update progress for the first time. During the update, the update package may be repeatedly pushed to the specified device because the device goes online and offline multiple times. The start time of the update period remains unchanged.
        /// >*   If an update fails due to timeout, no retry is triggered.
        /// 
        /// If you do not specify this parameter, timeout errors do not occur.
        /// </summary>
        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public int? TimeoutInMinutes { get; set; }

    }

}
