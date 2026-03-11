// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class GetVpcConfigResponseBody : TeaModel {
        [NameInMap("trustedVpcs")]
        [Validation(Required=false)]
        public List<GetVpcConfigResponseBodyTrustedVpcs> TrustedVpcs { get; set; }
        public class GetVpcConfigResponseBodyTrustedVpcs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1744970111419</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            [NameInMap("extendedOptions")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtendedOptions { get; set; }

            /// <summary>
            /// <para>VPC ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf67xxxx</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
