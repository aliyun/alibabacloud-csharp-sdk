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
        /// <item><description>condition_region_config_cn: provides a mapping list of region Chinese names and their corresponding codes.</description></item>
        /// <item><description>condition_region_config_en: provides a mapping list of region English names and their corresponding codes.</description></item>
        /// <item><description>condition_isp_config_cn: provides a mapping list of ISP Chinese names and their corresponding codes.</description></item>
        /// <item><description>condition_isp_config_en: provides a mapping list of ISP English names and their corresponding codes.</description></item>
        /// <item><description>condition_country_config_cn: provides a mapping list of country Chinese names and their corresponding codes.</description></item>
        /// <item><description>condition_country_config_en: provides a mapping list of country English names and their corresponding codes.</description></item>
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
