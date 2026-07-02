// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DocumentChapterSummarizeOption : TeaModel {
        /// <summary>
        /// <para>The number of section-by-section summaries. If neither Marker nor Index is specified, the entire article is summarized by default. Marker and Index must either both be specified or both be omitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The start position for section-by-section summarization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public int? Marker { get; set; }

        /// <summary>
        /// <para>The version of section-by-section summarization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
