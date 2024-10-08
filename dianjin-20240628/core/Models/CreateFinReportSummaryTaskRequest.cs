// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class CreateFinReportSummaryTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("docId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableTable")]
        [Validation(Required=false)]
        public bool? EnableTable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("endPage")]
        [Validation(Required=false)]
        public int? EndPage { get; set; }

        [NameInMap("instruction")]
        [Validation(Required=false)]
        public string Instruction { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3akzl28vap</para>
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("startPage")]
        [Validation(Required=false)]
        public int? StartPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
