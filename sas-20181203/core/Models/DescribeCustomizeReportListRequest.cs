// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCustomizeReportListRequest : TeaModel {
        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>Specifies whether the report is pinned to the top. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: No.</description></item>
        /// <item><description><b>true</b>: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Pinned")]
        [Validation(Required=false)]
        public bool? Pinned { get; set; }

        /// <summary>
        /// <para>The report status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReportStatus")]
        [Validation(Required=false)]
        public int? ReportStatus { get; set; }

        /// <summary>
        /// <para>The report type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Daily report.</description></item>
        /// <item><description><b>1</b>: Weekly report.</description></item>
        /// <item><description><b>2</b>: Monthly report.</description></item>
        /// <item><description><b>3</b>: Custom period.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public int? ReportType { get; set; }

        /// <summary>
        /// <para>The security report version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1.0.0</b></description></item>
        /// <item><description><b>2.0.0</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.0</para>
        /// </summary>
        [NameInMap("ReportVersion")]
        [Validation(Required=false)]
        public string ReportVersion { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member accounts in the resource directory folder.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127608589417****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The report name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
