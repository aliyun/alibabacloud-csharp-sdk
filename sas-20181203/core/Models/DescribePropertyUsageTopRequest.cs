// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyUsageTopRequest : TeaModel {
        /// <summary>
        /// <para>The type of the asset fingerprint. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>port</b>: port</description></item>
        /// <item><description><b>process</b>: process</description></item>
        /// <item><description><b>software</b>: software</description></item>
        /// <item><description><b>user</b>: account</description></item>
        /// <item><description><b>sca</b>: middleware</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>port</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
