// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// 是否在工作空间内查询
        /// </summary>
        [NameInMap("InWorkspace")]
        [Validation(Required=false)]
        public bool? InWorkspace { get; set; }

        /// <summary>
        /// 实例名称关键字
        /// </summary>
        [NameInMap("InstanceNameContains")]
        [Validation(Required=false)]
        public string InstanceNameContains { get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [NameInMap("InstanceStatusEquals")]
        [Validation(Required=false)]
        public string InstanceStatusEquals { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// 每页返回的实例数
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// 升序降序
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// 工作空间Id
        /// </summary>
        [NameInMap("WorkspaceIdEquals")]
        [Validation(Required=false)]
        public string WorkspaceIdEquals { get; set; }

    }

}
