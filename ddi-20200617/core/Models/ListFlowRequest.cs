// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListFlowRequest : TeaModel {
        /// <summary>
        /// 集群ID。您可以调用ListClusters查看集群的ID。
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 工作流ID。您可以调用ListFlowInstance查看工作流ID。
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// 作业ID。您可以调用ListFlowJob查看。
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// 工作流名称。您可以调用ListFlowInstance查看。
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 每页查询数量。
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 是否调度。
        /// </summary>
        [NameInMap("Periodic")]
        [Validation(Required=false)]
        public bool? Periodic { get; set; }

        /// <summary>
        /// 项目ID。您可以调用ListFlowProject查看项目的ID。
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 地域ID。您可以调用DescribeRegions查看最新的阿里云地域列表。
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 状态：  STOP_SCHEDULE（停止调度） UNDER_SCHEDULE（调度中）
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
