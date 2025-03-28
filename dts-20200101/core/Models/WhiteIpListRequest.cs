// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class WhiteIpListRequest : TeaModel {
        /// <summary>
        /// <para>destination aliyun uid</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DestAliyunUid")]
        [Validation(Required=false)]
        public string DestAliyunUid { get; set; }

        /// <summary>
        /// <para>VPCNAT destination main VSW</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DestPrimaryVswId")]
        [Validation(Required=false)]
        public string DestPrimaryVswId { get; set; }

        /// <summary>
        /// <para>destination role name</para>
        /// 
        /// <b>Example:</b>
        /// <para>ram-for-dts-sq</para>
        /// </summary>
        [NameInMap("DestRoleName")]
        [Validation(Required=false)]
        public string DestRoleName { get; set; }

        /// <summary>
        /// <para>VPCNAT destination backup VSW</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DestSecondaryVswId")]
        [Validation(Required=false)]
        public string DestSecondaryVswId { get; set; }

        /// <summary>
        /// <para>source vpc id</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DestVpcId")]
        [Validation(Required=false)]
        public string DestVpcId { get; set; }

        /// <summary>
        /// <para>The region ID to which the target instance belongs, please refer to the supported region list for details.</para>
        /// <remarks>
        /// <remarks>
        /// <para>If the target instance is a self built database or third-party cloud database with a public IP address, you can pass in the cn Hangzhou or the region ID closest to the physical distance of the database.</para>
        /// </remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>When the DTS task is migration or synchronization, this parameter must be passed in.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DestinationRegion")]
        [Validation(Required=false)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// <para>The region ID of the change tracking instance. The region ID is the same as that of the source instance. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The ID of the region where the change tracking instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek26mat2ldb4oy</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>source aliyun uid</para>
        /// 
        /// <b>Example:</b>
        /// <para>1971721963139419</para>
        /// </summary>
        [NameInMap("SrcAliyunUid")]
        [Validation(Required=false)]
        public string SrcAliyunUid { get; set; }

        /// <summary>
        /// <para>VPCNAT source end main VSW</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcPrimaryVswId")]
        [Validation(Required=false)]
        public string SrcPrimaryVswId { get; set; }

        /// <summary>
        /// <para>source role Name</para>
        /// 
        /// <b>Example:</b>
        /// <para>ram-for-dts</para>
        /// </summary>
        [NameInMap("SrcRoleName")]
        [Validation(Required=false)]
        public string SrcRoleName { get; set; }

        /// <summary>
        /// <para>VPCNAT source backup VSW</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcSecondaryVswId")]
        [Validation(Required=false)]
        public string SrcSecondaryVswId { get; set; }

        /// <summary>
        /// <para>source vpc id</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SrcVpcId")]
        [Validation(Required=false)]
        public string SrcVpcId { get; set; }

        /// <summary>
        /// <para>The access method for self built databases or third-party cloud databases, with a value of</para>
        /// <list type="bullet">
        /// <item><description>Internet: accessed through the public network.</description></item>
        /// <item><description>VPC: Connected through dedicated line/VPN gateway/intelligent gateway.</description></item>
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
        /// <para>Whether it is a seamless integration (Zero-ETL) task, the value can be:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: No. - <b>true</b>: Yes.</description></item>
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
