// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The language in which you want to display the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh-CN (default): Chinese</para>
        /// </description></item>
        /// <item><description><para>en-US: English</para>
        /// </description></item>
        /// <item><description><para>ja: Japanese</para>
        /// </description></item>
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
