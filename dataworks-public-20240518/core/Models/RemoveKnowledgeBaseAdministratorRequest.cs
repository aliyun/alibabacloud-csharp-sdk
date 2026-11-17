// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class RemoveKnowledgeBaseAdministratorRequest : TeaModel {
        /// <summary>
        /// <para>The DataWorks user ID of the administrator to be removed. This is not the identity of the caller.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000000000000</para>
        /// </summary>
        [NameInMap("AdministratorUserId")]
        [Validation(Required=false)]
        public string AdministratorUserId { get; set; }

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

    }

}
