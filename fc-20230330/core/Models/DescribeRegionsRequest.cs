// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the language of the returned region list, such as Chinese or English. For more information, see RFC 7231. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh-CN: Simplified Chinese.</para>
        /// </description></item>
        /// <item><description><para>en-US: English.</para>
        /// </description></item>
        /// <item><description><para>ja: Japanese.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: zh-CN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

    }

}
