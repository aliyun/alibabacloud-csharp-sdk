// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeReportExportRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the export task. Obtain this ID by following these steps:</para>
        /// <ol>
        /// <item><description>Call <a href="~~DescribeCustomizeReportList~~">DescribeCustomizeReportList</a> to obtain the ReportId.</description></item>
        /// <item><description>Pass the ReportId to <a href="~~ExportCustomizeReport~~">ExportCustomizeReport</a> to obtain the ExportId from the response.</description></item>
        /// <item><description>Pass the ExportId to this operation to query the export status.</description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ExportId")]
        [Validation(Required=false)]
        public long? ExportId { get; set; }

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
        /// <para>The Alibaba Cloud account ID of the member accounts in the resource folder.</para>
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

    }

}
