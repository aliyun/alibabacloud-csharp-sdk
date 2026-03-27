// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateBizTraceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;sample&quot;:{&quot;strategy&quot;:&quot;BY_APP&quot;}}</para>
        /// </summary>
        [NameInMap("advancedConfig")]
        [Validation(Required=false)]
        public string AdvancedConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>just test</para>
        /// </summary>
        [NameInMap("bizTraceName")]
        [Validation(Required=false)]
        public string BizTraceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;entrancePid&quot;:&quot;xxx@d9w3jd9j3&quot;,&quot;rpcMatcher&quot;:{&quot;matchType&quot;:&quot;EQUALS&quot;,&quot;pattern&quot;:&quot;/&quot;},&quot;characteristics&quot;:{&quot;operation&quot;:&quot;OR&quot;,&quot;rules&quot;:[{&quot;target&quot;:&quot;CUSTOM_EXTRACT&quot;,&quot;id&quot;:&quot;oi0b3bb7&quot;,&quot;key&quot;:&quot;biz.test&quot;,&quot;matcher&quot;:{&quot;matchType&quot;:&quot;CONTAINS&quot;,&quot;pattern&quot;:[&quot;1&quot;]}}]}}]</para>
        /// </summary>
        [NameInMap("ruleConfig")]
        [Validation(Required=false)]
        public string RuleConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default-cms-xxxxxxx-cn-hangzhou</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
