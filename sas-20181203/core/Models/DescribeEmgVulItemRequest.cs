// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeEmgVulItemRequest : TeaModel {
        /// <summary>
        /// <para>The check method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: proof of concept (POC) verification</description></item>
        /// <item><description><b>1</b>: version comparison</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CheckType")]
        [Validation(Required=false)]
        public int? CheckType { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The number of entries to return on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member in the resource directory.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain the IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127608589417****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>Specifies whether the vulnerability poses risks.\
        /// If you do not specify this parameter, all vulnerabilities are queried regardless of whether the vulnerabilities pose risks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>y</b>: yes</description></item>
        /// <item><description><b>n</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>y</para>
        /// </summary>
        [NameInMap("RiskStatus")]
        [Validation(Required=false)]
        public string RiskStatus { get; set; }

        /// <summary>
        /// <para>The method that is used to detect the vulnerability.\
        /// If you do not specify this parameter, all vulnerabilities are queried regardless of which method is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>python</b>: The Version method is used. Security Center checks the software versions of your server to check whether disclosed vulnerabilities exist on your server.</description></item>
        /// <item><description><b>scan</b>: The Network Scan method is used. Security Center analyzes the access traffic to your server over the Internet to check whether vulnerabilities exist on your server.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>python</para>
        /// </summary>
        [NameInMap("ScanType")]
        [Validation(Required=false)]
        public string ScanType { get; set; }

        /// <summary>
        /// <para>The name of the urgent vulnerability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Changjietong T + SetupAccount/Upload.aspx file Upload vulnerability (CNVD-2022-60632)</para>
        /// </summary>
        [NameInMap("VulName")]
        [Validation(Required=false)]
        public string VulName { get; set; }

    }

}
