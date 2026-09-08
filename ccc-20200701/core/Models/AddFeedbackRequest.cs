// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class AddFeedbackRequest : TeaModel {
        /// <summary>
        /// <para>The feedback provided by returning users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;问题描述&quot;:&quot;客户询问沙发生产周期并尝试加快&quot;, &quot;客服方案&quot;:&quot;订单确认，建议联系在线客服&quot;, &quot;完成度判断&quot;:&quot;否&quot;}</para>
        /// </summary>
        [NameInMap("Feedback")]
        [Validation(Required=false)]
        public string Feedback { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Rating:</para>
        /// <list type="bullet">
        /// <item><description><para>thumbsDown: Thumbs down.</para>
        /// </description></item>
        /// <item><description><para>thumbsUp: Thumbs up.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>thumbsUp</para>
        /// </summary>
        [NameInMap("Rating")]
        [Validation(Required=false)]
        public int? Rating { get; set; }

        /// <summary>
        /// <para>AI task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f780ade8-****-458b-b067-63077946a570</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>Task type.</para>
        /// <list type="bullet">
        /// <item><description><para>Abstract:fields (Field extraction)</para>
        /// </description></item>
        /// <item><description><para>Abstract:keywords (Hot keywords)</para>
        /// </description></item>
        /// <item><description><para>Abstract:title_summary (Summary)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Abstract:fields</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
