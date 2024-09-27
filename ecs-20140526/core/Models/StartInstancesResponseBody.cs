// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StartInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the ECS instance, such as the status of each instance before and after the operation is called and the operation results.</para>
        /// </summary>
        [NameInMap("InstanceResponses")]
        [Validation(Required=false)]
        public StartInstancesResponseBodyInstanceResponses InstanceResponses { get; set; }
        public class StartInstancesResponseBodyInstanceResponses : TeaModel {
            [NameInMap("InstanceResponse")]
            [Validation(Required=false)]
            public List<StartInstancesResponseBodyInstanceResponsesInstanceResponse> InstanceResponse { get; set; }
            public class StartInstancesResponseBodyInstanceResponsesInstanceResponse : TeaModel {
                /// <summary>
                /// <para>The error code that is returned for the operation on the ECS instance. The value 200 indicates that the operation is successful. For more information, see the &quot;Error codes&quot; section in this topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The status of the ECS instance after the operation is called.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Starting</para>
                /// </summary>
                [NameInMap("CurrentStatus")]
                [Validation(Required=false)]
                public string CurrentStatus { get; set; }

                /// <summary>
                /// <para>The ID of the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The error message that is returned for the operation on the ECS instance. The value success indicates that the operation is successful. For more information, see the &quot;Error codes&quot; section in this topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The status of the ECS instance before the operation is called.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Stopped</para>
                /// </summary>
                [NameInMap("PreviousStatus")]
                [Validation(Required=false)]
                public string PreviousStatus { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
