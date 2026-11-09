// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListModelProviderLlmCodesRequest : TeaModel {
        /// <summary>
        /// <para>The display language of the model. Valid values: zh-CN (Simplified Chinese), en-US (English), ja-JP (Japanese), and zh-TW (Traditional Chinese). Default value: zh-CN. Currently, zh-TW returns Simplified Chinese, and ja-JP returns English. If the model is not included in Model Studio or the English text is missing, the original source text is retained without automatic translation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The LLM code used for fuzzy match filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3-max</para>
        /// </summary>
        [NameInMap("LlmCode")]
        [Validation(Required=false)]
        public string LlmCode { get; set; }

        /// <summary>
        /// <para>The list of model brands in a JSON array string. Supports multi-select filtering. Models matching any of the specified brands are returned.</para>
        /// </summary>
        [NameInMap("ModelBrands")]
        [Validation(Required=false)]
        public List<string> ModelBrands { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 1000. Maximum value: 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the model provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>moonshot</para>
        /// </summary>
        [NameInMap("ProviderName")]
        [Validation(Required=false)]
        public string ProviderName { get; set; }

        /// <summary>
        /// <para>The ID of the provider template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pt-xxx-001</para>
        /// </summary>
        [NameInMap("ProviderTemplateId")]
        [Validation(Required=false)]
        public string ProviderTemplateId { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter models by recommendation status. If this parameter is not specified, models are not filtered by recommendation status.</para>
        /// </summary>
        [NameInMap("Recommended")]
        [Validation(Required=false)]
        public bool? Recommended { get; set; }

        /// <summary>
        /// <para>The list of recommendation levels. This parameter takes effect only for wuying-plan. Models matching any of the specified levels and meeting other filter conditions such as region and brand are returned. If this parameter is not specified or an empty array is passed, models are not filtered by recommendation level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Standard&quot;,&quot;Advanced&quot;]</para>
        /// </summary>
        [NameInMap("RecommendedLevels")]
        [Validation(Required=false)]
        public List<string> RecommendedLevels { get; set; }

    }

}
