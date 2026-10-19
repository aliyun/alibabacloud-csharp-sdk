// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeParametersRequest : TeaModel {
        /// <summary>
        /// <para>The role type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>db: shard role</description></item>
        /// <item><description>cs: config server role</description></item>
        /// <item><description>mongos: mongos role</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mongos</para>
        /// </summary>
        [NameInMap("CharacterType")]
        [Validation(Required=false)]
        public string CharacterType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>If you specify the ID of a sharded cluster instance for this parameter, you must also specify the <b>NodeId</b> parameter.</para>
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
        /// <para>The extended parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>terrform</para>
        /// </summary>
        [NameInMap("ExtraParam")]
        [Validation(Required=false)]
        public string ExtraParam { get; set; }

        /// <summary>
        /// <para>Instance ID of the mongos or shard node in the sharded cluster instance.</para>
        /// <remarks>
        /// <para>This parameter is available only when the <b>DBInstanceId</b> parameter is set to instance ID of a sharded cluster instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d-bpxxxxxxxx</para>
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
