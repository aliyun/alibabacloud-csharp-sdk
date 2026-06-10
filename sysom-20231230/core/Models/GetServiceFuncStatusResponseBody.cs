// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetServiceFuncStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code  </para>
        /// <list type="bullet">
        /// <item><description><c>code == Success</c> indicates that authorization succeeded.  </description></item>
        /// <item><description>Any other status code indicates that authorization failed. When authorization fails, view the <c>message</c> field to obtain detailed error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return Result</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetServiceFuncStatusResponseBodyData Data { get; set; }
        public class GetServiceFuncStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Configuration Parameter</para>
            /// </summary>
            [NameInMap("args")]
            [Validation(Required=false)]
            public GetServiceFuncStatusResponseBodyDataArgs Args { get; set; }
            public class GetServiceFuncStatusResponseBodyDataArgs : TeaModel {
                /// <summary>
                /// <para>Configuration process</para>
                /// 
                /// <b>Example:</b>
                /// <para>java</para>
                /// </summary>
                [NameInMap("add_cmd")]
                [Validation(Required=false)]
                public string AddCmd { get; set; }

                /// <summary>
                /// <para>ONCPU tracing Toggle</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("cpu")]
                [Validation(Required=false)]
                public string Cpu { get; set; }

                /// <summary>
                /// <para>Storage Path</para>
                /// 
                /// <b>Example:</b>
                /// <para>/tmp/sysom/java-profiler</para>
                /// </summary>
                [NameInMap("java_store_path")]
                [Validation(Required=false)]
                public string JavaStorePath { get; set; }

                /// <summary>
                /// <para>Edit Lock tracing Toggle</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("locks")]
                [Validation(Required=false)]
                public string Locks { get; set; }

                /// <summary>
                /// <para>Tracing epoch</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("loop")]
                [Validation(Required=false)]
                public int? Loop { get; set; }

                /// <summary>
                /// <para>Memory tracing Toggle</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("mem")]
                [Validation(Required=false)]
                public string Mem { get; set; }

                /// <summary>
                /// <para>System profiling Toggle</para>
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
        /// <para>error message  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty;  </description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
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
