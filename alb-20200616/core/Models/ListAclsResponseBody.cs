// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListAclsResponseBody : TeaModel {
        /// <summary>
        /// 访问控制列表
        /// </summary>
        [NameInMap("Acls")]
        [Validation(Required=false)]
        public List<ListAclsResponseBodyAcls> Acls { get; set; }
        public class ListAclsResponseBodyAcls : TeaModel {
            /// <summary>
            /// 访问控制策略id
            /// </summary>
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            /// <summary>
            /// 访问控制策略名称
            /// </summary>
            [NameInMap("AclName")]
            [Validation(Required=false)]
            public string AclName { get; set; }

            /// <summary>
            /// 状态
            /// </summary>
            [NameInMap("AclStatus")]
            [Validation(Required=false)]
            public string AclStatus { get; set; }

            /// <summary>
            /// IP版本
            /// </summary>
            [NameInMap("AddressIPVersion")]
            [Validation(Required=false)]
            public string AddressIPVersion { get; set; }

            /// <summary>
            /// 配置管理
            /// </summary>
            [NameInMap("ConfigManagedEnabled")]
            [Validation(Required=false)]
            public bool? ConfigManagedEnabled { get; set; }

            /// <summary>
            /// 资源组ID
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

        }

        /// <summary>
        /// 本次查询返回记录数量
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 分页查询标识
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
