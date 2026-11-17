// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GrantKnowledgeBaseRetrievalRequest : TeaModel {
        /// <summary>
        /// <para>The knowledge base ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abc</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The DataWorks user ID of the target user. This is not the RAM UID or the caller identity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000000000</para>
        /// </summary>
        [NameInMap("PrincipalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// <para>The type of the principal that receives the share. This parameter is optional and defaults to USER. Currently, only USER is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("PrincipalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

    }

}
