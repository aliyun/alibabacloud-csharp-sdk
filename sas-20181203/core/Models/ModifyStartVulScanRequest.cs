// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyStartVulScanRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You must use different tokens for different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run only. The system checks the request but does not perform the actual operation.</description></item>
        /// <item><description>false: performs the request.
        /// Default value: false.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the main account of the member accounts in the resource folder.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>Settings for the vulnerability types to be detected by the quick scan feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability.</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability.</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability.</description></item>
        /// <item><description><b>app</b>: Application vulnerabilities detected by web scanners.</description></item>
        /// <item><description><b>emg</b>: Emergency vulnerabilities.</description></item>
        /// <item><description><b>image</b>: Container image vulnerabilities.</description></item>
        /// <item><description><b>sca</b>: Application vulnerabilities detected by software constituency parsing.<remarks>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/421726.html">DescribeCloudCenterInstances</a> operation to obtain the UUIDs.</para>
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
