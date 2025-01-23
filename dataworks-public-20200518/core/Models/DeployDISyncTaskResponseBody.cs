// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeployDISyncTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the real-time synchronization node or data synchronization solution is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>success: The real-time synchronization node or data synchronization solution is deployed.</description></item>
        /// <item><description>fail: The real-time synchronization node or data synchronization solution fails to be deployed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeployDISyncTaskResponseBodyData Data { get; set; }
        public class DeployDISyncTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reason for the failure to publish a data integration synchronization task.</para>
            /// <para>If the data integration synchronization task is published successfully, the return value of this parameter is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>submit and deploy fail.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The cause of the failure to deploy the real-time synchronization node or data synchronization solution.</para>
            /// <para>If the real-time synchronization node or data synchronization solution is deployed, the value null is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1411515937635973****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can query logs and troubleshoot issues based on the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
