// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The language in which the regions and zones are named. This parameter corresponds to the <c>LocalName</c> response parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Chinese</description></item>
        /// <item><description>en-US: English</description></item>
        /// <item><description>ja: Japanese</description></item>
        /// </list>
        /// <para>Default value: zh-CN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The type of resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ear: async replication</description></item>
        /// <item><description>lens: CloudLens for EBS</description></item>
        /// <item><description>dbsc: Dedicated Block Storage Cluster</description></item>
        /// </list>
        /// <para>Default value: ear.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ear</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
