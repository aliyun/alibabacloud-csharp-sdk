// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyAccountDescriptionRequest : TeaModel {
        /// <summary>
        /// <para>The description of the database account.</para>
        /// <list type="bullet">
        /// <item><description>The description cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The description must be 2 to 256 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AccDesc</para>
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// <para>The name of the database account.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/612430.html">DescribeAccounts</a> operation to query the information about database accounts of an AnalyticDB for MySQL cluster, including database account names.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testacc</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The database engine of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AnalyticDB</b> (default): the AnalyticDB for MySQL engine.</description></item>
        /// <item><description><b>Clickhouse</b>: the wide table engine.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Clickhouse</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

    }

}
