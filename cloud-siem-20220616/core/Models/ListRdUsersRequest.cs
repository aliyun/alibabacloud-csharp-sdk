// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListRdUsersRequest : TeaModel {
        /// <summary>
        /// <para>The region of the data management center for Threat Analysis. Select the region of the data management center based on the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Assets reside in the Chinese mainland and Hong Kong (China).</description></item>
        /// <item><description>ap-southeast-1: Assets reside in regions outside China.</description></item>
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
