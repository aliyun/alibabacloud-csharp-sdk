// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class RetrieveRequest : TeaModel {
        [NameInMap("documentIds")]
        [Validation(Required=false)]
        public List<long?> DocumentIds { get; set; }

        [NameInMap("folderIds")]
        [Validation(Required=false)]
        public List<string> FolderIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("preRetrieveTopK")]
        [Validation(Required=false)]
        public int? PreRetrieveTopK { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;What\&quot;s the meaning of the file?&quot;</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("rerankerThreshold")]
        [Validation(Required=false)]
        public float? RerankerThreshold { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("topK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        [NameInMap("useReranker")]
        [Validation(Required=false)]
        public bool? UseReranker { get; set; }

    }

}
