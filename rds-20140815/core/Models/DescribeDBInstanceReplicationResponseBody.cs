// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceReplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the native replication mods is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b></description></item>
        /// <item><description><b>OFF</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("ExternalReplication")]
        [Validation(Required=false)]
        public string ExternalReplication { get; set; }

        /// <summary>
        /// <para>The replication latency. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ReplicationDelay")]
        [Validation(Required=false)]
        public string ReplicationDelay { get; set; }

        /// <summary>
        /// <para>The replication error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Got fatal error 1236 from master when reading data from binary log...</para>
        /// </summary>
        [NameInMap("ReplicationErrorMessage")]
        [Validation(Required=false)]
        public string ReplicationErrorMessage { get; set; }

        [NameInMap("ReplicationIp")]
        [Validation(Required=false)]
        public string ReplicationIp { get; set; }

        [NameInMap("ReplicationPort")]
        [Validation(Required=false)]
        public string ReplicationPort { get; set; }

        /// <summary>
        /// <para>The source of the native replication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.x.x</para>
        /// </summary>
        [NameInMap("ReplicationSource")]
        [Validation(Required=false)]
        public string ReplicationSource { get; set; }

        /// <summary>
        /// <para>The current replication status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Running</b></description></item>
        /// <item><description><b>Connecting</b></description></item>
        /// <item><description><b>Stopped</b></description></item>
        /// <item><description><b>Error</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running
        /// Connecting
        /// Stopped
        /// Error</para>
        /// </summary>
        [NameInMap("ReplicationState")]
        [Validation(Required=false)]
        public string ReplicationState { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>847BA085-B377-4BFA-8267-F82345ECE1D2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
