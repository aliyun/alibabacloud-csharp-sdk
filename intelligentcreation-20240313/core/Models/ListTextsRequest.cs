// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class ListTextsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("generationSource")]
        [Validation(Required=false)]
        public string GenerationSource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Common</para>
        /// </summary>
        [NameInMap("industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PUBLISH</para>
        /// </summary>
        [NameInMap("publishStatus")]
        [Validation(Required=false)]
        public string PublishStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WECHAT_MOMENT</para>
        /// </summary>
        [NameInMap("textStyleType")]
        [Validation(Required=false)]
        public string TextStyleType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("textTheme")]
        [Validation(Required=false)]
        public string TextTheme { get; set; }

    }

}
