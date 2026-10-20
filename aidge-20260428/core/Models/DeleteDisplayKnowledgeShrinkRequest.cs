// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class DeleteDisplayKnowledgeShrinkRequest : Darabonba.Model {
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
        /// <para>The IDs of the records to delete. You can specify up to 500 record IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RecordIds")]
        [Validation(Required=false)]
        public string RecordIdsShrink { get; set; }

    }

}

