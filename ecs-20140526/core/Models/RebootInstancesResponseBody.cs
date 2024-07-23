// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RebootInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about instance-specific responses, which contain the status of each instance before and after the operation is called and the results of the operation.</para>
        /// </summary>
        [NameInMap("InstanceResponses")]
        [Validation(Required=false)]
        public RebootInstancesResponseBodyInstanceResponses InstanceResponses { get; set; }
        public class RebootInstancesResponseBodyInstanceResponses : TeaModel {
            [NameInMap("InstanceResponse")]
            [Validation(Required=false)]
            public List<RebootInstancesResponseBodyInstanceResponsesInstanceResponse> InstanceResponse { get; set; }
            public class RebootInstancesResponseBodyInstanceResponsesInstanceResponse : TeaModel {
                /// <summary>
                /// <para>The error code returned for the instance. A return value of 200 indicates that the operation is successful. For more information, see the &quot;Error codes&quot; section of this topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The current state of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Stopping</para>
                /// </summary>
                [NameInMap("CurrentStatus")]
                [Validation(Required=false)]
                public string CurrentStatus { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1g6zv0ce8oghu7****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The error message that is returned for the operation on the instance. The return value Success indicates that the operation is successful. For more information, see the &quot;Error codes&quot; section of this topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The state of the instance before the operation is called.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("PreviousStatus")]
                [Validation(Required=false)]
                public string PreviousStatus { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
