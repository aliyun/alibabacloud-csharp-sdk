// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DescribeNisInspectionReportStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-07-18 15:13:07</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("InspectionProject")]
        [Validation(Required=false)]
        public string InspectionProject { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>nir-2ca527b8de114ba4afb9</para>
        /// </summary>
        [NameInMap("InspectionReportId")]
        [Validation(Required=false)]
        public string InspectionReportId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ni-8svmpe0yso****r7fh79</para>
        /// </summary>
        [NameInMap("InspectionTaskId")]
        [Validation(Required=false)]
        public string InspectionTaskId { get; set; }

        [NameInMap("InspectionTaskName")]
        [Validation(Required=false)]
        public string InspectionTaskName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A7F0D6EC-E19E-58AC-AC9F-08036763960F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-07-18 15:12:28</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Finish</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
