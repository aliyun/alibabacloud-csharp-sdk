// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class UpdateVpcConfigRequest : TeaModel {
        /// <summary>
        /// <para>The list of VPC IDs to delete.</para>
        /// </summary>
        [NameInMap("removals")]
        [Validation(Required=false)]
        public List<string> Removals { get; set; }

        /// <summary>
        /// <para>The list of VPCs to update.</para>
        /// </summary>
        [NameInMap("updates")]
        [Validation(Required=false)]
        public List<UpdateVpcConfigRequestUpdates> Updates { get; set; }
        public class UpdateVpcConfigRequestUpdates : TeaModel {
            /// <summary>
            /// <para>The list of configuration items.</para>
            /// </summary>
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
