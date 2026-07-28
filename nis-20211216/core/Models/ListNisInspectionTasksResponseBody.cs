// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class ListNisInspectionTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of network inspection tasks.</para>
        /// </summary>
        [NameInMap("InspectionTaskList")]
        [Validation(Required=false)]
        public List<ListNisInspectionTasksResponseBodyInspectionTaskList> InspectionTaskList { get; set; }
        public class ListNisInspectionTasksResponseBodyInspectionTaskList : TeaModel {
            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-18 00:14:46</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The name of the network inspection task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NIS inspection</para>
            /// </summary>
            [NameInMap("InspectionName")]
            [Validation(Required=false)]
            public string InspectionName { get; set; }

            /// <summary>
            /// <para>The type of inspection solution that the network inspection task uses. Valid values: basic and customized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("InspectionProject")]
            [Validation(Required=false)]
            public string InspectionProject { get; set; }

            /// <summary>
            /// <para>The ID of the network inspection task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ni-8svm******hzr7fh79</para>
            /// </summary>
            [NameInMap("InspectionTaskId")]
            [Validation(Required=false)]
            public string InspectionTaskId { get; set; }

            /// <summary>
            /// <para>The ID of the latest report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nir-b4c4c9******8a25e</para>
            /// </summary>
            [NameInMap("LastUpdateReportId")]
            [Validation(Required=false)]
            public string LastUpdateReportId { get; set; }

            /// <summary>
            /// <para>The running status of the task. Valid values:</para>
            /// <para>Creating: The task is being created.</para>
            /// <list type="bullet">
            /// <item><description><para>Active</para>
            /// </description></item>
            /// <item><description><para>Running</para>
            /// </description></item>
            /// <item><description><para>Inactive</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. If the value of this parameter is not empty, it indicates that there are more results to retrieve. If this parameter is empty, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hKrS+MVXkuOgztXnvdml194Cz/lMNdmr+DEh0th6dVlNEo/F148UPCh2itDku7Qj</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7F0D6EC-E19E-58AC-AC9F-08036763960F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
