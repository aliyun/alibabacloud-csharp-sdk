// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyDBInstanceConnectionStringRequest : TeaModel {
        /// <summary>
        /// <para>The current endpoint that is to be modified.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>If you set this parameter to the ID of a sharded cluster instance, you must also specify the <b>NodeId</b> parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bpxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The new endpoint. It must be 8 to 64 characters in length and can contain letters and digits. It must start with a lowercase letter.</para>
        /// <remarks>
        /// <para>You need only to specify the prefix of the endpoint. The content other than the prefix cannot be modified.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyuntest111</para>
        /// </summary>
        [NameInMap("NewConnectionString")]
        [Validation(Required=false)]
        public string NewConnectionString { get; set; }

        /// <summary>
        /// <para>The new port number of the instance. The port number must be within the range from 1000 to 65535.</para>
        /// <remarks>
        /// <para> This parameter is available only when you set the <b>DBInstanceId</b> parameter to the ID of an instance that uses cloud disks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3310</para>
        /// </summary>
        [NameInMap("NewPort")]
        [Validation(Required=false)]
        public int? NewPort { get; set; }

        /// <summary>
        /// <para>The ID of the mongos in the specified sharded cluster instance. Only one mongos ID can be specified in each call.</para>
        /// <remarks>
        /// <para>This parameter is valid only when you specify the <b>DBInstanceId</b> parameter to the ID of a sharded cluster instance.</para>
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
