// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class UpdateFuncSwitchRecordRequest : TeaModel {
        /// <summary>
        /// <para>The diagnostic channel. Currently, this parameter is fixed to the ECS channel.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>The diagnostic parameters. Different types of diagnostics require different diagnostic parameters. You can use this field to filter records whose parameters match the specified values.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public UpdateFuncSwitchRecordRequestParams Params { get; set; }
        public class UpdateFuncSwitchRecordRequestParams : TeaModel {
            /// <summary>
            /// <para>The configuration parameters.</para>
            /// </summary>
            [NameInMap("args")]
            [Validation(Required=false)]
            public UpdateFuncSwitchRecordRequestParamsArgs Args { get; set; }
            public class UpdateFuncSwitchRecordRequestParamsArgs : TeaModel {
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
                /// <para>The start duration, in seconds (s).</para>
                /// 
                /// <b>Example:</b>
                /// <para>3600</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

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
                /// <para>The process PID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1243</para>
                /// </summary>
                [NameInMap("pid")]
                [Validation(Required=false)]
                public int? Pid { get; set; }

                /// <summary>
                /// <para>The system tracing switch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("system_profiling")]
                [Validation(Required=false)]
                public string SystemProfiling { get; set; }

            }

            /// <summary>
            /// <para>The feature name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mullprof</para>
            /// </summary>
            [NameInMap("function_name")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2zei55fwj8nnu31h3z46</para>
            /// </summary>
            [NameInMap("instance")]
            [Validation(Required=false)]
            public string Instance { get; set; }

            /// <summary>
            /// <para>The operation type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>restart</para>
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            /// <summary>
            /// <para>The region to which the instance belongs. All instance IDs passed in instances must belong to the same region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1664516888213680</para>
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <para>The service name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>livetrace</para>
        /// </summary>
        [NameInMap("service_name")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
