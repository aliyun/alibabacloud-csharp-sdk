// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationSlbsResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the information about the SLB instances that are associated with an application was obtained successfully. Valid values:
        /// 
        /// *   **true**: indicates that the information was obtained successfully.
        /// *   **false**: indicates that the information failed to be obtained.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Configurations of internal-facing SLB instances.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationSlbsResponseBodyData Data { get; set; }
        public class DescribeApplicationSlbsResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the SSL certificate issued by Alibaba Cloud.
            /// </summary>
            [NameInMap("Internet")]
            [Validation(Required=false)]
            public List<DescribeApplicationSlbsResponseBodyDataInternet> Internet { get; set; }
            public class DescribeApplicationSlbsResponseBodyDataInternet : TeaModel {
                [NameInMap("HttpsCaCertId")]
                [Validation(Required=false)]
                public string HttpsCaCertId { get; set; }

                /// <summary>
                /// The supported protocol.
                /// </summary>
                [NameInMap("HttpsCertId")]
                [Validation(Required=false)]
                public string HttpsCertId { get; set; }

                /// <summary>
                /// The ID of the internal-facing SLB instance.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The container port.
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// The port specified for the SLB listener.
                /// </summary>
                [NameInMap("TargetPort")]
                [Validation(Required=false)]
                public int? TargetPort { get; set; }

            }

            /// <summary>
            /// The ID of the Internet-facing SLB instance.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("InternetSlbExpired")]
            [Validation(Required=false)]
            public bool? InternetSlbExpired { get; set; }

            /// <summary>
            /// Configurations of Internet-facing SLB instances.
            /// </summary>
            [NameInMap("InternetSlbId")]
            [Validation(Required=false)]
            public string InternetSlbId { get; set; }

            /// <summary>
            /// The ID of the SSL certificate issued by Alibaba Cloud.
            /// </summary>
            [NameInMap("Intranet")]
            [Validation(Required=false)]
            public List<DescribeApplicationSlbsResponseBodyDataIntranet> Intranet { get; set; }
            public class DescribeApplicationSlbsResponseBodyDataIntranet : TeaModel {
                [NameInMap("HttpsCaCertId")]
                [Validation(Required=false)]
                public string HttpsCaCertId { get; set; }

                /// <summary>
                /// The supported protocol.
                /// </summary>
                [NameInMap("HttpsCertId")]
                [Validation(Required=false)]
                public string HttpsCertId { get; set; }

                /// <summary>
                /// The IP address of the Internet-facing SLB instance.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The container port.
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// The port specified for the SLB listener.
                /// </summary>
                [NameInMap("TargetPort")]
                [Validation(Required=false)]
                public int? TargetPort { get; set; }

            }

            /// <summary>
            /// The error code.
            /// 
            /// *   The **ErrorCode** parameter is not returned when the request succeeds.
            /// *   The **ErrorCode** parameter is returned when the request fails. For more information, see **Error codes** in this topic.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("IntranetSlbExpired")]
            [Validation(Required=false)]
            public bool? IntranetSlbExpired { get; set; }

            /// <summary>
            /// The IP address of the internal-facing SLB instance.
            /// </summary>
            [NameInMap("IntranetSlbId")]
            [Validation(Required=false)]
            public string IntranetSlbId { get; set; }

        }

        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: indicates that the request was successful.
        /// *   **3xx**: indicates that the request was redirected.
        /// *   **4xx**: indicates that the request was invalid.
        /// *   **5xx**: indicates that a server error occurred.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The ID of the trace. It can be used to query the details of a request.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The returned message.
        /// 
        /// *   **success** is returned when the request succeeds.
        /// *   An error code is returned when the request fails.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
