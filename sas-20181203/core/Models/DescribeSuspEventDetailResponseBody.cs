// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventDetailResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the online processing of exceptions is supported, such as blocking an exception, adding an exception to the whitelist, and ignoring an exception. Valid values:
        /// 
        /// *   **true**: The online processing of exceptions is supported.
        /// *   **false**: The online processing of exceptions is not supported.
        /// </summary>
        [NameInMap("CanBeDealOnLine")]
        [Validation(Required=false)]
        public bool? CanBeDealOnLine { get; set; }

        /// <summary>
        /// The data source of the exception.
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        /// <summary>
        /// An array that consists of the details of the exception.
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public List<DescribeSuspEventDetailResponseBodyDetails> Details { get; set; }
        public class DescribeSuspEventDetailResponseBodyDetails : TeaModel {
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
            /// The attribute information about the exception. For example, if the exception is associated with an alert that is triggered by an unusual logon, the information can include the time when the logon is initiated and the location from which the logon is initiated. If the exception is associated with an alert that is triggered by a webshell file, the information can include the path of the trojan file and the type of the trojan.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The description of the exception.
        /// </summary>
        [NameInMap("EventDesc")]
        [Validation(Required=false)]
        public string EventDesc { get; set; }

        /// <summary>
        /// The name of the exception.
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// The status of the exception. Valid values:
        /// 
        /// *   **1**: pending handling
        /// *   **2**: ignored
        /// *   **4**: confirmed
        /// *   **8**: marked as a false positive
        /// *   **16**: handling
        /// *   **32**: handled
        /// *   **64**: expired
        /// </summary>
        [NameInMap("EventStatus")]
        [Validation(Required=false)]
        public string EventStatus { get; set; }

        /// <summary>
        /// The type of the exception.
        /// </summary>
        [NameInMap("EventTypeDesc")]
        [Validation(Required=false)]
        public string EventTypeDesc { get; set; }

        /// <summary>
        /// The ID of the exception.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the server on which the exception was detected.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The public IP address of the server on which the exception was detected.
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        /// <summary>
        /// The private IP address of the server on which the exception was detected.
        /// </summary>
        [NameInMap("IntranetIp")]
        [Validation(Required=false)]
        public string IntranetIp { get; set; }

        /// <summary>
        /// The time when the exception was last detected.
        /// </summary>
        [NameInMap("LastTime")]
        [Validation(Required=false)]
        public string LastTime { get; set; }

        /// <summary>
        /// The risk level of the exception. Valid values:
        /// 
        /// *   **serious**
        /// *   **suspicious**
        /// *   **remind**
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// The code that indicates the handling result of the exception.
        /// </summary>
        [NameInMap("OperateErrorCode")]
        [Validation(Required=false)]
        public string OperateErrorCode { get; set; }

        /// <summary>
        /// The message that indicates the handling result of the exception.
        /// </summary>
        [NameInMap("OperateMsg")]
        [Validation(Required=false)]
        public string OperateMsg { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The edition of Security Center in which the exception can be detected. Valid values:
        /// 
        /// *   **0**: Basic edition
        /// *   **1**: Advanced edition
        /// *   **2**: Enterprise edition
        /// </summary>
        [NameInMap("SaleVersion")]
        [Validation(Required=false)]
        public string SaleVersion { get; set; }

        /// <summary>
        /// The UUID of the server on which the exception was detected.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
