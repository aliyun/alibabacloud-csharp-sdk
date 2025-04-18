// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class ListNisInspectionTaskReportsResponseBody : TeaModel {
        [NameInMap("InspectionReportList")]
        [Validation(Required=false)]
        public List<ListNisInspectionTaskReportsResponseBodyInspectionReportList> InspectionReportList { get; set; }
        public class ListNisInspectionTaskReportsResponseBodyInspectionReportList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>nir-7c3dd178738a429abe6d</para>
            /// </summary>
            [NameInMap("InspectionReportId")]
            [Validation(Required=false)]
            public string InspectionReportId { get; set; }

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
        /// <para>0D213AF9-7B8A-51A8-B411-2D797A1A447B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>34</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
