// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class DataSetBloodRequest : TeaModel {
        /// <summary>
        /// <para>List of dataset IDs, separated by English commas.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>234235234,234235235,234235235</para>
        /// </summary>
        [NameInMap("DataSetIds")]
        [Validation(Required=false)]
        public string DataSetIds { get; set; }

        /// <summary>
        /// <para>Specify the owner of the report, which is the userId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dasasgaj342351</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>Specify the type of report:</para>
        /// <list type="bullet">
        /// <item><description>REPORT: Workbooks</description></item>
        /// <item><description>dashboardOfflineQuery: Downloads</description></item>
        /// <item><description>DASHBOARD: Dashboard</description></item>
        /// <item><description>ANALYSIS: Ad Hoc Analysis</description></item>
        /// <item><description>SCREEN: Visualization Screen</description></item>
        /// <item><description>PAGE: Old dashboard</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PAGE</para>
        /// </summary>
        [NameInMap("WorksType")]
        [Validation(Required=false)]
        public string WorksType { get; set; }

    }

}
