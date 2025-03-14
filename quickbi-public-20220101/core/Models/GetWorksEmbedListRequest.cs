// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class GetWorksEmbedListRequest : TeaModel {
        /// <summary>
        /// <para>Report name (fuzzy match)</para>
        /// 
        /// <b>Example:</b>
        /// <para>test dataset</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>Page number (defaults to 1 if empty)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>Number of items per page (defaults to 10 if empty)</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Report type</para>
        /// <list type="bullet">
        /// <item><description>page, Dashboard</description></item>
        /// <item><description>screen, Visualization Screen</description></item>
        /// <item><description>report, Workbooks</description></item>
        /// <item><description>ANALYSIS, Ad Hoc Analysis</description></item>
        /// <item><description>dashboardOfflineQuery, Downloads</description></item>
        /// <item><description>dataForm, Forms</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>page</para>
        /// </summary>
        [NameInMap("WorksType")]
        [Validation(Required=false)]
        public string WorksType { get; set; }

        /// <summary>
        /// <para>Workspace ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>919818-<em><b>-</b></em>**-wdasd</para>
        /// </summary>
        [NameInMap("WsId")]
        [Validation(Required=false)]
        public string WsId { get; set; }

    }

}
