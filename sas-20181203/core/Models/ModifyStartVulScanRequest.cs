// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyStartVulScanRequest : TeaModel {
        /// <summary>
        /// <para>Settings for the types of vulnerabilities to detect by using the one-click scan feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability.</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability.</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability.</description></item>
        /// <item><description><b>app</b>: Application vulnerability detected by the web scanner.</description></item>
        /// <item><description><b>emg</b>: Emergency vulnerability.</description></item>
        /// <item><description><b>image</b>: Container image vulnerability.</description></item>
        /// <item><description><b>sca</b>: Application vulnerability detected by software constituency parsing.<remarks>
        /// <para>If this parameter is left empty, all vulnerability types are detected.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;cve,sys,cms,app,emg&quot;</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public string Types { get; set; }

        /// <summary>
        /// <para>The list of server UUIDs. Separate multiple UUIDs with commas (,).</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/421726.html">DescribeCloudCenterInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1587bedb-fdb4-48c4-9330-****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
