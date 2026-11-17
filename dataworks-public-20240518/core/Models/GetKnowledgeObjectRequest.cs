// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetKnowledgeObjectRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the knowledge base.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abc</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The ID of the long-term business object.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>obj-001</para>
        /// </summary>
        [NameInMap("KnowledgeObjectId")]
        [Validation(Required=false)]
        public string KnowledgeObjectId { get; set; }

        /// <summary>
        /// <para>Applies only to semantic models. Specifies the version to read. If omitted, the operation returns the published version if available, or the latest version otherwise.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VersionNo")]
        [Validation(Required=false)]
        public long? VersionNo { get; set; }

    }

}
