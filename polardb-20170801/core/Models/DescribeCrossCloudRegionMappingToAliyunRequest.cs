// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeCrossCloudRegionMappingToAliyunRequest : TeaModel {
        /// <summary>
        /// <para>The region ID of Alibaba Cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("AliyunRegionId")]
        [Validation(Required=false)]
        public string AliyunRegionId { get; set; }

        /// <summary>
        /// <para>The cloud provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>HuaweiCloud</para>
        /// </description></item>
        /// <item><description><para>Azure</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HuaweiCloud</para>
        /// </summary>
        [NameInMap("CloudProvider")]
        [Validation(Required=false)]
        public string CloudProvider { get; set; }

        /// <summary>
        /// <para>The region ID of the third-party cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-east-3</para>
        /// </summary>
        [NameInMap("CrossCloudRegionId")]
        [Validation(Required=false)]
        public string CrossCloudRegionId { get; set; }

    }

}
