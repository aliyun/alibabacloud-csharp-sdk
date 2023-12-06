// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListVirusScanMachineEventResponseBody : TeaModel {
        /// <summary>
        /// The details of the alert event.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListVirusScanMachineEventResponseBodyData> Data { get; set; }
        public class ListVirusScanMachineEventResponseBodyData : TeaModel {
            /// <summary>
            /// The details of the exception.
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<ListVirusScanMachineEventResponseBodyDataDetails> Details { get; set; }
            public class ListVirusScanMachineEventResponseBodyDataDetails : TeaModel {
                /// <summary>
                /// The display type of the value for ValueDisplay. Valid value:
                /// 
                /// *   **download_url**, which indicates a download URL.
                /// </summary>
                [NameInMap("InfoType")]
                [Validation(Required=false)]
                public string InfoType { get; set; }

                /// <summary>
                /// The display name of the alert event.
                /// </summary>
                [NameInMap("NameDisplay")]
                [Validation(Required=false)]
                public string NameDisplay { get; set; }

                /// <summary>
                /// The format in which the details of the exception are displayed.
                /// 
                /// Valid values:
                /// 
                /// *   **text**
                /// *   **html**
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The attribute information about the exception. The information includes the logon time or location of an alert triggered by an unusual logon, and the trojan file path or trojan type of an alert.
                /// </summary>
                [NameInMap("ValueDisplay")]
                [Validation(Required=false)]
                public string ValueDisplay { get; set; }

            }

            /// <summary>
            /// The ID of the alert event.
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

            /// <summary>
            /// The name of the alert event. The value indicates a subtype.
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The timestamp when the alert event was last generated. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastTimeStamp")]
            [Validation(Required=false)]
            public long? LastTimeStamp { get; set; }

            /// <summary>
            /// The risk level of the alert event. Valid values:
            /// 
            /// *   **serious**
            /// *   **suspicious**
            /// *   **remind**
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListVirusScanMachineEventResponseBodyPageInfo PageInfo { get; set; }
        public class ListVirusScanMachineEventResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
