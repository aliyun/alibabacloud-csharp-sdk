// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafScenesResponseBody : TeaModel {
        /// <summary>
        /// <para>The types of the protection policies.</para>
        /// </summary>
        [NameInMap("DefenseScenes")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafScenesResponseBodyDefenseScenes> DefenseScenes { get; set; }
        public class DescribeDcdnWafScenesResponseBodyDefenseScenes : TeaModel {
            /// <summary>
            /// <para>The type of the protection policy, which is the same as the DefenseScenes parameter in request parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf_group</para>
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            /// <summary>
            /// <para>The total number of policies of this type that were configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PolicyCount")]
            [Validation(Required=false)]
            public int? PolicyCount { get; set; }

            /// <summary>
            /// <para>The total number of protection rules that were configured in this type of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D7BB13C-DD84-5654-A835-B8E1385DE274</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
