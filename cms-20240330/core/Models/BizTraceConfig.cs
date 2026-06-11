// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class BizTraceConfig : TeaModel {
        /// <summary>
        /// <para>The advanced configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;sample&quot;:{&quot;strategy&quot;:&quot;BY_APP&quot;}}</para>
        /// </summary>
        [NameInMap("advancedConfig")]
        [Validation(Required=false)]
        public string AdvancedConfig { get; set; }

        /// <summary>
        /// <para>The business trace identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>label_env</para>
        /// </summary>
        [NameInMap("bizTraceCode")]
        [Validation(Required=false)]
        public string BizTraceCode { get; set; }

        /// <summary>
        /// <para>The business trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e339260ed64c95d</para>
        /// </summary>
        [NameInMap("bizTraceId")]
        [Validation(Required=false)]
        public string BizTraceId { get; set; }

        /// <summary>
        /// <para>The business trace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>just test</para>
        /// </summary>
        [NameInMap("bizTraceName")]
        [Validation(Required=false)]
        public string BizTraceName { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-12-12 00:00:00</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of configuration rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;entrancePid&quot;:&quot;xxxxx@b57c44xx6e86&quot;,&quot;rpcMatcher&quot;:{&quot;matchType&quot;:&quot;EQUALS&quot;,&quot;pattern&quot;:&quot;/createApp&quot;},&quot;characteristics&quot;:{&quot;operation&quot;:&quot;AND&quot;,&quot;rules&quot;:[{&quot;target&quot;:&quot;CUSTOM_EXTRACT&quot;,&quot;matcher&quot;:{&quot;matchType&quot;:&quot;CONTAINS&quot;,&quot;pattern&quot;:[]}}]}}]</para>
        /// </summary>
        [NameInMap("ruleConfig")]
        [Validation(Required=false)]
        public string RuleConfig { get; set; }

        /// <summary>
        /// <para>The workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-cms-xxxxxxx-cn-hangzhou</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
