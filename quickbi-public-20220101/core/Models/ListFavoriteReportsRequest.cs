// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListFavoriteReportsRequest : TeaModel {
        /// <summary>
        /// <para>Keyword of the work name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>Number of rows in the work list to be queried:
        /// Default value: 10
        /// Maximum value: 9999</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Type of the work to be queried (leave blank to query all types). Value range:</para>
        /// <list type="bullet">
        /// <item><description>DATAPRODUCT: Data Portal</description></item>
        /// <item><description>PAGE: Dashboard</description></item>
        /// <item><description>REPORT: Spreadsheet</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PAGE</para>
        /// </summary>
        [NameInMap("TreeType")]
        [Validation(Required=false)]
        public string TreeType { get; set; }

        /// <summary>
        /// <para>The UserID of the user in Quick BI to be queried.</para>
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
