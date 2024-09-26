// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDISyncTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The information that indicates whether the data synchronization task is created.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateDISyncTaskResponseBodyData Data { get; set; }
        public class CreateDISyncTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the data synchronization task that is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000001</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            /// <summary>
            /// <para>The error message that is returned if the data synchronization task fails to be created. If the data synchronization task is successfully created, this parameter is not returned. If the data synchronization task fails to be created, an error message in the &quot;Invalid path: Workflow/xxxx/Data Integration&quot; format is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Invalid path: Business Flow/xxxx/Data Integration</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The creation status of the data synchronization task. Valid values:</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1411515937635973****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
