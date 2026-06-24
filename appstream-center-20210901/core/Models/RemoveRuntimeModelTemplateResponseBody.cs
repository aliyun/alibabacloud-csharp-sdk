// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class RemoveRuntimeModelTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of removal results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<RemoveRuntimeModelTemplateResponseBodyData> Data { get; set; }
        public class RemoveRuntimeModelTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The error code returned upon failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Runtime.NotFound</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The HTTP status code returned upon failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>404</para>
            /// </summary>
            [NameInMap("HttpStatusCode")]
            [Validation(Required=false)]
            public int? HttpStatusCode { get; set; }

            /// <summary>
            /// <para>The error message returned upon failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The runtime is not found.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The Agent runtime ID. The ID mapping is as follows:</para>
            /// <list type="bullet">
            /// <item><description>JVS Computer: JVS Computer ID, in the format of jvs-xxxx.</description></item>
            /// <item><description>OpenClaw: cloud computer ID, in the format of ecd-xxxx.</description></item>
            /// <item><description>Hermes Agent: Hermes Agent ID, in the format of jvs-xxxx.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>jvs-xxxxx</para>
            /// </summary>
            [NameInMap("RuntimeId")]
            [Validation(Required=false)]
            public string RuntimeId { get; set; }

            /// <summary>
            /// <para>Indicates whether the operation was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
