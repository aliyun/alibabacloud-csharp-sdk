// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteDISyncTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The deletion result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteDISyncTaskResponseBodyData Data { get; set; }
        public class DeleteDISyncTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reason why the synchronization task fails to be deleted. If the synchronization task is deleted, the value null is returned for this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fileId:[100] is invalid.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Indicates whether the synchronization task is deleted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>success: The synchronization task is deleted.</description></item>
            /// <item><description>fail: The synchronization task fails to be deleted. You can troubleshoot the issue based on the failure reason.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fail</para>
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
