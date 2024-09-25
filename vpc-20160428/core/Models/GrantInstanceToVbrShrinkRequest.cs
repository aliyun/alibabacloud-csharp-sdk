// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GrantInstanceToVbrShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The VBRs that need to acquire permissions on the VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b>: Permissions on the VPC are granted to all VBRs that belong to the specified region and Alibaba Cloud account. In this case, you can leave <b>VbrInstanceIds</b> empty.</description></item>
        /// <item><description><b>Specify</b>: Permissions on the VPC are granted to the specified VBRs. <b>VbrInstanceIds</b> must be assigned a value.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("GrantType")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1lqhq93q8evjpky****</para>
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
        /// <para>The information about the VBRs.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
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
        public long? VbrOwnerUid { get; set; }

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
