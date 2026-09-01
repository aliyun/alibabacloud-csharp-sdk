// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateDataAgentFeedbackRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;feedback_type&quot;:&quot;PRODUCT_SUGGESTION&quot;,&quot;user_feedback&quot;: &quot;test&quot;,&quot;email&quot;:&quot;<a href="mailto:yourname@example.com">yourname@example.com</a>&quot;,&quot;is_authorized&quot;:&quot;Y&quot;}</para>
        /// </summary>
        [NameInMap("FeedbackContent")]
        [Validation(Required=false)]
        public string FeedbackContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ISSUE_REPORT</para>
        /// </summary>
        [NameInMap("FeedbackType")]
        [Validation(Required=false)]
        public string FeedbackType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LikeValue")]
        [Validation(Required=false)]
        public int? LikeValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>h8r********4fch</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>h8r********4fch_sdesfews</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SESSION</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>56kv1pvl9uvt9**********bb</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
