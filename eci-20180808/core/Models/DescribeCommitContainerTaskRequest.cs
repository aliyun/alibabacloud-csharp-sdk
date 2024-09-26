// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeCommitContainerTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the elastic container instance on which the CommitContainer task is executed.\
        /// You must enter the instance ID, the task ID, or both for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eci-2zelg8vwnlzdhf8hv****</para>
        /// </summary>
        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.\
        /// Maximum value: 50.\
        /// Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the query. Set the value to the value of NextToken that is returned from the last request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the task.</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public List<string> TaskId { get; set; }

        /// <summary>
        /// <para>The status of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Running</description></item>
        /// <item><description>Succeeded</description></item>
        /// <item><description>Failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

    }

}
