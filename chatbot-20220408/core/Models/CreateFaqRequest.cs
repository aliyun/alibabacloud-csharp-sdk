// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateFaqRequest : TeaModel {
        /// <summary>
        /// <para>The agent key. If omitted, the default agent is used. Find this key on the Agent Management page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The ID of the knowledge category.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000053274</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// <para>The knowledge end time. The time is in UTC and in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2030-12-31T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The content of the default solution. Required if the fallback feature is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试答案</para>
        /// </summary>
        [NameInMap("SolutionContent")]
        [Validation(Required=false)]
        public string SolutionContent { get; set; }

        /// <summary>
        /// <para>The type of the default solution. Valid values: <c>0</c> (plain text) and <c>1</c> (rich text).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SolutionType")]
        [Validation(Required=false)]
        public int? SolutionType { get; set; }

        /// <summary>
        /// <para>The knowledge start time. The time is in UTC and in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-25T16:28:36Z</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>A list of tag IDs to associate with the knowledge.</para>
        /// </summary>
        [NameInMap("TagIdList")]
        [Validation(Required=false)]
        public List<long?> TagIdList { get; set; }

        /// <summary>
        /// <para>The knowledge title. Max length: 120 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试标题</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
