// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetInspectionReportRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID for the inspection. If this parameter is not specified, the entire report is returned. If this parameter is specified, only the content for the specified instance is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2zep6e5u6l2yu****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// <para>The inspection report ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9d246af2-a0cd-4f69-857d-3785048f****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
