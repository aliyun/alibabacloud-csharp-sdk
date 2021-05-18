// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetSeatInformationShrinkRequest : TeaModel {
        /// <summary>
        /// AICCS实例ID，在智能联络中心控制台上可以看到
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 开始日期时间戳（毫秒）
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// 结束日期时间戳（毫秒）
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// 每页大小（默认为10)
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 当前页（默认为1）
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// 部门id列表
        /// </summary>
        [NameInMap("depIds")]
        [Validation(Required=false)]
        public string DepIdsShrink { get; set; }

        /// <summary>
        /// 是否根据部门分组
        /// </summary>
        [NameInMap("existDepartmentGrouping")]
        [Validation(Required=false)]
        public bool? ExistDepartmentGrouping { get; set; }

    }

}
