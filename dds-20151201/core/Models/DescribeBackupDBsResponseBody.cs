// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeBackupDBsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the databases.</para>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public DescribeBackupDBsResponseBodyDatabases Databases { get; set; }
        public class DescribeBackupDBsResponseBodyDatabases : TeaModel {
            [NameInMap("Database")]
            [Validation(Required=false)]
            public List<DescribeBackupDBsResponseBodyDatabasesDatabase> Database { get; set; }
            public class DescribeBackupDBsResponseBodyDatabasesDatabase : TeaModel {
                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mongodbtest</para>
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the page returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AF0AD89-ED4F-44AD-B65F-BFC1D5CD9455</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of returned databases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
