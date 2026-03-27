// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListDeliveryTasksShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test-task</para>
        /// </summary>
        [NameInMap("keyWords")]
        [Validation(Required=false)]
        public string KeyWords { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sjC5rekx93Ew7K7VcmI3wkBZBYQ-GphB2ilQu3zJCGxoZuicwyJznfo2riTjr-lq</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-aek2bhocin5e2na</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

    }

}
