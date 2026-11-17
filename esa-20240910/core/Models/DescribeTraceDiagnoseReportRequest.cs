// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeTraceDiagnoseReportRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the diagnostic task. You must specify at least one of TraceId and TaskId. If both are missing, the API returns an error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxxxxx-x-x-xxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The ID of the diagnostic trace. You must specify at least one of TraceId and TaskId. If both are missing, the API returns an error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000xxxxxxxxxxxxxxxxxxxxxx75e</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
