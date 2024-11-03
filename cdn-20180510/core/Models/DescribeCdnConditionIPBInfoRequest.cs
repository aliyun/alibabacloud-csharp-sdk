// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnConditionIPBInfoRequest : TeaModel {
        /// <summary>
        /// <para>The configuration ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>condition_region_config_cn</description></item>
        /// <item><description>condition_region_config_en</description></item>
        /// <item><description>condition_isp_config_cn</description></item>
        /// <item><description>condition_isp_config_en</description></item>
        /// <item><description>condition_country_config_cn</description></item>
        /// <item><description>condition_country_config_en</description></item>
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
