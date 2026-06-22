// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeMatchedMaliciousNamesRequest : TeaModel {
        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The risk levels of the malicious samples in images to query. You can specify multiple values. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>serious</b>: urgent</description></item>
        /// <item><description><b>suspicious</b>: suspicious</description></item>
        /// <item><description><b>remind</b>: reminder.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>serious</para>
        /// </summary>
        [NameInMap("Levels")]
        [Validation(Required=false)]
        public string Levels { get; set; }

    }

}
