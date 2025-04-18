// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class ListNisInspectionTasksResponseBody : TeaModel {
        [NameInMap("InspectionTaskList")]
        [Validation(Required=false)]
        public List<ListNisInspectionTasksResponseBodyInspectionTaskList> InspectionTaskList { get; set; }
        public class ListNisInspectionTasksResponseBodyInspectionTaskList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-06-18 00:14:46</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("InspectionName")]
            [Validation(Required=false)]
            public string InspectionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("InspectionProject")]
            [Validation(Required=false)]
            public string InspectionProject { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ni-8svm******hzr7fh79</para>
            /// </summary>
            [NameInMap("InspectionTaskId")]
            [Validation(Required=false)]
            public string InspectionTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>nir-b4c4c9******8a25e</para>
            /// </summary>
            [NameInMap("LastUpdateReportId")]
            [Validation(Required=false)]
            public string LastUpdateReportId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hKrS+MVXkuOgztXnvdml194Cz/lMNdmr+DEh0th6dVlNEo/F148UPCh2itDku7Qj</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A7F0D6EC-E19E-58AC-AC9F-08036763960F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
