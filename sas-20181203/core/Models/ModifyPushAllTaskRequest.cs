// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyPushAllTaskRequest : TeaModel {
        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The check items to include in the security check. Separate multiple check items with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OVAL_ENTITY</b>: CVE vulnerabilities</description></item>
        /// <item><description><b>CMS</b>: Web-CMS vulnerabilities</description></item>
        /// <item><description><b>SYSVUL</b>: system vulnerabilities</description></item>
        /// <item><description><b>SCA</b>: application vulnerabilities</description></item>
        /// <item><description><b>HEALTH_CHECK</b>: baselines</description></item>
        /// <item><description><b>WEBSHELL</b>: web shells</description></item>
        /// <item><description><b>PROC_SNAPSHOT</b>: processes</description></item>
        /// <item><description><b>PORT_SNAPSHOT</b>: ports</description></item>
        /// <item><description><b>ACCOUNT_SNAPSHOT</b>: accounts</description></item>
        /// <item><description><b>SOFTWARE_SNAPSHOT</b>: software</description></item>
        /// <item><description><b>SCA_SNAPSHOT</b>: middleware, databases, and web services</description></item>
        /// <item><description><b>CROND_SNAPSHOT</b>: scheduled tasks</description></item>
        /// <item><description><b>AUTORUN_SNAPSHOT</b>: startup items</description></item>
        /// <item><description><b>LKM_SNAPSHOT</b>: kernel modules</description></item>
        /// <item><description><b>SCA_PROXY_SNAPSHOT</b>: websites.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HEALTH_CHECK,OVAL_ENTITY</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public string Tasks { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers on which you want to perform security checks. Separate multiple UUIDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inet-923b4538-0e88-409d-80ba-cb2e7487****,dc1691eb-656f-472f-b2aa-04f621f4****,70452f92-9fc1-45c5-ab35-e7bf8552****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
