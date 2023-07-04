// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVpcEndpointServicesByEndUserResponseBody : TeaModel {
        /// <summary>
        /// The ID of the endpoint service.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The list of entries returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The name of the endpoint service.
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<ListVpcEndpointServicesByEndUserResponseBodyServices> Services { get; set; }
        public class ListVpcEndpointServicesByEndUserResponseBodyServices : TeaModel {
            /// <summary>
            /// The domain name of the cloud service to which the endpoint service belongs.
            /// </summary>
            [NameInMap("DefaultPolicyDocument")]
            [Validation(Required=false)]
            public string DefaultPolicyDocument { get; set; }

            [NameInMap("ServiceDomain")]
            [Validation(Required=false)]
            public string ServiceDomain { get; set; }

            /// <summary>
            /// The default access policy.
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// Indicate whether the endpoint service supports the access policy. Valid values:
            /// 
            /// *   **false**: no
            /// *   **true**: yes
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("SupportPolicy")]
            [Validation(Required=false)]
            public bool? SupportPolicy { get; set; }

        }

    }

}
