// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ConfirmInventoryKnowledgeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TABLE</para>
        /// </summary>
        [NameInMap("KnowledgeType")]
        [Validation(Required=false)]
        public string KnowledgeType { get; set; }

    }

}
