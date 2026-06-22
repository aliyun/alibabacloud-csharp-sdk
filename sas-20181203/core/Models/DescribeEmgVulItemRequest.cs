// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeEmgVulItemRequest : TeaModel {
        /// <summary>
        /// <para>The check type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: POC verification</description></item>
        /// <item><description><b>1</b>: version comparison.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CheckType")]
        [Validation(Required=false)]
        public int? CheckType { get; set; }

        /// <summary>
        /// <para>The page number of the first page to return. Default value: <b>1</b>, which indicates that query results are displayed starting from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

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
        /// <para>The number of entries per page in a paged query. Default value: <b>10</b>, which indicates that 10 emergency vulnerability entries are displayed per page. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the member accounts in the resource directory (Alibaba Cloud account).</para>
        /// <remarks>
        /// <para>Invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127608589417****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The risk status of the vulnerabilities to query. If this parameter is not specified, vulnerabilities of all risk statuses are returned, including those with risks and those without risks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>y</b>: at risk</description></item>
        /// <item><description><b>n</b>: not at risk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>y</para>
        /// </summary>
        [NameInMap("RiskStatus")]
        [Validation(Required=false)]
        public string RiskStatus { get; set; }

        /// <summary>
        /// <para>The detection method of the vulnerabilities to query. If this parameter is not specified, vulnerabilities detected by all methods are returned by default, including version detection and network scanning. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>python</b>: version detection (server software version detection). Detects whether your server has disclosed software vulnerabilities.</description></item>
        /// <item><description><b>scan</b>: network scanning (network traffic detection). Detects whether your public assets (Internet-accessible servers) have vulnerabilities.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>python</para>
        /// </summary>
        [NameInMap("ScanType")]
        [Validation(Required=false)]
        public string ScanType { get; set; }

        /// <summary>
        /// <para>The name of the emergency vulnerability to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Changjietong T + SetupAccount/Upload.aspx file Upload vulnerability (CNVD-2022-60632)</para>
        /// </summary>
        [NameInMap("VulName")]
        [Validation(Required=false)]
        public string VulName { get; set; }

    }

}
