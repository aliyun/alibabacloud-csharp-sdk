// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration of the rule.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public WafRuleConfig Config { get; set; }

        /// <summary>
        /// <para>The ID of the WAF rule.<a href="~~2850237~~"></a></para>
        /// 
        /// <b>Example:</b>
        /// <para>2000001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The rule name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The WAF rule category.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_custom</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The order of the rule in the ruleset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Position")]
        [Validation(Required=false)]
        public long? Position { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the rule is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the rule was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
