// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class RevokeInstanceFromVbrRequest : TeaModel {
        /// <summary>
        /// <para>The scope of VBR instances for which the VPC-connected instance authorization is being revoked. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ALL</b>: Revokes the VPC-connected instance authorization for all VBR instances in the specified region. In this case, the <b>VbrInstanceIds</b> parameter can be left empty.</para>
        /// </description></item>
        /// <item><description><para><b>Specify</b>: Revokes the VPC-connected instance authorization for the specified VBR instances. In this case, the <b>VbrInstanceIds</b> parameter is required.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("GrantType")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPC-connected instance for which you want to revoke the authorization.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1brjuegjc88v3u9****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC-connected instance for which you want to revoke the authorization.</para>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of VBR instance IDs for which the VPC-connected instance authorization is being revoked.</para>
        /// </summary>
        [NameInMap("VbrInstanceIds")]
        [Validation(Required=false)]
        public List<string> VbrInstanceIds { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the VBR instance for which the authorization is being revoked.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1210123456123456</para>
        /// </summary>
        [NameInMap("VbrOwnerUid")]
        [Validation(Required=false)]
        public string VbrOwnerUid { get; set; }

        /// <summary>
        /// <para>The region ID of the VBR instance for which the VPC-connected instance authorization is being revoked.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("VbrRegionNo")]
        [Validation(Required=false)]
        public string VbrRegionNo { get; set; }

    }

}
