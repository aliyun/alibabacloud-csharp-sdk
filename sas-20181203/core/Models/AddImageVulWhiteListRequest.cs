// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddImageVulWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>The language of the content within the request and response. Default value: zh. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The reason why you add the vulnerability to the whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>already config in another way</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The source of the whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image</b></description></item>
        /// <item><description><b>agentless</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The object on which you want to perform the operation. The value of this parameter is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>type</b>: the object type. The value is fixed to repo.</description></item>
        /// <item><description><b>target</b>: the object content. The value is in the Namespace/Image repository format.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;type\&quot;:\&quot;repo\&quot;,\&quot;target\&quot;:[\&quot;sas_test/script_0209\&quot;,\&quot;sas_test/script\&quot;]}</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>The type of the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: system vulnerability</description></item>
        /// <item><description><b>sca</b>: application vulnerability</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cve</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The whitelist. The value of this parameter is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>Type</b>: the vulnerability type. Valid values: cve and sca.</description></item>
        /// <item><description><b>Name</b>: the name of the vulnerability that is specified in Common Vulnerabilities and Exposures (CVE).</description></item>
        /// <item><description><b>AliasName</b>: the alias of the vulnerability that is specified in CVE.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;Type\&quot;:\&quot;sca\&quot;,\&quot;Name\&quot;:\&quot;imgsca:java:spring-core:AVD-2022-1124599\&quot;,\&quot;AliasName\&quot;:\&quot;Spring Framework JDK &gt;= 9 (CVE-2022-22965)\&quot;}]</para>
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public string Whitelist { get; set; }

    }

}
