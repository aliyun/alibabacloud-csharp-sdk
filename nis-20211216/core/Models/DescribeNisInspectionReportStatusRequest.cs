// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DescribeNisInspectionReportStatusRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nir-2ca527b8de114ba4afb9</para>
        /// </summary>
        [NameInMap("InspectionReportId")]
        [Validation(Required=false)]
        public string InspectionReportId { get; set; }

    }

}
