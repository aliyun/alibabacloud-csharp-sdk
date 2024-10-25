// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RunServiceScheduleResponseBody : TeaModel {
        /// <summary>
        /// <para>The execution results of the commands.</para>
        /// </summary>
        [NameInMap("CommandResults")]
        [Validation(Required=false)]
        public RunServiceScheduleResponseBodyCommandResults CommandResults { get; set; }
        public class RunServiceScheduleResponseBodyCommandResults : TeaModel {
            [NameInMap("CommandResult")]
            [Validation(Required=false)]
            public List<RunServiceScheduleResponseBodyCommandResultsCommandResult> CommandResult { get; set; }
            public class RunServiceScheduleResponseBodyCommandResultsCommandResult : TeaModel {
                /// <summary>
                /// <para>The command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ls -l /data</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <para>The name of the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>android</para>
                /// </summary>
                [NameInMap("ContainerName")]
                [Validation(Required=false)]
                public string ContainerName { get; set; }

                /// <summary>
                /// <para>The execution result of the command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("ResultMsg")]
                [Validation(Required=false)]
                public string ResultMsg { get; set; }

            }

        }

        /// <summary>
        /// <para>The index number of the scheduled virtual device (pod).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        /// <summary>
        /// <para>The ID of the scheduled instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5qvji3mom4ec013dyygmtxlkj</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IP address of the scheduled instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.246.11</para>
        /// </summary>
        [NameInMap("InstanceIp")]
        [Validation(Required=false)]
        public string InstanceIp { get; set; }

        /// <summary>
        /// <para>The start port of the scheduled instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("InstancePort")]
        [Validation(Required=false)]
        public int? InstancePort { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is repeated. This parameter is not returned if ServcieAction is set to Console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RequestRepeated")]
        [Validation(Required=false)]
        public string RequestRepeated { get; set; }

        /// <summary>
        /// <para>The TCP port range of the scheduled instance or container. The value is in the ${from}-$-{to} format. Example: 80-88.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;80-88&quot;</para>
        /// </summary>
        [NameInMap("TcpPorts")]
        [Validation(Required=false)]
        public bool? TcpPorts { get; set; }

    }

}
