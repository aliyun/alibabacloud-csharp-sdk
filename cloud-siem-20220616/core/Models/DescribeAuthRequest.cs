// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAuthRequest : TeaModel {
        /// <summary>
        /// <para>The region of the data management center for Threat Analysis. Select the management center region based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Select this value if your assets are located in the Chinese mainland and Hong Kong (China).</description></item>
        /// <item><description>ap-southeast-1: Select this value if your assets are located outside China.</description></item>
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
