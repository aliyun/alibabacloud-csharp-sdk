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
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The model code filter. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3.6-plus</para>
        /// </summary>
        [NameInMap("LlmCode")]
        [Validation(Required=false)]
        public string LlmCode { get; set; }

        /// <summary>
        /// <para>The model template IDs used for filtering.</para>
        /// </summary>
        [NameInMap("LlmTemplateIds")]
        [Validation(Required=false)]
        public List<string> LlmTemplateIds { get; set; }

        /// <summary>
        /// <para>The ID of the associated model group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mt-xxxx</para>
        /// </summary>
        [NameInMap("ModelTemplateId")]
        [Validation(Required=false)]
        public string ModelTemplateId { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1. Values 0 and 1 return the same result.</para>
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
        /// <para>The ID of the model provider template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mpt-xxxx</para>
        /// </summary>
        [NameInMap("ProviderTemplateId")]
        [Validation(Required=false)]
        public string ProviderTemplateId { get; set; }

        /// <summary>
        /// <para>Specifies whether to query smart models. If set to true, only LLMs under system preset smart models are returned, and BizType is required. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SmartModel")]
        [Validation(Required=false)]
        public bool? SmartModel { get; set; }

    }

}
