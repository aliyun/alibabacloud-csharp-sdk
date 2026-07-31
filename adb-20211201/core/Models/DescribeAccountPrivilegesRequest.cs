// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAccountPrivilegesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database account whose privileges you want to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>account1</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>Filters the results by column name. This parameter is used only when <c>PrivilegeType</c> is set to <c>Column</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>col1</para>
        /// </summary>
        [NameInMap("ColumnPrivilegeObject")]
        [Validation(Required=false)]
        public string ColumnPrivilegeObject { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The ID of the Enterprise Edition, Basic Edition, or Lakehouse Edition cluster.
        /// &lt;props=&quot;intl&quot;&gt;The ID of the Lakehouse Edition cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1k5p066e1a****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Filters the results by database name. This parameter is used only when <c>PrivilegeType</c> is set to <c>Database</c>, <c>Table</c>, or <c>Column</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db1</para>
        /// </summary>
        [NameInMap("DatabasePrivilegeObject")]
        [Validation(Required=false)]
        public string DatabasePrivilegeObject { get; set; }

        /// <summary>
        /// <para>The page number. Pages start at 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The privilege level to query. To obtain the valid values for this parameter, call the <c>DescribeEnabledPrivileges</c> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Global</para>
        /// </summary>
        [NameInMap("PrivilegeType")]
        [Validation(Required=false)]
        public string PrivilegeType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Filters the results by table name. You can use this parameter with <c>DatabasePrivilegeObject</c> to refine the search. This parameter is used only when <c>PrivilegeType</c> is set to <c>Table</c> or <c>Column</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table1</para>
        /// </summary>
        [NameInMap("TablePrivilegeObject")]
        [Validation(Required=false)]
        public string TablePrivilegeObject { get; set; }

    }

}
