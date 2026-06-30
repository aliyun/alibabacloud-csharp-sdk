// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class TestRuleV4Request : TeaModel {
        /// <summary>
        /// <para>Whether this is the new quality check version. Valid values: 0 (legacy version) and 1 (new version). Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsSchemeData")]
        [Validation(Required=false)]
        public int? IsSchemeData { get; set; }

        /// <summary>
        /// <para>JSON request parameters for rule testing. For details, see the supplemental description of request parameters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ruleList&quot;:[9771],&quot;dialogues&quot;:[{&quot;begin&quot;:0,&quot;end&quot;:760,&quot;hourMinSec&quot;:&quot;00:00&quot;,&quot;role&quot;:&quot;客户&quot;,&quot;identity&quot;:&quot;客户&quot;,&quot;words&quot;:&quot;123&quot;},{&quot;begin&quot;:21004,&quot;end&quot;:21494,&quot;hourMinSec&quot;:&quot;00:21&quot;,&quot;role&quot;:&quot;客服&quot;,&quot;identity&quot;:&quot;客服&quot;,&quot;words&quot;:&quot;123&quot;}]}</para>
        /// </summary>
        [NameInMap("TestJson")]
        [Validation(Required=false)]
        public string TestJson { get; set; }

    }

}
