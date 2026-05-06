// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListLlmTemplatesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen3.6-plus</para>
        /// </summary>
        [NameInMap("LlmCode")]
        [Validation(Required=false)]
        public string LlmCode { get; set; }

        [NameInMap("LlmTemplateIds")]
        [Validation(Required=false)]
        public List<string> LlmTemplateIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mt-xxxx</para>
        /// </summary>
        [NameInMap("ModelTemplateId")]
        [Validation(Required=false)]
        public string ModelTemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mpt-xxxx</para>
        /// </summary>
        [NameInMap("ProviderTemplateId")]
        [Validation(Required=false)]
        public string ProviderTemplateId { get; set; }

    }

}
