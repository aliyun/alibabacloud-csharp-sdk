// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class GetVpcConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>List of trusted VPCs.</para>
        /// </summary>
        [NameInMap("trustedVpcs")]
        [Validation(Required=false)]
        public List<GetVpcConfigResponseBodyTrustedVpcs> TrustedVpcs { get; set; }
        public class GetVpcConfigResponseBodyTrustedVpcs : TeaModel {
            /// <summary>
            /// <para>The time when the VPC was created, in UNIX timestamp milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1744970111419</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            /// <summary>
            /// <para>List of configuration items.</para>
            /// </summary>
            [NameInMap("extendedOptions")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtendedOptions { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
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
