// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnConditionIPBInfoRequest : TeaModel {
        /// <summary>
        /// The configuration ID. Valid values:
        /// 
        /// *   condition_region_config_cn
        /// *   condition_region_config_en
        /// *   condition_isp_config_cn
        /// *   condition_isp_config_en
        /// *   condition_country_config_cn
        /// *   condition_country_config_en
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

    }

}
