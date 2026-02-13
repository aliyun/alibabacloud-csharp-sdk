// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ChunkItem : TeaModel {
        [NameInMap("chunkContent")]
        [Validation(Required=false)]
        public string ChunkContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b0x7,b1x10</para>
        /// </summary>
        [NameInMap("chunkId")]
        [Validation(Required=false)]
        public string ChunkId { get; set; }

        [NameInMap("docElsIds")]
        [Validation(Required=false)]
        public List<string> DocElsIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b4620821aea92c062d8d19ad793243669cf9ae2b900e6967dee6ee9f3bf5feed</para>
        /// </summary>
        [NameInMap("docId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        [NameInMap("docName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>jobs/a4123b3f-9287-4c61-b59d-32e40fcb0a31/document/8b24a2e06669427fb3dc9812374d9d1a.pdf</para>
        /// </summary>
        [NameInMap("docUrl")]
        [Validation(Required=false)]
        public string DocUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.5053711</para>
        /// </summary>
        [NameInMap("rerankScore")]
        [Validation(Required=false)]
        public float? RerankScore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.4295678</para>
        /// </summary>
        [NameInMap("score")]
        [Validation(Required=false)]
        public float? Score { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.47252458</para>
        /// </summary>
        [NameInMap("weightedScore")]
        [Validation(Required=false)]
        public float? WeightedScore { get; set; }

    }

}
