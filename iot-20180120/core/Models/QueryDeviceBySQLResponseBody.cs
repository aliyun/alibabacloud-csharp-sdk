// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceBySQLResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The device information returned if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryDeviceBySQLResponseBodyData> Data { get; set; }
        public class QueryDeviceBySQLResponseBodyData : TeaModel {
            /// <summary>
            /// The time when the device was activated. The time is in the GMT format.
            /// </summary>
            [NameInMap("ActiveTime")]
            [Validation(Required=false)]
            public string ActiveTime { get; set; }

            /// <summary>
            /// The name of the device.
            /// </summary>
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// The time when the device was created. The time is in the GMT format.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The time when the device information was last updated. The time is in the GMT format.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The information about the groups to which the device belongs.
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<QueryDeviceBySQLResponseBodyDataGroups> Groups { get; set; }
            public class QueryDeviceBySQLResponseBodyDataGroups : TeaModel {
                /// <summary>
                /// The ID of the group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

            }

            /// <summary>
            /// The ID of the device. The ID is a unique identifier that is issued by IoT Platform to the device.
            /// </summary>
            [NameInMap("IotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }

            /// <summary>
            /// The alias of the device.
            /// </summary>
            [NameInMap("Nickname")]
            [Validation(Required=false)]
            public string Nickname { get; set; }

            /// <summary>
            /// The information about the firmware of each device module.
            /// </summary>
            [NameInMap("OTAModules")]
            [Validation(Required=false)]
            public List<QueryDeviceBySQLResponseBodyDataOTAModules> OTAModules { get; set; }
            public class QueryDeviceBySQLResponseBodyDataOTAModules : TeaModel {
                /// <summary>
                /// The version number of each OTA module.
                /// </summary>
                [NameInMap("FirmwareVersion")]
                [Validation(Required=false)]
                public string FirmwareVersion { get; set; }

                /// <summary>
                /// The name of the OTA module.
                /// </summary>
                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

            }

            /// <summary>
            /// The **ProductKey** of the product to which the device belongs.
            /// </summary>
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            /// <summary>
            /// The status of the device. Valid values:
            /// 
            /// *   **ONLINE**: The device is online.
            /// *   **OFFLINE**: The device is offline.
            /// *   **UNACTIVE**: The device is not activated.
            /// *   **DISABLE**: The device is disabled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The information about device tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<QueryDeviceBySQLResponseBodyDataTags> Tags { get; set; }
            public class QueryDeviceBySQLResponseBodyDataTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// If you specify `SELECT count(*) FROM device` in the SQL-like statement, the number of rows that match the specified conditions is returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
