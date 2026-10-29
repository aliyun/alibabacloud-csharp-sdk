// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorResourceQuotaAttributeRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether the response includes used quotas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): Included.</description></item>
        /// <item><description>false: Not included.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ShowUsed")]
        [Validation(Required=false)]
        public bool? ShowUsed { get; set; }

    }

}
