// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the accelerated domain name.</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public DescribeDcdnWafDomainDetailResponseBodyDomain Domain { get; set; }
        public class DescribeDcdnWafDomainDetailResponseBodyDomain : TeaModel {
            /// <summary>
            /// <para>The types of the protection policies.</para>
            /// </summary>
            [NameInMap("DefenseScenes")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafDomainDetailResponseBodyDomainDefenseScenes> DefenseScenes { get; set; }
            public class DescribeDcdnWafDomainDetailResponseBodyDomainDefenseScenes : TeaModel {
                /// <summary>
                /// <para>The type of the protection policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>waf_group: basic web protection</description></item>
                /// <item><description>custom_acl: custom protection</description></item>
                /// <item><description>whitelist: whitelist</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>waf_group</para>
                /// </summary>
                [NameInMap("DefenseScene")]
                [Validation(Required=false)]
                public string DefenseScene { get; set; }

                /// <summary>
                /// <para>The ID of the protection policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000002</para>
                /// </summary>
                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public long? PolicyId { get; set; }

                /// <summary>
                /// <para>The IDs of the protection policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000001,10000004</para>
                /// </summary>
                [NameInMap("PolicyIds")]
                [Validation(Required=false)]
                public string PolicyIds { get; set; }

            }

            /// <summary>
            /// <para>The accelerated domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>153ca2cd-3c01-44be-82C0-64dbc6c88630</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
