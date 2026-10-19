// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CheckAppResourcePermissionsBatchResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码；成功为 200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>错误描述；成功时为空</para>
        /// 
        /// <b>Example:</b>
        /// <para>请求的资源不存在</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>与请求顺序一致的结果</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<CheckAppResourcePermissionsBatchResponseBodyResults> Results { get; set; }
        public class CheckAppResourcePermissionsBatchResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>是否有权限</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("allowed")]
            [Validation(Required=false)]
            public bool? Allowed { get; set; }

            /// <summary>
            /// <para>目标权限点</para>
            /// 
            /// <b>Example:</b>
            /// <para>APP/VIEW</para>
            /// </summary>
            [NameInMap("permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }

            /// <summary>
            /// <para>首段为 APP 应用键的点分资源键</para>
            /// 
            /// <b>Example:</b>
            /// <para>app.demo.resource_1</para>
            /// </summary>
            [NameInMap("resourceKey")]
            [Validation(Required=false)]
            public string ResourceKey { get; set; }

            /// <summary>
            /// <para>固定为 APP_RESOURCE</para>
            /// 
            /// <b>Example:</b>
            /// <para>APP_RESOURCE</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
