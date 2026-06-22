// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateCustomizeReportStatusRequest : TeaModel {
        /// <summary>
        /// <para>The pinning time. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1717430400000</para>
        /// </summary>
        [NameInMap("PinnedTime")]
        [Validation(Required=false)]
        public long? PinnedTime { get; set; }

        /// <summary>
        /// <para>The report ID.</para>
        /// <remarks>
        /// <para>Call <a href="~~DescribeCustomizeReportList~~">DescribeCustomizeReportList</a> to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

        /// <summary>
        /// <para>The report status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReportStatus")]
        [Validation(Required=false)]
        public int? ReportStatus { get; set; }

    }

}
