// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListFlowJobHistoryRequest : TeaModel {
        /// <summary>
        /// 作业ID。您可以调用ListFlowJob查看作业ID。
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// 作业实例ID。您可以调用DescribeFlowJob查看作业实例ID。
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 作业的类型，可能的取值有：SPARK，SPARK_STREAMING，ZEPPELIN
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// 当前页码。
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 分页查询时每页行数。
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// 状态列表。取值如下：SUBMITTED, RUNNING, SUCCESS, FAILED, KILL_FAILED, KILL_SUCCESS
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

        /// <summary>
        /// 查询的时间范围参数，参数列表：type: range，from: 开始时间（long型时间戳），to: 结束时间（long型时间戳）
        /// </summary>
        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}
