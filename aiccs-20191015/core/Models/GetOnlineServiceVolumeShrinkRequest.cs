// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetOnlineServiceVolumeShrinkRequest : TeaModel {
        /// <summary>
        /// AICCS实例ID，在智能联络中心控制台上可以看到
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 开始日期时间戳（毫秒）
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// 结束日期时间戳（毫秒）
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// 每页大小（默认为10)
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 当前页（默认为1）
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// 坐席id列表
        /// </summary>
        [NameInMap("AgentIds")]
        [Validation(Required=false)]
        public string AgentIdsShrink { get; set; }

        /// <summary>
        /// 部门id列表
        /// </summary>
        [NameInMap("DepIds")]
        [Validation(Required=false)]
        public string DepIdsShrink { get; set; }

        /// <summary>
        /// 技能组id列表
        /// </summary>
        [NameInMap("GroupIds")]
        [Validation(Required=false)]
        public string GroupIdsShrink { get; set; }

        /// <summary>
        /// 时间纬度类型
        /// </summary>
        [NameInMap("TimeLatitudeType")]
        [Validation(Required=false)]
        public string TimeLatitudeType { get; set; }

        /// <summary>
        /// 是否根据坐席分组
        /// </summary>
        [NameInMap("ExistAgentGrouping")]
        [Validation(Required=false)]
        public bool? ExistAgentGrouping { get; set; }

        /// <summary>
        /// 是否根据部门分组
        /// </summary>
        [NameInMap("ExistDepartmentGrouping")]
        [Validation(Required=false)]
        public bool? ExistDepartmentGrouping { get; set; }

        /// <summary>
        /// 是否根据技能组分组
        /// </summary>
        [NameInMap("ExistSkillGroupGrouping")]
        [Validation(Required=false)]
        public bool? ExistSkillGroupGrouping { get; set; }

    }

}
