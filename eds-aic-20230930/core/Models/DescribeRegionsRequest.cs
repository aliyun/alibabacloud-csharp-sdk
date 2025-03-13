// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The display language of the console. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn: Simplified Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The sales mode.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Instance: the instance group mode. [Default]</description></item>
        /// <item><description>Node: the matrix mode. [Whitelist required]</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("SaleMode")]
        [Validation(Required=false)]
        public string SaleMode { get; set; }

    }

}
