// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DeleteKnowledgeObjectRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the knowledge base to which the object belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abc</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The stable ID of the object to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>obj-document-001</para>
        /// </summary>
        [NameInMap("KnowledgeObjectId")]
        [Validation(Required=false)]
        public string KnowledgeObjectId { get; set; }

    }

}
