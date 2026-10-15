// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListRecentViewReportsRequest : TeaModel {
        /// <summary>
        /// <para>The keyword in the name of the work.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FinancialReport</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The number of recent days to query data for. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("OffsetDay")]
        [Validation(Required=false)]
        public int? OffsetDay { get; set; }

        /// <summary>
        /// <para>The number of rows in the work list to query:</para>
        /// <list type="bullet">
        /// <item><description>Default value: 10.</description></item>
        /// <item><description>Maximum value: 9999.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Sorted by number of visits.</description></item>
        /// <item><description>2: Sorted by most recent visit time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("QueryMode")]
        [Validation(Required=false)]
        public string QueryMode { get; set; }

        /// <summary>
        /// <para>The type of work to query. Leave this parameter empty to query all types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DATAPRODUCT: data portal</description></item>
        /// <item><description>PAGE: dashboard</description></item>
        /// <item><description>REPORT: workbook</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PAGE</para>
        /// </summary>
        [NameInMap("TreeType")]
        [Validation(Required=false)]
        public string TreeType { get; set; }

        /// <summary>
        /// <para>The UserID of the user to query in Quick BI.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b5d8fd9348cc4327****afb604</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
