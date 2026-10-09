// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class CreateAnnualDocSummaryTaskRequest : TeaModel {
        /// <summary>
        /// <para>The list of analysis years.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("anaYears")]
        [Validation(Required=false)]
        public List<int?> AnaYears { get; set; }

        /// <summary>
        /// <para>The list of document information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("docInfos")]
        [Validation(Required=false)]
        public List<CreateAnnualDocSummaryTaskRequestDocInfos> DocInfos { get; set; }
        public class CreateAnnualDocSummaryTaskRequestDocInfos : TeaModel {
            /// <summary>
            /// <para>The document ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>198386463432</para>
            /// </summary>
            [NameInMap("docId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            /// <summary>
            /// <para>The document year.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023</para>
            /// </summary>
            [NameInMap("docYear")]
            [Validation(Required=false)]
            public int? DocYear { get; set; }

            /// <summary>
            /// <para>The end page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("endPage")]
            [Validation(Required=false)]
            public int? EndPage { get; set; }

            /// <summary>
            /// <para>The document library ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rdxrmo6amk</para>
            /// </summary>
            [NameInMap("libraryId")]
            [Validation(Required=false)]
            public string LibraryId { get; set; }

            /// <summary>
            /// <para>The start page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("startPage")]
            [Validation(Required=false)]
            public int? StartPage { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable tables. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableTable")]
        [Validation(Required=false)]
        public bool? EnableTable { get; set; }

        /// <summary>
        /// <para>The instruction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are a senior securities researcher conducting performance analysis on listed companies for the year XX. Based on the reference information, provide a detailed analysis covering the following aspects:</para>
        /// <ol>
        /// <item><description>Overall performance changes, including detailed metrics such as revenue and profit.</description></item>
        /// <item><description>Specific reasons for performance changes, including changes in each business segment.
        /// Strictly output only the information for the year XX</description></item>
        /// </ol>
        /// </summary>
        [NameInMap("instruction")]
        [Validation(Required=false)]
        public string Instruction { get; set; }

        /// <summary>
        /// <para>The model ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

    }

}
