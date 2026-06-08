// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListPendingApprovalsShrinkRequest : TeaModel {
        [NameInMap("AccessTypes")]
        [Validation(Required=false)]
        public string AccessTypesShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("DefSchema")]
        [Validation(Required=false)]
        public string DefSchema { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1779724799999</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("Grantee")]
        [Validation(Required=false)]
        public string GranteeShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJpZCI6MTIzfQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string ResourceShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;table&quot;, &quot;column&quot;]</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceTypeShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1771948800000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
