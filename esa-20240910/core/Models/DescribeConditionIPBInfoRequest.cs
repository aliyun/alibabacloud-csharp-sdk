// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeConditionIPBInfoRequest : TeaModel {
        /// <summary>
        /// <para>The configuration ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>condition_region_config_cn: Provides a mapping list of Chinese region names and their corresponding codes.</description></item>
        /// <item><description>condition_region_config_en: Provides a mapping list of English region names and their corresponding codes.</description></item>
        /// <item><description>condition_isp_config_cn: Provides a mapping list of Chinese ISP names and their corresponding codes.</description></item>
        /// <item><description>condition_isp_config_en: Provides a mapping list of English ISP names and their corresponding codes.</description></item>
        /// <item><description>condition_country_config_cn: Provides a mapping list of Chinese country names and their corresponding codes.</description></item>
        /// <item><description>condition_country_config_en: Provides a mapping list of English country names and their corresponding codes.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>condition_region_config_cn</para>
        /// </summary>
        [NameInMap("DataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

    }

}
