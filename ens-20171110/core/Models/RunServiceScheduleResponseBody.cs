// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RunServiceScheduleResponseBody : TeaModel {
        [NameInMap("CommandResults")]
        [Validation(Required=false)]
        public RunServiceScheduleResponseBodyCommandResults CommandResults { get; set; }
        public class RunServiceScheduleResponseBodyCommandResults : TeaModel {
            [NameInMap("CommandResult")]
            [Validation(Required=false)]
            public List<RunServiceScheduleResponseBodyCommandResultsCommandResult> CommandResult { get; set; }
            public class RunServiceScheduleResponseBodyCommandResultsCommandResult : TeaModel {
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                [NameInMap("ContainerName")]
                [Validation(Required=false)]
                public string ContainerName { get; set; }

                [NameInMap("ResultMsg")]
                [Validation(Required=false)]
                public string ResultMsg { get; set; }

            }

        }

        /// <summary>
        /// <para>The index of the scheduled target virtual device (container pod).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        /// <summary>
        /// <para>The ID of the target instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5qvji3mom4ec013dyygmtxlkj</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IP address of the scheduled target instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.246.11</para>
        /// </summary>
        [NameInMap("InstanceIp")]
        [Validation(Required=false)]
        public string InstanceIp { get; set; }

        /// <summary>
        /// <para>The start port of the scheduled target instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("InstancePort")]
        [Validation(Required=false)]
        public int? InstancePort { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies whether the operation is repeated for ServiceAction values other than Console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RequestRepeated")]
        [Validation(Required=false)]
        public string RequestRepeated { get; set; }

        /// <summary>
        /// <para>The TCP service port range of the scheduled target virtual machine instance or container. Format: ${from}-${to}. Example: 80-88.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;80-88&quot;</para>
        /// </summary>
        [NameInMap("TcpPorts")]
        [Validation(Required=false)]
        public bool? TcpPorts { get; set; }

    }

}
