// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListInstanceStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID, which can be used for end-to-end diagnosis</para>
        /// 
        /// <b>Example:</b>
        /// <para>5BC79EF5-798B-5499-9683-4E14EBBBF712</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Status code  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, authorization succeeded.  </description></item>
        /// <item><description>Other status codes indicate authorization failed. When authorization fails, check the <c>message</c> field for detailed error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListInstanceStatusResponseBodyData> Data { get; set; }
        public class ListInstanceStatusResponseBodyData : TeaModel {
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
            /// <para>Region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>Instance running status. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>Running</b>: Running  </description></item>
            /// <item><description><b>Offline</b>: Offline</description></item>
            /// </list>
            /// <remarks>
            /// <para>An instance in the Offline state indicates that the heartbeat from the edge zone to the SysOM server is lost. This does not mean that the corresponding ECS instance is not running.</para>
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
        /// <para>Error message  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty.  </description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPIAssumeRoleException: EntityNotExist.Role The role not exists: acs:ram::xxxxx:role/aliyunserviceroleforsysom</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Total number of records</para>
        /// 
        /// <b>Example:</b>
        /// <para>218</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
