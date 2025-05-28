// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryShareListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the work. The works include data portal, dashboard, spreadsheet, self-service data retrieval, ad-hoc analysis, data entry, and data screen.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6b407e50-e774-406b-9956-da2425c2****</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

    }

}
