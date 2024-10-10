// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDatasetDetailInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the training dataset that you want to remove from the specified custom linguistic model.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5820f58c-c734-4d8a-baf1-7979af4f****</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

    }

}
