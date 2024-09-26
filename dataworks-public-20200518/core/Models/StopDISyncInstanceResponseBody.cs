// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class StopDISyncInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The information returned for the synchronization task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public StopDISyncInstanceResponseBodyData Data { get; set; }
        public class StopDISyncInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reason why the synchronization task fails to be stopped.</para>
            /// <para>If the synchronization task is stopped, the value null is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fileId:[100] is invalid.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Indicates whether the synchronization task is stopped. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>success</description></item>
            /// <item><description>fail</description></item>
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
        /// <para>The request ID. You can locate logs and troubleshoot issues based on the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1411515937635973****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
