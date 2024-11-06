// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchModifyDcdnWafRulesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the protection policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// <para>The configurations of the protection rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;id&quot;:135,&quot;type&quot;:&quot;web_sdk&quot;,&quot;status&quot;:&quot;on&quot;,&quot;config&quot;:{&quot;mode&quot;:&quot;automatic&quot;,&quot;crossDomain&quot;:&quot;example.com&quot;},&quot;action&quot;:&quot;&quot;},{&quot;id&quot;:149,&quot;type&quot;:&quot;intelligence_fake_crawler&quot;,&quot;status&quot;:&quot;on&quot;,&quot;config&quot;:{},&quot;action&quot;:&quot;deny&quot;}]</para>
        /// </summary>
        [NameInMap("RuleConfigs")]
        [Validation(Required=false)]
        public string RuleConfigs { get; set; }

    }

}
