// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class CancelCollectionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the favorite user. The user ID is the UserID of the Quick BI, not the UID of Alibaba Cloud.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121344444790****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The ID of the work to cancel the collection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5d6ae4e7-cede-43cd-b4d3-d2fd442a9202</para>
        /// </summary>
        [NameInMap("WorksId")]
        [Validation(Required=false)]
        public string WorksId { get; set; }

    }

}
