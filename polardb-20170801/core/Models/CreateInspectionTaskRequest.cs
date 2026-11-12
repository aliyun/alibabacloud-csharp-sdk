// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateInspectionTaskRequest : TeaModel {
        /// <summary>
        /// <para>The cron expression of the inspection task, which specifies the periodic execution schedule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 0 * * *</para>
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>The list of clusters associated with the inspection task.</para>
        /// </summary>
        [NameInMap("DBClusterList")]
        [Validation(Required=false)]
        public List<CreateInspectionTaskRequestDBClusterList> DBClusterList { get; set; }
        public class CreateInspectionTaskRequestDBClusterList : TeaModel {
            /// <summary>
            /// <para>The ID of the PolarDB cluster to be inspected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-test123456</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The region ID of the cluster to be inspected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The region ID of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-123</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the inspection space. This parameter is required. If it is not provided, the API returns InvalidSpaceId.Malformed (HTTP 400).</para>
        /// 
        /// <b>Example:</b>
        /// <para>space-123</para>
        /// </summary>
        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        /// <summary>
        /// <para>The description of the inspection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Periodic inspection task</para>
        /// </summary>
        [NameInMap("TaskDescription")]
        [Validation(Required=false)]
        public string TaskDescription { get; set; }

    }

}
