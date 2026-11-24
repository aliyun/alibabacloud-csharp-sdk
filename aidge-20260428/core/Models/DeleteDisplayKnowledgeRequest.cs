// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class DeleteDisplayKnowledgeRequest : TeaModel {
        /// <summary>
        /// <para>The knowledge base ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rag_x x x</para>
        /// </summary>
        [NameInMap("RagId")]
        [Validation(Required=false)]
        public string RagId { get; set; }

        /// <summary>
        /// <para>The IDs of the records to be deleted. A maximum of 500 records can be specified.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordIds")]
        [Validation(Required=false)]
        public List<long?> RecordIds { get; set; }

    }

}
