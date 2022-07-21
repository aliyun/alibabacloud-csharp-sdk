// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ListJobsShrinkRequest : TeaModel {
        /// <summary>
        /// 作业关联用户ID
        /// </summary>
        [NameInMap("BusinessUserId")]
        [Validation(Required=false)]
        public string BusinessUserId { get; set; }

        /// <summary>
        /// 调用方
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        /// <summary>
        /// 作业显示名称，支持模糊查询
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("FromAllWorkspaces")]
        [Validation(Required=false)]
        public bool? FromAllWorkspaces { get; set; }

        /// <summary>
        /// 作业类型
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// 排序顺序
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 每页返回的作业数
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 工作流ID
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// 资源组ID
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 是否只返回当前登录者所提交的作业
        /// </summary>
        [NameInMap("ShowOwn")]
        [Validation(Required=false)]
        public bool? ShowOwn { get; set; }

        /// <summary>
        /// 按返回字段排序
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// 作业状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 自定义标签
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// 工作空间ID
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
