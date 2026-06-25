// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ContainerInfo : TeaModel {
        /// <summary>
        /// <para>The reason for the current status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PodInitializing</para>
        /// </summary>
        [NameInMap("CurrentReaon")]
        [Validation(Required=false)]
        public string CurrentReaon { get; set; }

        /// <summary>
        /// <para>The current status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Waiting: waiting</description></item>
        /// <item><description>Running: running</description></item>
        /// <item><description>Terminated: terminated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Waiting</para>
        /// </summary>
        [NameInMap("CurrentStatus")]
        [Validation(Required=false)]
        public string CurrentStatus { get; set; }

        /// <summary>
        /// <para>The time when the current status occurred.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-21T06:17:57Z</para>
        /// </summary>
        [NameInMap("CurrentTimestamp")]
        [Validation(Required=false)]
        public string CurrentTimestamp { get; set; }

        /// <summary>
        /// <para>The image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-shanghai.aliyuncs.com/eas/echo_cn-shanghai:v0.0.1-20210129111320</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The reason for the previous status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Error</para>
        /// </summary>
        [NameInMap("LastReason")]
        [Validation(Required=false)]
        public string LastReason { get; set; }

        /// <summary>
        /// <para>The previous status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Waiting: waiting</description></item>
        /// <item><description>Running: running</description></item>
        /// <item><description>Terminated: terminated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Terminated</para>
        /// </summary>
        [NameInMap("LastStatus")]
        [Validation(Required=false)]
        public string LastStatus { get; set; }

        /// <summary>
        /// <para>The time when the previous status occurred.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-21T05:17:57Z</para>
        /// </summary>
        [NameInMap("LastTimestamp")]
        [Validation(Required=false)]
        public string LastTimestamp { get; set; }

        /// <summary>
        /// <para>The container name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>worker0</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>Indicates whether the health check is passed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Ready")]
        [Validation(Required=false)]
        public bool? Ready { get; set; }

        /// <summary>
        /// <para>The number of restarts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RestartCount")]
        [Validation(Required=false)]
        public int? RestartCount { get; set; }

    }

}
