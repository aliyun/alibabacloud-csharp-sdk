// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafFilterInfoRequest : TeaModel {
        /// <summary>
        /// The type of the protection policy. Separate multiple types with commas (,). Valid values:
        /// 
        /// *   waf_group: basic web protection
        /// *   custom_acl: custom protection
        /// *   whitelist: IP address whitelist
        /// 
        /// >If you do not specify this parameter, all types are returned.
        /// </summary>
        [NameInMap("DefenseScenes")]
        [Validation(Required=false)]
        public string DefenseScenes { get; set; }

        /// <summary>
        /// The language of the returned information. Valid values:
        /// 
        /// *   en: English
        /// *   cn: Simplified Chinese
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

    }

}
