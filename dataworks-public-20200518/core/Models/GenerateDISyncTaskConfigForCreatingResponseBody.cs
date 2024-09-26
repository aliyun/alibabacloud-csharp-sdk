// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GenerateDISyncTaskConfigForCreatingResponseBody : TeaModel {
        /// <summary>
        /// <para>The information returned for the ID of the asynchronous thread.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateDISyncTaskConfigForCreatingResponseBodyData Data { get; set; }
        public class GenerateDISyncTaskConfigForCreatingResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reason why the ID of the asynchronous thread fails to be generated. If the ID is successfully generated, no value is returned for this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XXX is invalid.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The ID of the asynchronous thread. You can call the <a href="https://help.aliyun.com/document_detail/383465.html">QueryDISyncTaskConfigProcessResult</a> operation to obtain the asynchronously generated parameters based on the ID. The parameters are used to create a synchronization task in Data Integration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public long? ProcessId { get; set; }

            /// <summary>
            /// <para>Indicates whether the ID of the asynchronous thread is generated. Valid values: Valid values:</para>
            /// <list type="bullet">
            /// <item><description>success: indicates that the ID of the asynchronous thread is generated.</description></item>
            /// <item><description>fail: indicates that the ID of the asynchronous thread fails to be generated. You can view the reason for the failure and troubleshoot the issue based on the reason.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
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
