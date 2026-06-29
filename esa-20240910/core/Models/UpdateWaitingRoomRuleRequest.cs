// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateWaitingRoomRuleRequest : TeaModel {
        /// <summary>
        /// <para>The rule content. A conditional expression is used to match user requests. This parameter is not required when you add a global configuration. Two scenarios are supported:</para>
        /// <list type="bullet">
        /// <item><description>Match all incoming requests: set the value to true.</description></item>
        /// <item><description>Match specified requests: set the value to a custom expression, for example, (http.host eq \&quot;video.example.com\&quot;).</description></item>
        /// </list>
        /// <para>For the complete syntax of rule expressions, refer to
        /// &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/edge-security-acceleration/esa/user-guide/work-with-rules-engine/">https://www.alibabacloud.com/help/en/edge-security-acceleration/esa/user-guide/work-with-rules-engine/</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/edge-security-acceleration/esa/user-guide/work-with-rules-engine/">https://www.alibabacloud.com/help/edge-security-acceleration/esa/user-guide/work-with-rules-engine/</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>(http.request.uri.path.file_name eq \&quot;jpg\&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the rule. This parameter is not required when you add a global configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enabled.</description></item>
        /// <item><description>off: disabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RuleEnable")]
        [Validation(Required=false)]
        public string RuleEnable { get; set; }

        /// <summary>
        /// <para>The rule name. This parameter is not required when you add a global configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The ID of the waiting room bypass rule to update. You can obtain this ID after creating a rule by calling CreateWaitingRoomRule, or by calling the <a href="https://help.aliyun.com/document_detail/2850279.html">ListWaitingRoomRules</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8987739839****</para>
        /// </summary>
        [NameInMap("WaitingRoomRuleId")]
        [Validation(Required=false)]
        public long? WaitingRoomRuleId { get; set; }

    }

}
