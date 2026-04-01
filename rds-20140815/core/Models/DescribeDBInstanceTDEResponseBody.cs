// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceTDEResponseBody : TeaModel {
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public DescribeDBInstanceTDEResponseBodyDatabases Databases { get; set; }
        public class DescribeDBInstanceTDEResponseBodyDatabases : TeaModel {
            [NameInMap("Database")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceTDEResponseBodyDatabasesDatabase> Database { get; set; }
            public class DescribeDBInstanceTDEResponseBodyDatabasesDatabase : TeaModel {
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                [NameInMap("TDEStatus")]
                [Validation(Required=false)]
                public string TDEStatus { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the custom key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>749c1df7-<b><b>-</b></b>-<b><b>-</b></b></para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

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
