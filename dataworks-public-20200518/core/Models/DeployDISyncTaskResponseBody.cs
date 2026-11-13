// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeployDISyncTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of publishing the synchronization task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeployDISyncTaskResponseBodyData Data { get; set; }
        public class DeployDISyncTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cause of the failure to publish the Data Integration synchronization task.</para>
            /// <para>If the Data Integration synchronization task is published, this parameter is left empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>submit and deploy fail.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The status of the result of publishing the Data Integration synchronization task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>success: The Data Integration synchronization task is published.</description></item>
            /// <item><description>fail: The Data Integration synchronization task fails to be published.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc14115159376359******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful. </description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
