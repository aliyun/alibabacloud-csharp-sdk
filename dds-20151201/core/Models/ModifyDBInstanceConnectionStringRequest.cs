// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyDBInstanceConnectionStringRequest : TeaModel {
        /// <summary>
        /// <para>The current endpoint, which is the endpoint to be modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-bpxxxxxxxx.mongodb.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("CurrentConnectionString")]
        [Validation(Required=false)]
        public string CurrentConnectionString { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
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
        /// <para>The network type of the connection string when only the port number is modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The new endpoint. The endpoint must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>It must start with a lowercase letter.</description></item>
        /// <item><description>It must end with a lowercase letter or a digit.</description></item>
        /// <item><description>It can contain only lowercase letters, digits, and hyphens (-).</description></item>
        /// <item><description>It must be 8 to 63 characters in length.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Specify only the prefix of the endpoint. The remaining part cannot be modified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aliyuntest111</para>
        /// </summary>
        [NameInMap("NewConnectionString")]
        [Validation(Required=false)]
        public string NewConnectionString { get; set; }

        /// <summary>
        /// <para>The new port. Valid values: 1000 to 65535.</para>
        /// <remarks>
        /// <para>This parameter is active only when the <b>DBInstanceId</b> parameter is set to a cloud disk instance ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3310</para>
        /// </summary>
        [NameInMap("NewPort")]
        [Validation(Required=false)]
        public int? NewPort { get; set; }

        /// <summary>
        /// <para>Instance ID of the Mongos node in the sharded cluster instance. You can specify only one Mongos node ID in each call.</para>
        /// <remarks>
        /// <para>This parameter is valid only when the <b>DBInstanceId</b> parameter is set to instance ID of a sharded cluster instance.</para>
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

        /// <summary>
        /// <para>Specifies whether to modify only port numbers. If you modify only port numbers, batch modification is supported.</para>
        /// </summary>
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
