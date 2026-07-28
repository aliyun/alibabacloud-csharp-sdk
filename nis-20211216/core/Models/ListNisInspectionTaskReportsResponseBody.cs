// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class ListNisInspectionTaskReportsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of inspection reports.</para>
        /// </summary>
        [NameInMap("InspectionReportList")]
        [Validation(Required=false)]
        public List<ListNisInspectionTaskReportsResponseBodyInspectionReportList> InspectionReportList { get; set; }
        public class ListNisInspectionTaskReportsResponseBodyInspectionReportList : TeaModel {
            /// <summary>
            /// <para>The ID of the inspection report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nir-7c3dd178738a429abe6d</para>
            /// </summary>
            [NameInMap("InspectionReportId")]
            [Validation(Required=false)]
            public string InspectionReportId { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If this parameter is not returned, it indicates that no more results are available.</para>
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
        /// <para>0D213AF9-7B8A-51A8-B411-2D797A1A447B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
