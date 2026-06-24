// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class RestartLogstashRequest : TeaModel {
        /// <summary>
        /// <para>The concurrency for force restart. This parameter does not need to be set during a blue-green restart because force restart is not supported in that scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20%</para>
        /// </summary>
        [NameInMap("batchCount")]
        [Validation(Required=false)]
        public double? BatchCount { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a blue-green restart. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("blueGreenDep")]
        [Validation(Required=false)]
        public bool? BlueGreenDep { get; set; }

        /// <summary>
        /// <para>The type of role node to restart. This parameter is not supported.</para>
        /// </summary>
        [NameInMap("nodeTypes")]
        [Validation(Required=false)]
        public List<string> NodeTypes { get; set; }

        /// <summary>
        /// <para>The node information selected when restarting nodes.</para>
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// <para>The restart type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>instance: restart the instance</description></item>
        /// <item><description>nodeIp: restart a node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("restartType")]
        [Validation(Required=false)]
        public string RestartType { get; set; }

        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to force restart the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: force restart</description></item>
        /// <item><description>false (default): do not force restart.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
