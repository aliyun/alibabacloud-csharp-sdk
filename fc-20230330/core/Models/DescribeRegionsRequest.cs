// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The language in which the list of regions is returned. For more information, see RFC 7231. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Simplified Chinese.</description></item>
        /// <item><description>en-US: English.</description></item>
        /// <item><description>ja: Japanese</description></item>
        /// </list>
        /// <para>Default value: en-US</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

    }

}
