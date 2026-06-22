// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckSummaryRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return check item statistics information, including the number of check items published by the system and the number of check items currently owned by the user. Default value: <b>false</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Returns the statistics information.</description></item>
        /// <item><description><b>false</b>: Does not return the statistics information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsItemStatistic")]
        [Validation(Required=false)]
        public bool? IsItemStatistic { get; set; }

        /// <summary>
        /// <para>The language type for requests and responses.</para>
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
        /// <para>The ID of the member accounts in the resource directory.</para>
        /// <remarks>
        /// <para>Invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>000</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public string ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The list of task sources.</para>
        /// </summary>
        [NameInMap("TaskSources")]
        [Validation(Required=false)]
        public List<string> TaskSources { get; set; }

        /// <summary>
        /// <para>The list of cloud service providers.</para>
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<string> Vendors { get; set; }

    }

}
