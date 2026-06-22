// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The vulnerability announcement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RHSA-2019:3197-Important: sudo security update</para>
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>The language type for the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The vulnerability name.</para>
        /// <remarks>
        /// <para>You can call <a href="~~DescribeGroupedVul~~">DescribeGroupedVul</a> or <a href="~~DescribeVulList~~">DescribeVulList</a> to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SCA:ACSV-2020-052801</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member accounts in the resource directory folder.</para>
        /// <remarks>
        /// <para>You can invoke <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127608589417****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The type of vulnerability to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
        /// <item><description><b>app</b>: application vulnerability</description></item>
        /// <item><description><b>emg</b>: emergency vulnerability</description></item>
        /// <item><description><b>sca</b>: software constituency parsing vulnerability.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sca</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
