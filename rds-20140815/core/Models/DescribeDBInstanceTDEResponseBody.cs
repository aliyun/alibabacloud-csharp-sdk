// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceTDEResponseBody : TeaModel {
        /// <summary>
        /// <para>The TDE status at the database level.</para>
        /// <remarks>
        /// <para> If your instance runs SQL Server 2019 SE or SQL Server EE, you can specify whether to enable TDE at the database level when you enable TDE at the instance level.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public DescribeDBInstanceTDEResponseBodyDatabases Databases { get; set; }
        public class DescribeDBInstanceTDEResponseBodyDatabases : TeaModel {
            [NameInMap("Database")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceTDEResponseBodyDatabasesDatabase> Database { get; set; }
            public class DescribeDBInstanceTDEResponseBodyDatabasesDatabase : TeaModel {
                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test02</para>
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// <para>The TDE status at the database level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Enabled</b></description></item>
                /// <item><description><b>Disabled</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("TDEStatus")]
                [Validation(Required=false)]
                public string TDEStatus { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C816A4BF-A6EC-4722-95F9-2055859CCFD2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The method that is used to generate the key for TDE at the instance level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Aliyun_Generate_Key</b></description></item>
        /// <item><description><b>Customer_Provided_Key</b></description></item>
        /// <item><description><b>Unknown</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun_Generate_Key</para>
        /// </summary>
        [NameInMap("TDEMode")]
        [Validation(Required=false)]
        public string TDEMode { get; set; }

        /// <summary>
        /// <para>The TDE status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b></description></item>
        /// <item><description><b>Disabled</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("TDEStatus")]
        [Validation(Required=false)]
        public string TDEStatus { get; set; }

    }

}
