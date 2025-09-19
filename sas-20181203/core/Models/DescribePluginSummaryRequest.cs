// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePluginSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The language of the content within the request and response.**** Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default)</description></item>
        /// <item><description><b>en</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the plug-in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>alinet: AliNet.</description></item>
        /// <item><description>alisecguard: client protection.</description></item>
        /// <item><description>alihips: AliHips.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>alihips</para>
        /// </summary>
        [NameInMap("PluginName")]
        [Validation(Required=false)]
        public string PluginName { get; set; }

    }

}
