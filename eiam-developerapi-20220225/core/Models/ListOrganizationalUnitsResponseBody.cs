// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ListOrganizationalUnitsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListOrganizationalUnitsResponseBodyData> Data { get; set; }
        public class ListOrganizationalUnitsResponseBodyData : TeaModel {
            /// <summary>
            /// 创建时间，毫秒
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 实例ID
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// 外部ID
            /// </summary>
            [NameInMap("organizationalUnitExternalId")]
            [Validation(Required=false)]
            public string OrganizationalUnitExternalId { get; set; }

            /// <summary>
            /// 机构ID
            /// </summary>
            [NameInMap("organizationalUnitId")]
            [Validation(Required=false)]
            public string OrganizationalUnitId { get; set; }

            /// <summary>
            /// 机构名称
            /// </summary>
            [NameInMap("organizationalUnitName")]
            [Validation(Required=false)]
            public string OrganizationalUnitName { get; set; }

            /// <summary>
            /// 来源ID
            /// </summary>
            [NameInMap("organizationalUnitSourceId")]
            [Validation(Required=false)]
            public string OrganizationalUnitSourceId { get; set; }

            /// <summary>
            /// 来源类型
            /// </summary>
            [NameInMap("organizationalUnitSourceType")]
            [Validation(Required=false)]
            public string OrganizationalUnitSourceType { get; set; }

            /// <summary>
            /// 父机构ID
            /// </summary>
            [NameInMap("parentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// 最近一次更新时间，毫秒
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// 记录总数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
