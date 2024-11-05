// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyDBInstanceNetworkTypeRequest : TeaModel {
        /// <summary>
        /// <para>The retention period of the original classic network address when you change the network type to VPC. Valid values: <b>14</b>, <b>30</b>, <b>60</b>, and <b>120</b>. Unit: days.</para>
        /// <remarks>
        /// <para>This parameter is required when the <b>NetworkType</b> parameter is set to <b>VPC</b> and the <b>RetainClassic</b> parameter is set to <b>True</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ClassicExpiredDays")]
        [Validation(Required=false)]
        public int? ClassicExpiredDays { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp11483712c1****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The network type to switch to. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

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
        /// <para>Specifies whether to retain the original classic network address when you change the network type to VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: retains the original classic network address.</description></item>
        /// <item><description><b>False</b>: does not retain the original classic network address.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required when the <b>NetworkType</b> parameter is set to <b>VPC</b>.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to <b>True</b>, you must also specify the <b>ClassicExpiredDays</b> parameter.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("RetainClassic")]
        [Validation(Required=false)]
        public string RetainClassic { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the VPC.</para>
        /// <remarks>
        /// <para>This parameter is required when the <b>NetworkType</b> parameter is set to <b>VPC</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1vj604nj5a9zz74****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// <remarks>
        /// <para>This parameter is required when the <b>NetworkType</b> parameter is set to <b>VPC</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1n3i15v90el48nx****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>可用区ID，您可以通过调用<a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a>接口查询可用区ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
