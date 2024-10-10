// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryShareListRequest : TeaModel {
        /// <summary>
        /// <para>The type of work being shared. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>product: BI portal</description></item>
        /// <item><description>dashboard: dashboard</description></item>
        /// <item><description>worksheet: workbook</description></item>
        /// <item><description>dashboardOfflineQuery: self-service data retrieval</description></item>
        /// <item><description>Analysis: Ad hoc analysis</description></item>
        /// <item><description>DATAFORM</description></item>
        /// <item><description>SCREEN: Data dashboard</description></item>
        /// </list>
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
