// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafFilterInfoRequest : TeaModel {
        /// <summary>
        /// <para>The type of the protection policy. Separate multiple types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>waf_group: basic web protection</description></item>
        /// <item><description>custom_acl: custom protection</description></item>
        /// <item><description>whitelist: IP address whitelist</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, all types are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>custom_acl</para>
        /// </summary>
        [NameInMap("DefenseScenes")]
        [Validation(Required=false)]
        public string DefenseScenes { get; set; }

        /// <summary>
        /// <para>The language of the returned information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>en: English</description></item>
        /// <item><description>cn: Simplified Chinese</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

    }

}
