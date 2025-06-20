// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The natural language that is used to filter responses. For more information, see RFC 7231.</para>
        /// <para>zh-CN en-US Default value: zh-CN.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>en-US</description></item>
        /// <item><description>zh-CN</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

    }

}
