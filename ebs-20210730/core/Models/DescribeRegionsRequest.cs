// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The language type for region and zone names. This parameter determines the value of <c>LocalName</c> in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Chinese.</description></item>
        /// <item><description>en-US: English.</description></item>
        /// <item><description>ja: Japanese.</description></item>
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
        /// <para>The region ID of the user access endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ear: asynchronous replication.</para>
        /// </description></item>
        /// <item><description><para>lens: EBS Lens.</para>
        /// </description></item>
        /// <item><description><para>dbsc: dedicated block storage cluster.</para>
        /// </description></item>
        /// </list>
        /// <para>If you do not specify a resource type, region information for all resource types is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ear</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
