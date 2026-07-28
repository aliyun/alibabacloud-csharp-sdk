// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class ListAclGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the access denial. Returned only for requests denied due to insufficient RAM permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("accessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListAclGroupsResponseBodyData> Data { get; set; }
        public class ListAclGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The CIDR blocks in the group.</para>
            /// </summary>
            [NameInMap("cidrs")]
            [Validation(Required=false)]
            public List<string> Cidrs { get; set; }

            /// <summary>
            /// <para>The timestamp of the group\&quot;s creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-17T13:53:27Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>376774</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-xxx</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account. This parameter is read-only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50832118</para>
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public long? Uid { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66A13C31-473A-5B3A-8974-0B07A40649CF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
