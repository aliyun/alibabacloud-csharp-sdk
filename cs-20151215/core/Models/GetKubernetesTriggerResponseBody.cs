// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetKubernetesTriggerResponseBody : TeaModel {
        /// <summary>
        /// 触发器详情。
        /// </summary>
        [NameInMap("triggers")]
        [Validation(Required=false)]
        public List<GetKubernetesTriggerResponseBodyTriggers> Triggers { get; set; }
        public class GetKubernetesTriggerResponseBodyTriggers : TeaModel {
            /// <summary>
            /// 触发器行为。
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// 集群ID。
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// 触发器ID。
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 项目ID，格式为：${namepsce}/${应用名}，
            /// </summary>
            [NameInMap("project_id")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// 触发器Token。
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

    }

}
