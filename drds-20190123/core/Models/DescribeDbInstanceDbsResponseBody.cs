// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDbInstanceDbsResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates the information about the storage-layer databases.</para>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public DescribeDbInstanceDbsResponseBodyDatabases Databases { get; set; }
        public class DescribeDbInstanceDbsResponseBodyDatabases : TeaModel {
            [NameInMap("Database")]
            [Validation(Required=false)]
            public List<DescribeDbInstanceDbsResponseBodyDatabasesDatabase> Database { get; set; }
            public class DescribeDbInstanceDbsResponseBodyDatabasesDatabase : TeaModel {
                /// <summary>
                /// <para>Indicates the name of a storage-layer database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>db_test</para>
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// <para>Indicates the description of the storage-layer database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates the state of the storage-layer database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The database is being created.</description></item>
                /// <item><description><b>1</b>: The database is available.</description></item>
                /// <item><description><b>3</b>: The database is being deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E9F3D991-08DE-4B74-BE0E-06B809******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Indicates the total number of storage-layer databases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
