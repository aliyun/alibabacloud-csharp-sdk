// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceNetworkTypeRequest : TeaModel {
        /// <summary>
        /// <para>The number of days for which the classic network address reservation is retained. Valid values: <b>1 to 120</b>. Unit: days. Default value: <b>7</b>.</para>
        /// <remarks>
        /// <para>This parameter is required if <b>RetainClassic</b> is set to <b>True</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("ClassicExpiredDays")]
        [Validation(Required=false)]
        public string ClassicExpiredDays { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The target network type. Set the value to <b>VPC</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Settings for the internal network IP address of the instance. The IP address must be within the address range of the specified vSwitch. By default, the system automatically allocates an IP address based on the values of <b>VPCId</b> and <b>VSwitchId</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.10.XX.XX</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The number of days for which the read/write splitting endpoint of the classic network type is retained for address reservation. Valid values: <b>1 to 120</b>. Unit: days. Default value: <b>7</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the instance has a classic network type read/write splitting endpoint and <b>RetainClassic</b> is set to <b>True</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("ReadWriteSplittingClassicExpiredDays")]
        [Validation(Required=false)]
        public int? ReadWriteSplittingClassicExpiredDays { get; set; }

        /// <summary>
        /// <para>Settings for the internal network read/write splitting IP address of the instance. The IP address must be within the address range of the specified vSwitch. By default, the system automatically allocates an IP address based on the values of <b>VPCId</b> and <b>VSwitchId</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the instance has a classic network type read/write splitting endpoint.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("ReadWriteSplittingPrivateIpAddress")]
        [Validation(Required=false)]
        public string ReadWriteSplittingPrivateIpAddress { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the classic network endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: The classic network endpoint is retained.</description></item>
        /// <item><description><b>False</b> (default): The classic network endpoint is not retained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("RetainClassic")]
        [Validation(Required=false)]
        public string RetainClassic { get; set; }

        /// <summary>
        /// <para>VPC ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6f7l4fg90****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. This parameter is required if <b>VPCId</b> is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6adz52c2p****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
