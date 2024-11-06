// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchCreateDcdnWafRulesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the protection policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000001</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// <para>The configuration of the protection rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;ttttt&quot;,&quot;action&quot;:&quot;monitor&quot;,&quot;conditions&quot;:[{&quot;key&quot;:&quot;URL&quot;,&quot;opValue&quot;:&quot;match-one&quot;,&quot;values&quot;:&quot;1,2,3,4,5&quot;},{&quot;key&quot;:&quot;Header&quot;,&quot;opValue&quot;:&quot;contain-one&quot;,&quot;subKey&quot;:&quot;testheader&quot;,&quot;values&quot;:&quot;6,7,8,9,10&quot;}],&quot;ratelimit&quot;:{&quot;target&quot;:&quot;header&quot;,&quot;interval&quot;:10,&quot;threshold&quot;:5,&quot;ttl&quot;:1800,&quot;subKey&quot;:&quot;testheadercc&quot;,&quot;status&quot;:{&quot;code&quot;:&quot;502&quot;,&quot;count&quot;:5}},&quot;ccStatus&quot;:&quot;on&quot;,&quot;effect&quot;:&quot;rule&quot;,&quot;status&quot;:&quot;on&quot;}</para>
        /// </summary>
        [NameInMap("RuleConfigs")]
        [Validation(Required=false)]
        public string RuleConfigs { get; set; }

    }

}
