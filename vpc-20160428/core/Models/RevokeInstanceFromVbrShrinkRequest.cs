// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class RevokeInstanceFromVbrShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The VBRs for which you want to revoke permissions on the VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL</b>: Permissions on the VPC are revoked for all VBRs in the specified region. <b>VbrInstanceIds</b> can be left empty.</description></item>
        /// <item><description><b>Specify</b>: Permissions on the VPC are revoked for the specified VBRs. <b>VbrInstanceIds</b> must be assigned a value.</description></item>
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
        /// <para>The VPC ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1brjuegjc88v3u9****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the VPC is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the VBRs for which you want to revoke the permissions.</para>
        /// </summary>
        [NameInMap("VbrInstanceIds")]
        [Validation(Required=false)]
        public string VbrInstanceIdsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the VBR belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1210123456123456</para>
        /// </summary>
        [NameInMap("VbrOwnerUid")]
        [Validation(Required=false)]
        public string VbrOwnerUid { get; set; }

        /// <summary>
        /// <para>The ID of the region where the VBR is deployed.</para>
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
