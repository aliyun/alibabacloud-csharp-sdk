// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafScenesRequest : TeaModel {
        /// <summary>
        /// <para>The types of the protection policies that you want to query. Separate multiple types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>waf_group: basic web protection</description></item>
        /// <item><description>custom_acl: custom protection</description></item>
        /// <item><description>whitelist: IP address whitelist</description></item>
        /// <item><description>ip_blacklist: IP address blacklist</description></item>
        /// <item><description>region_block: region blacklist</description></item>
        /// <item><description>bot: bot management</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not set this parameter, all types of protection policies are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>waf_group,custom_acl,whitelist</para>
        /// </summary>
        [NameInMap("DefenseScenes")]
        [Validation(Required=false)]
        public string DefenseScenes { get; set; }

    }

}
