// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class WhiteIpListRequest : TeaModel {
        /// <summary>
        /// <para>The UID of the destination Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DestAliyunUid")]
        [Validation(Required=false)]
        public string DestAliyunUid { get; set; }

        /// <summary>
        /// <para>The primary vSwitch of the destination for VPC NAT.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DestPrimaryVswId")]
        [Validation(Required=false)]
        public string DestPrimaryVswId { get; set; }

        /// <summary>
        /// <para>The name of the destination role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ram-for-dts-sq</para>
        /// </summary>
        [NameInMap("DestRoleName")]
        [Validation(Required=false)]
        public string DestRoleName { get; set; }

        /// <summary>
        /// <para>The secondary vSwitch of the destination for VPC NAT.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DestSecondaryVswId")]
        [Validation(Required=false)]
        public string DestSecondaryVswId { get; set; }

        /// <summary>
        /// <para>The ID of the destination VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DestVpcId")]
        [Validation(Required=false)]
        public string DestVpcId { get; set; }

        /// <summary>
        /// <para>The region ID of the destination instance. For details, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the destination instance is a self-managed database with a public IP address or a third-party ApsaraDB database, you can set this parameter to <b>ap-southeast-1</b> or the area ID that is geographically closest to the database.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when the DTS task is a data migration or data synchronization task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DestinationRegion")]
        [Validation(Required=false)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// <para>The region ID of the source instance. For details, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// <remarks>
        /// <para>If the source instance is a self-managed database with a public IP address or a third-party ApsaraDB database, you can set this parameter to <b>ap-southeast-1</b> or the area ID that is geographically closest to the database.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The region to which the DTS instance belongs. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek26mat2ldb4oy</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The UID of the source Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1971721963139419</para>
        /// </summary>
        [NameInMap("SrcAliyunUid")]
        [Validation(Required=false)]
        public string SrcAliyunUid { get; set; }

        /// <summary>
        /// <para>The primary vSwitch of the source for VPC NAT.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcPrimaryVswId")]
        [Validation(Required=false)]
        public string SrcPrimaryVswId { get; set; }

        /// <summary>
        /// <para>The name of the source role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ram-for-dts</para>
        /// </summary>
        [NameInMap("SrcRoleName")]
        [Validation(Required=false)]
        public string SrcRoleName { get; set; }

        /// <summary>
        /// <para>The secondary vSwitch of the source for VPC NAT.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcSecondaryVswId")]
        [Validation(Required=false)]
        public string SrcSecondaryVswId { get; set; }

        /// <summary>
        /// <para>The ID of the source VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcVpcId")]
        [Validation(Required=false)]
        public string SrcVpcId { get; set; }

        /// <summary>
        /// <para>The connection method of the self-managed database or third-party ApsaraDB database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>internet</b>: connected over the Internet.</description></item>
        /// <item><description><b>vpc</b>: connected over Express Connect, VPN Gateway, or Smart Access Gateway.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Specifies whether the node is a seamless integration (Zero-ETL) node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The node is a seamless integration (Zero-ETL) node.</description></item>
        /// <item><description><b>false</b>: The node is not a seamless integration (Zero-ETL) node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}
