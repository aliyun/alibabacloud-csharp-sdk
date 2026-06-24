// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ConfigRuntimeModelTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of execution results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ConfigRuntimeModelTemplateResponseBodyData> Data { get; set; }
        public class ConfigRuntimeModelTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The error code returned if the execution fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The HTTP status code returned if the execution fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("HttpStatusCode")]
            [Validation(Required=false)]
            public int? HttpStatusCode { get; set; }

            /// <summary>
            /// <para>The error message returned if the execution fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The parameter callerUid may not be null.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The Agent runtime ID. The ID mapping is as follows:</para>
            /// <para>JVS Computer: JVS Computer ID, in the format of jvs-xxxx.</para>
            /// <para>OpenClaw: cloud computer ID, in the format of ecd-xxxx.</para>
            /// <para>Hermes Agent: Hermes Agent ID, in the format of jvs-xxxx.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jvs-xxxxxxxx</para>
            /// </summary>
            [NameInMap("RuntimeId")]
            [Validation(Required=false)]
            public string RuntimeId { get; set; }

            /// <summary>
            /// <para>Indicates whether the execution is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
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
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
