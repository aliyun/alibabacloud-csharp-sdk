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
        /// <item><description><para>cn: Simplified Chinese</para>
        /// </description></item>
        /// <item><description><para>en: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The sales mode.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Instance: the instance group mode. [Default]</para>
        /// </description></item>
        /// <item><description><para>Node: the matrix mode. [Whitelist required]</para>
        /// </description></item>
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
