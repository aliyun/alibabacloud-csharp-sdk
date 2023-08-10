// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// The details of the instance.
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyInstance Instance { get; set; }
        public class GetInstanceResponseBodyInstance : TeaModel {
            /// <summary>
            /// The time when the instance was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The default endpoint of the instance.
            /// </summary>
            [NameInMap("DefaultEndpoint")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyInstanceDefaultEndpoint DefaultEndpoint { get; set; }
            public class GetInstanceResponseBodyInstanceDefaultEndpoint : TeaModel {
                /// <summary>
                /// The endpoint of the instance.
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// The status of the endpoint. Valid values:
                /// 
                /// *   resolved
                /// *   unresolved
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The description of the instance.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The outbound public CIDR blocks of the instance. For example, when you synchronize Active Directory (AD) accounts, the IDaaS EIAM instance accesses your AD service by using the outbound public CIDR blocks.
            /// </summary>
            [NameInMap("EgressAddresses")]
            [Validation(Required=false)]
            public List<string> EgressAddresses { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The status of the instance. Valid values:
            /// 
            /// *   creating
            /// *   running
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
