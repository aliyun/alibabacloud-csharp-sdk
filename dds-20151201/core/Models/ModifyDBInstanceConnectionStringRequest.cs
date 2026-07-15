// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyDBInstanceConnectionStringRequest : TeaModel {
        /// <summary>
        /// <para>The current connection address—the address to modify.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-bpxxxxxxxx.mongodb.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("CurrentConnectionString")]
        [Validation(Required=false)]
        public string CurrentConnectionString { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para>If you specify the ID of a sharded cluster instance, you must also specify the <b>NodeId</b> parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bpxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("ForceModifySuffix")]
        [Validation(Required=false)]
        public bool? ForceModifySuffix { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The new connection address. It must meet these requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Start with a lowercase letter.</para>
        /// </description></item>
        /// <item><description><para>End with a lowercase letter or digit.</para>
        /// </description></item>
        /// <item><description><para>Contain only lowercase letters, digits, and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>Be 8 to 63 characters long.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Specify only the prefix of the connection address. You cannot change any part beyond the prefix.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aliyuntest111</para>
        /// </summary>
        [NameInMap("NewConnectionString")]
        [Validation(Required=false)]
        public string NewConnectionString { get; set; }

        /// <summary>
        /// <para>The new port number. Valid values are from 1000 to 65535.</para>
        /// <remarks>
        /// <para>This parameter is valid only when <b>DBInstanceId</b> specifies the ID of a cloud disk instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3310</para>
        /// </summary>
        [NameInMap("NewPort")]
        [Validation(Required=false)]
        public int? NewPort { get; set; }

        /// <summary>
        /// <para>The ID of a Mongos node in a sharded cluster instance. You can specify only one Mongos node ID per call.</para>
        /// <remarks>
        /// <para>This parameter is valid only when <b>DBInstanceId</b> specifies the ID of a sharded cluster instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>s-bpxxxxxxxx</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PortModifyOnly")]
        [Validation(Required=false)]
        public bool? PortModifyOnly { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
