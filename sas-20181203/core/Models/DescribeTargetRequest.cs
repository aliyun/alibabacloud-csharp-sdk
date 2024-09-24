// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTargetRequest : TeaModel {
        /// <summary>
        /// <para>The type of the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cms</b>: Web CMS vulnerability</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
        /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
        /// <item><description><b>emg</b>: urgent vulnerability</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;vulType&quot;:&quot;cms&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The type of the query. Set the value to vul.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vul</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
