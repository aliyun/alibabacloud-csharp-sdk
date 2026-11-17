// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class RevokeInstanceFromVbrRequest : TeaModel {
        /// <summary>
        /// <para>The scope of VBR instances from which the authorization of the VPC-connected instance is revoked. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ALL</b>: revokes the authorization between the VPC-connected instance and all VBR instances in the specified region. In this case, the <b>VbrInstanceIds</b> parameter can be left empty.</para>
        /// </description></item>
        /// <item><description><para><b>Specify</b>: revokes the authorization between the VPC-connected instance and the specified VBR instances. In this case, the <b>VbrInstanceIds</b> parameter is required.</para>
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
        /// <para>The VPC-connected instance ID for which you want to revoke the authorization.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1brjuegjc88v3u9****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC-connected instance for which you want to revoke the authorization. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of VBR instance IDs from which the authorization of the VPC-connected instance is revoked.</para>
        /// </summary>
        [NameInMap("VbrInstanceIds")]
        [Validation(Required=false)]
        public List<string> VbrInstanceIds { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that owns the VBR instance from which the authorization is revoked.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1210123456123456</para>
        /// </summary>
        [NameInMap("VbrOwnerUid")]
        [Validation(Required=false)]
        public string VbrOwnerUid { get; set; }

        /// <summary>
        /// <para>The region ID of the VBR instance from which the authorization of the VPC-connected instance is revoked.</para>
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
