// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ValidateShrinkNodesRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<ValidateShrinkNodesRequestBody> Body { get; set; }
        public class ValidateShrinkNodesRequestBody : TeaModel {
            /// <summary>
            /// <para>The IP address of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.xx.xx</para>
            /// </summary>
            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>The node name of the cloud-native ACK-based cluster. You can call the <a href="https://help.aliyun.com/document_detail/183958.html">ListAllNode</a> operation to obtain the node name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-pl32xxxxxxx-data-f-1</para>
            /// </summary>
            [NameInMap("hostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The node type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>WORKER: hot node</description></item>
            /// <item><description>WORKER_WARM: warm node</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WORKER</para>
            /// </summary>
            [NameInMap("nodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The access port number of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9200</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The zone ID of the node in the instance. For example, the zone ID of China (Shanghai) Zone C is cn-shanghai-c.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-c</para>
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The number of nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>Specifies whether to ignore the cluster health status.</para>
        /// <list type="bullet">
        /// <item><description>true: ignores the cluster health status.</description></item>
        /// <item><description>false (default): does not ignore the cluster health status.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ignoreStatus")]
        [Validation(Required=false)]
        public bool? IgnoreStatus { get; set; }

        /// <summary>
        /// <para>The type of nodes to scale in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>WORKER: hot node</description></item>
        /// <item><description>WORKER_WARM: warm node</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WORKER</para>
        /// </summary>
        [NameInMap("nodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

    }

}
