// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class DumpMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result of the task execution.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DumpMetaResponseBodyData Data { get; set; }
        public class DumpMetaResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The status of the metadata export task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PROCESSING: The task is being processed.</description></item>
            /// <item><description>FAIL: The task failed.</description></item>
            /// <item><description>SUCCESS: The task is completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PROCESSING</para>
            /// </summary>
            [NameInMap("DumpMetaStatus")]
            [Validation(Required=false)]
            public string DumpMetaStatus { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36C43E96-8F68-44AA-B1AF-B1F7AB94A6C1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
