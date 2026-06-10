// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class CheckInstanceSupportResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code  </para>
        /// <list type="bullet">
        /// <item><description><c>code == Success</c> indicates that authorization succeeded.  </description></item>
        /// <item><description>Other status codes indicate that authorization failed. When authorization fails, view the <c>message</c> field to obtain detailed error information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<CheckInstanceSupportResponseBodyData> Data { get; set; }
        public class CheckInstanceSupportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>ECS instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9d00ut2ska3mlyhn6j</para>
            /// </summary>
            [NameInMap("instance")]
            [Validation(Required=false)]
            public string Instance { get; set; }

            /// <summary>
            /// <para>When <c>success</c> is false, this value is not empty and indicates the reason why the instance cannot be managed by SysOM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance not found in ecs</para>
            /// </summary>
            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance can be managed by SysOM.  </para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The instance can be managed by SysOM.  </para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The instance cannot be managed by SysOM.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("support")]
            [Validation(Required=false)]
            public bool? Support { get; set; }

        }

        /// <summary>
        /// <para>Error message. When code != Success, the error message is stored here.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPIAssumeRoleException: EntityNotExist.Role The role not exists: acs:ram::xxxxx:role/aliyunserviceroleforsysom</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
