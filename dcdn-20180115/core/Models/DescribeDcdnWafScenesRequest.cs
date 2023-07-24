// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafScenesRequest : TeaModel {
        /// <summary>
        /// The types of the protection policies that you want to query. Separate multiple types with commas (,). Valid values:
        /// 
        /// *   waf_group: basic web protection
        /// *   custom_acl: custom protection
        /// *   whitelist: IP address whitelist
        /// *   ip_blacklist: IP address blacklist
        /// *   region_block: region blacklist
        /// *   bot: bot management
        /// 
        /// > If you do not set this parameter, all types of protection policies are queried.
        /// </summary>
        [NameInMap("DefenseScenes")]
        [Validation(Required=false)]
        public string DefenseScenes { get; set; }

    }

}
