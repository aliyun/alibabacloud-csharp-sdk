// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAccountPrivilegesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>account1</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The columns that you want to query. You can use this parameter to query the permissions of the database account on specific columns. This parameter is available only if the PrivilegeType parameter is set to Column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>col1</para>
        /// </summary>
        [NameInMap("ColumnPrivilegeObject")]
        [Validation(Required=false)]
        public string ColumnPrivilegeObject { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1k5p066e1a****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The databases that you want to query. You can use this parameter to query the permissions of the database account on specific databases. This parameter is available only if the PrivilegeType parameter is set to Database, Table, or Column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db1</para>
        /// </summary>
        [NameInMap("DatabasePrivilegeObject")]
        [Validation(Required=false)]
        public string DatabasePrivilegeObject { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The permission level that you want to query. You can call the <c>DescribeEnabledPrivileges</c> operation to query the permission level of the database account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Global</para>
        /// </summary>
        [NameInMap("PrivilegeType")]
        [Validation(Required=false)]
        public string PrivilegeType { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The tables that you want to query. You can use this parameter to query the permissions of the database account on specific tables. This parameter can be used together with the DatabasePrivilegeObject parameter. This parameter is available only if the PrivilegeType parameter is set to Table or Column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table1</para>
        /// </summary>
        [NameInMap("TablePrivilegeObject")]
        [Validation(Required=false)]
        public string TablePrivilegeObject { get; set; }

    }

}
