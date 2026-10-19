// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class SwitchNetworkRequest : TeaModel {
        /// <summary>
        /// <para>The retention period of the classic network connectivity endpoint. Valid values: <b>14</b>, <b>30</b>, <b>60</b>, and <b>120</b>. Unit: days.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is active and required only when <b>RetainClassic</b> is set to <b>True</b>.</description></item>
        /// <item><description>After the switchover is complete, you can invoke <a href="https://help.aliyun.com/document_detail/473793.html">ModifyInstanceNetExpireTime</a> to modify the retention period of the classic network connectivity endpoint.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ClassicExpiredDays")]
        [Validation(Required=false)]
        public string ClassicExpiredDays { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call <a href="https://help.aliyun.com/document_detail/473778.html">DescribeInstances</a> to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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

        /// <summary>
        /// <para>Specifies whether to retain the classic network connectivity endpoint when you switch the instance from the classic network to a VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: The classic network endpoint is retained.</description></item>
        /// <item><description><b>False</b>: The classic network endpoint is not retained. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is active only when the network type of the instance is classic network.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("RetainClassic")]
        [Validation(Required=false)]
        public string RetainClassic { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The network type to which you want to switch. Set the value to <b>VPC</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("TargetNetworkType")]
        [Validation(Required=false)]
        public string TargetNetworkType { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the destination VPC. You can call <a href="https://help.aliyun.com/document_detail/35739.html">DescribeVpcs</a> to query vSwitch IDs.</para>
        /// <remarks>
        /// <para>The vSwitch must be in the same zone as the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which you want to switch. You can call <a href="https://help.aliyun.com/document_detail/35739.html">DescribeVpcs</a> to query VPC IDs.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The VPC must be in the same region as the instance.</description></item>
        /// <item><description>After you specify this parameter, you must also specify the <b>VSwitchId</b> parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1nme44gek34slfc****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
