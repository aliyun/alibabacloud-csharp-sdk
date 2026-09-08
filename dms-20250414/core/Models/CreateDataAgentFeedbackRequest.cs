// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateDataAgentFeedbackRequest : TeaModel {
        /// <summary>
        /// <para>The current DMS unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <para>The feedback content. You can directly enter the feedback content, or pass a JSON string for the issue report scenario as shown in the example. The feedback_type field corresponds to the issue type, user_feedback corresponds to the issue description, email corresponds to the contact email address, and is_authorized indicates whether to authorize log access for troubleshooting.</para>
        /// <para>feedback_type issue types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ANALYSIS_RESULT_INACCURATE</b>: Inaccurate analysis result.</description></item>
        /// <item><description><b>RUNTIME_ERROR</b>: Runtime error.</description></item>
        /// <item><description><b>REPORT_EXCEPTION</b>: Report exception.</description></item>
        /// <item><description><b>SLOW_RESPONSE</b>: Slow response.</description></item>
        /// <item><description><b>PRODUCT_SUGGESTION</b>: Product suggestion.</description></item>
        /// <item><description><b>OTHER</b>: Other.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;feedback_type&quot;:&quot;PRODUCT_SUGGESTION&quot;,&quot;user_feedback&quot;: &quot;test&quot;,&quot;email&quot;:&quot;<a href="mailto:yourname@example.com">yourname@example.com</a>&quot;,&quot;is_authorized&quot;:&quot;Y&quot;}</para>
        /// </summary>
        [NameInMap("FeedbackContent")]
        [Validation(Required=false)]
        public string FeedbackContent { get; set; }

        /// <summary>
        /// <para>The feedback type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ISSUE_REPORT</b>: issue report.</description></item>
        /// <item><description><b>CANCEL_CHAT</b>: task cancellation.</description></item>
        /// <item><description><b>LIKE</b>: like.</description></item>
        /// <item><description><b>DISLIKE</b>: dislike.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ISSUE_REPORT</para>
        /// </summary>
        [NameInMap("FeedbackType")]
        [Validation(Required=false)]
        public string FeedbackType { get; set; }

        /// <summary>
        /// <para>The like value. This parameter is used only for like and dislike scenarios. Do not pass this parameter for other scenarios. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: like.</description></item>
        /// <item><description><b>-1</b>: dislike.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LikeValue")]
        [Validation(Required=false)]
        public int? LikeValue { get; set; }

        /// <summary>
        /// <para>The agent session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>h8r********4fch</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The feedback target ID.</para>
        /// <list type="bullet">
        /// <item><description>For issue reports, use SessionId + underscore + random UUID.</description></item>
        /// <item><description>For other feedback types, pass the checkpoint of the current SSE message stream.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>h8r********4fch_sdesfews</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The feedback target. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SESSION</b>: session (used for issue reports).</description></item>
        /// <item><description><b>CHAT</b>: chat (used for task cancellation).</description></item>
        /// <item><description><b>REPORT</b>: report.</description></item>
        /// <item><description><b>PLAN</b>: execution plan.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SESSION</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>56kv1pvl9uvt9**********bb</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
