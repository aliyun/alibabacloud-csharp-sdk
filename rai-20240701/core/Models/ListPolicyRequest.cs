// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class ListPolicyRequest : TeaModel {
        [NameInMap("IsSidecarPolicy")]
        [Validation(Required=false)]
        public int? IsSidecarPolicy { get; set; }

        /// <summary>
        /// <para>Sort order. The value range is as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>asc (default): ascending</para>
        /// </description></item>
        /// <item><description><para>desc: descending</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>Page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, the maximum number of results returned per page.
        /// Maximum limit: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Policy identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x1bc5xgs4uhx</para>
        /// </summary>
        [NameInMap("PolicyIdentifier")]
        [Validation(Required=false)]
        public string PolicyIdentifier { get; set; }

        /// <summary>
        /// <para>Detection policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testPolicy</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SceneType")]
        [Validation(Required=false)]
        public int? SceneType { get; set; }

        /// <summary>
        /// <para>Sort field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtModified</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>Workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public long? WorkspaceId { get; set; }

    }

}
