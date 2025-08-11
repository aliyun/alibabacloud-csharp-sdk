// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryReadableResourcesListByUserIdV2Request : TeaModel {
        /// <summary>
        /// <para>User ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asdas*********sdsddf</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>Work type. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>DATAPRODUCT: Data Portal</description></item>
        /// <item><description>PAGE: Dashboard</description></item>
        /// <item><description>REPORT: Spreadsheet</description></item>
        /// <item><description>dashboardOfflineQuery: Self-service Data Extraction</description></item>
        /// <item><description>SCREEN: Data Wall</description></item>
        /// <item><description>DATAFORM: Data Entry</description></item>
        /// <item><description>ANALYSIS: Ad-hoc Analysis</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DATAFORM</para>
        /// </summary>
        [NameInMap("WorkType")]
        [Validation(Required=false)]
        public string WorkType { get; set; }

        /// <summary>
        /// <para>Workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95296e95-ca89-4c7d-8af9-dedf0ad0****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
