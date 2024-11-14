// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class GetReportRequest : TeaModel {
        /// <summary>
        /// <para>Optional, AppName only takes effect when ReportType=present.</para>
        /// 
        /// <b>Example:</b>
        /// <para>App1</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Region name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>When ReportType=history, ReportId is required to query historical reports based on ReportId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>report-74fbea80e802xxxx</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// <para>Optional values: history/present.</para>
        /// 
        /// <b>Example:</b>
        /// <para>history</para>
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

    }

}
