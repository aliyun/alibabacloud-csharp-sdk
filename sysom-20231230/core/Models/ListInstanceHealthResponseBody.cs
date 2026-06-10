// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListInstanceHealthResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code.  </para>
        /// <list type="bullet">
        /// <item><description><c>code == Success</c> indicates that authorization succeeded.  </description></item>
        /// <item><description>Other status codes indicate that authorization failed. When authorization fails, check the <c>message</c> field for detailed error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPI.ServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListInstanceHealthResponseBodyData> Data { get; set; }
        public class ListInstanceHealthResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of container image names in the pod.</para>
            /// </summary>
            [NameInMap("images")]
            [Validation(Required=false)]
            public List<string> Images { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9d00ut2ska3mlyhn6j</para>
            /// </summary>
            [NameInMap("instance")]
            [Validation(Required=false)]
            public string Instance { get; set; }

            /// <summary>
            /// <para>Namespace where the pod resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>Pod name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-pod</para>
            /// </summary>
            [NameInMap("pod")]
            [Validation(Required=false)]
            public string Pod { get; set; }

            /// <summary>
            /// <para>Region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("region_id")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Health score value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("score")]
            [Validation(Required=false)]
            public float? Score { get; set; }

            /// <summary>
            /// <para>Running status of the instance. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>Running</b>: The instance is running.  </description></item>
            /// <item><description><b>Offline</b>: The instance is offline.</description></item>
            /// </list>
            /// <remarks>
            /// <para>An instance in the Offline state indicates that the heartbeat from the edge zone to the SysOM server has been lost. This does not mean that the corresponding ECS instance is not running.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>error message  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty;  </description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Query no data</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>35F91AAB-5FDF-5A22-B211-C7C6B00817D0</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
