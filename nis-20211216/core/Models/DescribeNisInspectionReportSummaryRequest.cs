// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DescribeNisInspectionReportSummaryRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nir-38abb318b27b49cc9a01</para>
        /// </summary>
        [NameInMap("InspectionReportId")]
        [Validation(Required=false)]
        public string InspectionReportId { get; set; }

    }

}
