// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CheckTrialFixCountRequest : TeaModel {
        /// <summary>
        /// <para>The information about the vulnerability. The value of this parameter is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>name</b>: the name of the vulnerability.</para>
        /// </description></item>
        /// <item><description><para><b>uuid</b>: the UUID of the server on which the vulnerability is detected.</para>
        /// </description></item>
        /// <item><description><para><b>tag</b>: the tag that is added to the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>oval</b>: Linux software vulnerability.</description></item>
        /// <item><description><b>system</b>: Windows system vulnerability.</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> You must specify a value for Info or values for VulNames and Uuids to identify a vulnerability.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;name\&quot;:\&quot;oval:com.redhat.rhsa:def:20192143\&quot;,\&quot;uuid\&quot;:\&quot;80ee3226-1f96-4da0-a3ed-55c104e2****\&quot;,\&quot;tag\&quot;:\&quot;oval\&quot;}]</para>
        /// </summary>
        [NameInMap("Info")]
        [Validation(Required=false)]
        public string Info { get; set; }

        /// <summary>
        /// <para>The type of the vulnerability that you want to fix. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability.</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability.</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cve</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers.</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public List<string> Uuids { get; set; }

        /// <summary>
        /// <para>The names of the vulnerabilities.</para>
        /// </summary>
        [NameInMap("VulNames")]
        [Validation(Required=false)]
        public List<string> VulNames { get; set; }

    }

}
