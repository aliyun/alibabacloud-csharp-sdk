// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateFaqRequest : TeaModel {
        /// <summary>
        /// <para>The key of the business space. If this parameter is not set, the default business space is accessed. You can obtain the key value from the business management page of the main account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The category ID of the knowledge entry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000053274</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// <para>The expiration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2030-12-31T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The default answer content. This parameter is required if the fallback perspective is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test answer</para>
        /// </summary>
        [NameInMap("SolutionContent")]
        [Validation(Required=false)]
        public string SolutionContent { get; set; }

        /// <summary>
        /// <para>The type of the default answer. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: plain text.</description></item>
        /// <item><description>1: rich text.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SolutionType")]
        [Validation(Required=false)]
        public int? SolutionType { get; set; }

        /// <summary>
        /// <para>The effective period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-25T16:28:36Z</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The list of label IDs.</para>
        /// </summary>
        [NameInMap("TagIdList")]
        [Validation(Required=false)]
        public List<long?> TagIdList { get; set; }

        /// <summary>
        /// <para>The title of the knowledge entry. Maximum length: 120 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
