// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class SwitchNetworkRequest : TeaModel {
        /// <summary>
        /// <para>The retention period of the classic network endpoint. Valid values: <b>14</b>, <b>30</b>, <b>60</b>, and <b>120</b>. Unit: days.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is available and required only when the <b>RetainClassic</b> parameter is set to <b>True</b>.</para>
        /// </description></item>
        /// <item><description><para>After you complete the switchover operation, you can also call the <a href="https://help.aliyun.com/document_detail/61010.html">ModifyInstanceNetExpireTime</a> operation to modify the retention period of the classic network endpoint.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ClassicExpiredDays")]
        [Validation(Required=false)]
        public string ClassicExpiredDays { get; set; }

        /// <summary>
        /// <para>The ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/60933.html">DescribeInstances</a> operation to query the ID of the instance.</para>
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
        /// <para>Specifies whether to retain the original classic network endpoint after you switch the instance from classic network to VPC. Default value: False. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: retains the classic network endpoint.</description></item>
        /// <item><description><b>False</b>: does not retain the classic network endpoint.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only when the network type of the instance is classic network.</para>
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
        /// <para>The network type to which you want to switch. If you want to switch to VPC network, Set the value to <b>VPC</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("TargetNetworkType")]
        [Validation(Required=false)]
        public string TargetNetworkType { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch that belongs to the VPC to which you want to switch. You can call the <a href="https://help.aliyun.com/document_detail/35739.html">DescribeVpcs</a> operation to query the VPC ID.</para>
        /// <remarks>
        /// <para>The vSwitch and the ApsaraDB for Redis instance must be deployed in the same zone.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which you want to switch. You can call the <a href="https://help.aliyun.com/document_detail/35739.html">DescribeVpcs</a> operation to query the VPC ID.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The VPC and the ApsaraDB for Redis instance must be deployed in the same region.</para>
        /// </description></item>
        /// <item><description><para>After you set this parameter, you must also set the <b>VSwitchId</b> parameter.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1nme44gek34slfc****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
