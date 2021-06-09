// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListAclRelationsResponseBody : TeaModel {
        /// <summary>
        /// 访问控制列表
        /// </summary>
        [NameInMap("AclRelations")]
        [Validation(Required=false)]
        public List<ListAclRelationsResponseBodyAclRelations> AclRelations { get; set; }
        public class ListAclRelationsResponseBodyAclRelations : TeaModel {
            /// <summary>
            /// 访问控制策略id
            /// </summary>
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            /// <summary>
            /// 关联的监听
            /// </summary>
            [NameInMap("RelatedListeners")]
            [Validation(Required=false)]
            public List<ListAclRelationsResponseBodyAclRelationsRelatedListeners> RelatedListeners { get; set; }
            public class ListAclRelationsResponseBodyAclRelationsRelatedListeners : TeaModel {
                /// <summary>
                /// 监听ID
                /// </summary>
                [NameInMap("ListenerId")]
                [Validation(Required=false)]
                public string ListenerId { get; set; }

                /// <summary>
                /// 监听端口
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public int? ListenerPort { get; set; }

                /// <summary>
                /// 监听协议
                /// </summary>
                [NameInMap("ListenerProtocol")]
                [Validation(Required=false)]
                public string ListenerProtocol { get; set; }

                /// <summary>
                /// 实例ID
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// 关联状态
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// 请求id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
