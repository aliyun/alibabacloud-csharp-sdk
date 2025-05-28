// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListSharedReportsRequest : TeaModel {
        /// <summary>
        /// <para>Keyword of the name of the work.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test report</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>Query the number of rows in the work list:</para>
        /// <list type="bullet">
        /// <item><description>Default value: 10.</description></item>
        /// <item><description>Maximum value: 9999</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Query the type of the work (fill in the blank to query all types). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DATAPRODUCT: BI portal</description></item>
        /// <item><description>PAGE: Dashboard</description></item>
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
        /// <para>The UserID of the user to be queried in the Quick BI.</para>
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
