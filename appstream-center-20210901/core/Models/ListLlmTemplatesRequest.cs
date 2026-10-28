// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListLlmTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The business type. This parameter is required when SmartModel is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The display language of the model. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Simplified Chinese.</description></item>
        /// <item><description>en-US: English.</description></item>
        /// <item><description>ja-JP: Japanese.</description></item>
        /// <item><description>zh-TW: Traditional Chinese.
        /// Default value: zh-CN. Currently, zh-TW returns Simplified Chinese, and ja-JP returns English. If the model is not included in Alibaba Cloud Model Studio or the English text is missing, the original source text is retained without automatic translation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The model code for filtering. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3.6-plus</para>
        /// </summary>
        [NameInMap("LlmCode")]
        [Validation(Required=false)]
        public string LlmCode { get; set; }

        /// <summary>
        /// <para>The model template IDs for filtering.</para>
        /// </summary>
        [NameInMap("LlmTemplateIds")]
        [Validation(Required=false)]
        public List<string> LlmTemplateIds { get; set; }

        /// <summary>
        /// <para>The associated model group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mt-xxxx</para>
        /// </summary>
        [NameInMap("ModelTemplateId")]
        [Validation(Required=false)]
        public string ModelTemplateId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. A value of 0 returns the same result as 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The model provider template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mpt-xxxx</para>
        /// </summary>
        [NameInMap("ProviderTemplateId")]
        [Validation(Required=false)]
        public string ProviderTemplateId { get; set; }

        /// <summary>
        /// <para>Specifies whether to query smart models. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Only LLMs under system-preset smart models are returned. In this case, BizType is required.</description></item>
        /// <item><description>false: Smart models are not specifically filtered.
        /// Default value: false.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SmartModel")]
        [Validation(Required=false)]
        public bool? SmartModel { get; set; }

    }

}
