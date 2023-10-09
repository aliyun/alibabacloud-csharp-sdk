// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetAllowedIpListResponseBody : TeaModel {
        /// <summary>
        /// The IP address whitelist.
        /// </summary>
        [NameInMap("AllowedList")]
        [Validation(Required=false)]
        public GetAllowedIpListResponseBodyAllowedList AllowedList { get; set; }
        public class GetAllowedIpListResponseBodyAllowedList : TeaModel {
            /// <summary>
            /// The deployment mode of the instance. Valid values:
            /// 
            /// *   **4**: allows access from the Internet and a virtual private cloud (VPC).
            /// *   **5**: allows access from a VPC.
            /// 
            /// >  Only integrators need to concern themselves with the value of this parameter.
            /// </summary>
            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public int? DeployType { get; set; }

            /// <summary>
            /// The whitelist for access from the Internet.
            /// </summary>
            [NameInMap("InternetList")]
            [Validation(Required=false)]
            public List<GetAllowedIpListResponseBodyAllowedListInternetList> InternetList { get; set; }
            public class GetAllowedIpListResponseBodyAllowedListInternetList : TeaModel {
                /// <summary>
                /// The group to which the IP address whitelist belongs.
                /// </summary>
                [NameInMap("AllowedIpGroup")]
                [Validation(Required=false)]
                public Dictionary<string, string> AllowedIpGroup { get; set; }

                /// <summary>
                /// The information about the IP address whitelist.
                /// </summary>
                [NameInMap("AllowedIpList")]
                [Validation(Required=false)]
                public List<string> AllowedIpList { get; set; }

                /// <summary>
                /// The port range. Valid value:
                /// 
                /// **9093/9093**.
                /// </summary>
                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

            }

            /// <summary>
            /// The whitelist for access from a virtual private cloud (VPC).
            /// </summary>
            [NameInMap("VpcList")]
            [Validation(Required=false)]
            public List<GetAllowedIpListResponseBodyAllowedListVpcList> VpcList { get; set; }
            public class GetAllowedIpListResponseBodyAllowedListVpcList : TeaModel {
                /// <summary>
                /// The group to which the IP address whitelist belongs.
                /// </summary>
                [NameInMap("AllowedIpGroup")]
                [Validation(Required=false)]
                public Dictionary<string, string> AllowedIpGroup { get; set; }

                /// <summary>
                /// The information about the IP address whitelist.
                /// </summary>
                [NameInMap("AllowedIpList")]
                [Validation(Required=false)]
                public List<string> AllowedIpList { get; set; }

                /// <summary>
                /// The port range. Valid value:
                /// 
                /// **9092/9092**.
                /// </summary>
                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

            }

        }

        /// <summary>
        /// The HTTP status code returned. The HTTP status code 200 indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
