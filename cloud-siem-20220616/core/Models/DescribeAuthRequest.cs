// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAuthRequest : TeaModel {
        /// <summary>
        /// <para>The region of the threat analysis center. Select a region based on where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Select this value if your assets are deployed in the Chinese mainland or the China (Hong Kong) region.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Select this value if your assets are deployed in regions outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
