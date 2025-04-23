// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class ListTracesDatasShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>end-user.12345</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        [NameInMap("Filters")]
        [Validation(Required=false)]
        public string FiltersShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("HasEvents")]
        [Validation(Required=false)]
        public bool? HasEvents { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("HasStatusMessage")]
        [Validation(Required=false)]
        public bool? HasStatusMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>My.super_LLM-app2</para>
        /// </summary>
        [NameInMap("LlmAppName")]
        [Validation(Required=false)]
        public string LlmAppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-01-31
        /// 2024-12-31 23:59:59</para>
        /// </summary>
        [NameInMap("MaxTime")]
        [Validation(Required=false)]
        public string MaxTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-31
        /// 2024-12-31 23:59:59</para>
        /// </summary>
        [NameInMap("MinTime")]
        [Validation(Required=false)]
        public string MinTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("OpentelemetryCompatible")]
        [Validation(Required=false)]
        public bool? OpentelemetryCompatible { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("OwnerSubId")]
        [Validation(Required=false)]
        public string OwnerSubId { get; set; }

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

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        [NameInMap("SpanIds")]
        [Validation(Required=false)]
        public string SpanIdsShrink { get; set; }

        [NameInMap("TraceIds")]
        [Validation(Required=false)]
        public string TraceIdsShrink { get; set; }

        [NameInMap("TraceReduceMethod")]
        [Validation(Required=false)]
        public string TraceReduceMethod { get; set; }

    }

}
