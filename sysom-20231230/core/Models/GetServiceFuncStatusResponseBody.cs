// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetServiceFuncStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <list type="bullet">
        /// <item><description><c>code == Success</c> indicates that the authorization is successful.</description></item>
        /// <item><description>Other status codes indicate that the authorization failed. Check the <c>message</c> field for the detailed fault information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetServiceFuncStatusResponseBodyData Data { get; set; }
        public class GetServiceFuncStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The configuration parameters.</para>
            /// </summary>
            [NameInMap("args")]
            [Validation(Required=false)]
            public GetServiceFuncStatusResponseBodyDataArgs Args { get; set; }
            public class GetServiceFuncStatusResponseBodyDataArgs : TeaModel {
                /// <summary>
                /// <para>The configuration process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>java</para>
                /// </summary>
                [NameInMap("add_cmd")]
                [Validation(Required=false)]
                public string AddCmd { get; set; }

                /// <summary>
                /// <para>The ONCPU tracing switch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("cpu")]
                [Validation(Required=false)]
                public string Cpu { get; set; }

                /// <summary>
                /// <para>The storage path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/tmp/sysom/java-profiler</para>
                /// </summary>
                [NameInMap("java_store_path")]
                [Validation(Required=false)]
                public string JavaStorePath { get; set; }

                /// <summary>
                /// <para>The lock tracing switch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("locks")]
                [Validation(Required=false)]
                public string Locks { get; set; }

                /// <summary>
                /// <para>The tracing cycle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("loop")]
                [Validation(Required=false)]
                public int? Loop { get; set; }

                /// <summary>
                /// <para>The memory tracing switch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("mem")]
                [Validation(Required=false)]
                public string Mem { get; set; }

                /// <summary>
                /// <para>The system profiling switch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("system_profiling")]
                [Validation(Required=false)]
                public string SystemProfiling { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty.</description></item>
        /// <item><description>Otherwise, this field contains the request error information.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
