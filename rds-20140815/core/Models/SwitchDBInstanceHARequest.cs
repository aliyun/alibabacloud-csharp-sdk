// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class SwitchDBInstanceHARequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The effective period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b>: The switchover is executed immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: The switchover is executed during the maintenance window.</description></item>
        /// </list>
        /// <para>Default value: <b>Immediate</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Immediate</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The switchover method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Yes</b>: A forced switchover is performed.</description></item>
        /// <item><description><b>No</b>: A non-forced switchover is performed.</description></item>
        /// </list>
        /// <para>Default value: <b>No</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>No</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public string Force { get; set; }

        /// <summary>
        /// <para>The unique ID of the secondary instance. You can call DescribeDBInstanceHAConfig to query this value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>349054</para>
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
