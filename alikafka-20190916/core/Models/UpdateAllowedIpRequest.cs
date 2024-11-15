// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class UpdateAllowedIpRequest : TeaModel {
        /// <summary>
        /// <para>The IP addresses that you want to manage. You can specify a CIDR block. Example: <b>192.168.0.0/16</b>.</para>
        /// <list type="bullet">
        /// <item><description>If the <b>UpdateType</b> parameter is set to <b>add</b>, specify one or more IP addresses for this parameter. Separate multiple IP addresses with commas (,).</description></item>
        /// <item><description>If the <b>UpdateType</b> parameter is set to <b>delete</b>, specify only one IP address.</description></item>
        /// <item><description>Exercise caution when you delete IP addresses.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("AllowedListIp")]
        [Validation(Required=false)]
        public string AllowedListIp { get; set; }

        /// <summary>
        /// <para>The type of the whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>vpc</b>: a whitelist for access from a VPC.</description></item>
        /// <item><description><b>internet</b>: a whitelist for access from the Internet.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("AllowedListType")]
        [Validation(Required=false)]
        public string AllowedListType { get; set; }

        /// <summary>
        /// <para>The description of the whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tf-testAccEcsImageConfigBasic3549descriptionChange</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_pre-cn-0pp1cng20***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The port range. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>9092/9092</b>: Messages are transmitted in a virtual private cloud (VPC) by using the PLAINTEXT protocol.</description></item>
        /// <item><description><b>9093/9093</b>: Messages are transmitted over the Internet by using the SASL_SSL protocol.</description></item>
        /// <item><description><b>9094/9094</b>: Messages are transmitted in a VPC by using the SASL_PLAINTEXT protocol.</description></item>
        /// <item><description><b>9095/9095</b>: Messages are transmitted in a VPC by using the SASL_SSL protocol.</description></item>
        /// </list>
        /// <para>This parameter must correspond to <b>AllowdedListType</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9092/9092</para>
        /// </summary>
        [NameInMap("PortRange")]
        [Validation(Required=false)]
        public string PortRange { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The type of configuration change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>add</b></description></item>
        /// <item><description><b>delete</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>add</para>
        /// </summary>
        [NameInMap("UpdateType")]
        [Validation(Required=false)]
        public string UpdateType { get; set; }

    }

}
