// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class CreateDocsSummaryTaskRequest : TeaModel {
        /// <summary>
        /// <para>Document information list</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("docInfos")]
        [Validation(Required=false)]
        public List<CreateDocsSummaryTaskRequestDocInfos> DocInfos { get; set; }
        public class CreateDocsSummaryTaskRequestDocInfos : TeaModel {
            /// <summary>
            /// <para>Document ID</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>198386463432</para>
            /// </summary>
            [NameInMap("docId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            /// <summary>
            /// <para>End page number</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("endPage")]
            [Validation(Required=false)]
            public int? EndPage { get; set; }

            /// <summary>
            /// <para>Document library ID</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rdxrmo6amk</para>
            /// </summary>
            [NameInMap("libraryId")]
            [Validation(Required=false)]
            public string LibraryId { get; set; }

            /// <summary>
            /// <para>Start page number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("startPage")]
            [Validation(Required=false)]
            public int? StartPage { get; set; }

        }

        /// <summary>
        /// <para>Enable table parsing. Default is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableTable")]
        [Validation(Required=false)]
        public bool? EnableTable { get; set; }

        /// <summary>
        /// <para>Instruction</para>
        /// 
        /// <b>Example:</b>
        /// <para>你是资深的证券研究员，对xx年上市公司进行业绩分析。根据参考信息从如下方面详细分析：</para>
        /// <ol>
        /// <item><description>整体业绩变化情况，包括营收，利润等详细指标变化情况</description></item>
        /// <item><description>业绩变化情况具体原因，包括各个业务变化情况
        /// 严格只输出xx年情况。</description></item>
        /// </ol>
        /// </summary>
        [NameInMap("instruction")]
        [Validation(Required=false)]
        public string Instruction { get; set; }

        /// <summary>
        /// <para>Model ID</para>
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
