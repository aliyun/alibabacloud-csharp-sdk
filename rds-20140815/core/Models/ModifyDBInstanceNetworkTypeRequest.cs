// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceNetworkTypeRequest : TeaModel {
        /// <summary>
        /// <para>The number of days for which you want to retain the classic network endpoint. Valid values: <b>1 to 120</b>. Default value: <b>7</b>.</para>
        /// <remarks>
        /// <para>If you set the <b>RetainClassic</b> parameter to <b>True</b>, you must also specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("ClassicExpiredDays")]
        [Validation(Required=false)]
        public string ClassicExpiredDays { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The network type after the modification. Set the value to <b>VPC</b>.</para>
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
        /// <para>The internal IP address of the instance. The internal IP address must be within the CIDR block supported by the specified vSwitch. The system automatically assigns a private IP address to an instance based on the values of <b>VPCId</b> and <b>VSwitchId</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.10.40.25</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The number of days for which you want to retain the read/write splitting endpoint of the classic network type. Valid values: <b>1 to 120</b>. Default value: <b>7</b>.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when a read/write splitting endpoint of the classic network type exists and the <b>RetainClassic</b> parameter is set to <b>True</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("ReadWriteSplittingClassicExpiredDays")]
        [Validation(Required=false)]
        public int? ReadWriteSplittingClassicExpiredDays { get; set; }

        /// <summary>
        /// <para>The internal IP address that corresponds to the read/write splitting endpoint of the instance. The internal IP address must be within the CIDR block supported by the specified vSwitch. The system automatically assigns a private IP address to an instance based on the values of <b>VPCId</b> and <b>VSwitchId</b>.</para>
        /// <remarks>
        /// <para> This parameter is valid when a read/write splitting endpoint of the classic network type exists.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.22</para>
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
        /// <item><description><b>True</b>: retains the classic network endpoint.</description></item>
        /// <item><description><b>False</b> (default): does not retain the classic network endpoint.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("RetainClassic")]
        [Validation(Required=false)]
        public string RetainClassic { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6f7l4fg90xxxxxx</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch. This parameter is required if the <b>VPCId</b> parameter is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6adz52c2pxxxxx</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
