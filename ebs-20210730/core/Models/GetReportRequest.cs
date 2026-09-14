// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class GetReportRequest : TeaModel {
        /// <summary>
        /// <para>Optional. This parameter takes effect only when ReportType is set to present.</para>
        /// 
        /// <b>Example:</b>
        /// <para>App1</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The region ID. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>When ReportType is set to history, this parameter is required. The system queries the historical report based on the specified ReportId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>report-74fbea80e802xxxx</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>history</description></item>
        /// <item><description>present</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>history</para>
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

    }

}
