// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListCrossProjectDeploymentCandidatesRequest : TeaModel {
        /// <summary>
        /// <para>The change type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADD</para>
        /// </summary>
        [NameInMap("ChangeType")]
        [Validation(Required=false)]
        public string ChangeType { get; set; }

        /// <summary>
        /// <para>The start of the commit time range. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1788739200000</para>
        /// </summary>
        [NameInMap("CommitTimeFrom")]
        [Validation(Required=false)]
        public long? CommitTimeFrom { get; set; }

        /// <summary>
        /// <para>The end of the commit time range. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1788825599999</para>
        /// </summary>
        [NameInMap("CommitTimeTo")]
        [Validation(Required=false)]
        public long? CommitTimeTo { get; set; }

        /// <summary>
        /// <para>The committer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operator</para>
        /// </summary>
        [NameInMap("CommitUser")]
        [Validation(Required=false)]
        public string CommitUser { get; set; }

        /// <summary>
        /// <para>The cross-workspace deployment environment ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("DeploymentEnvironmentId")]
        [Validation(Required=false)]
        public long? DeploymentEnvironmentId { get; set; }

        /// <summary>
        /// <para>The search keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>object</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The candidate object ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The candidate object type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ODPS_SQL</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
