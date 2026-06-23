// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GrantInstanceToVbrShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The scope of VBR instances that accept the authorization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b>: Grants authorization of the VPC instance to all VBR instances in the specified region under the specified Alibaba Cloud account. In this case, the <b>VbrInstanceIds</b> parameter can be left empty.</description></item>
        /// <item><description><b>Specify</b>: Grants authorization of the VPC instance to the specified VBR instances. In this case, the <b>VbrInstanceIds</b> parameter is required.</description></item>
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
        /// <para>The ID of the VPC instance for which authorization is to be granted.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1lqhq93q8evjpky****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC instance for which authorization is to be granted.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of VBR instances to be granted authorization.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("VbrInstanceIds")]
        [Validation(Required=false)]
        public string VbrInstanceIdsShrink { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID that owns the VBR instance to be granted authorization.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1210123456123456</para>
        /// </summary>
        [NameInMap("VbrOwnerUid")]
        [Validation(Required=false)]
        public long? VbrOwnerUid { get; set; }

        /// <summary>
        /// <para>The region ID of the VBR instance to be granted authorization.</para>
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
