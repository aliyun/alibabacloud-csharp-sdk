// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetVulStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the asset group. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to query the IDs of asset groups.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9997897</para>
        /// </summary>
        [NameInMap("GroupIdList")]
        [Validation(Required=false)]
        public string GroupIdList { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member in the resource directory.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain the IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1232428423234****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.12.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The type of the vulnerability whose statistics you want to query. Separate multiple types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
        /// <item><description><b>emg</b>: urgent vulnerability</description></item>
        /// <item><description><b>app</b>: vulnerability detected by using a web scanner</description></item>
        /// <item><description><b>sca</b>: vulnerability detected based on software component analysis</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cve</para>
        /// </summary>
        [NameInMap("TypeList")]
        [Validation(Required=false)]
        public string TypeList { get; set; }

    }

}
