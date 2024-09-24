// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCrossBackupMetaListResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance to which the cross-region backup file belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>An array that consists of the information about the databases and tables whose data is included in the cross-region backup file.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeCrossBackupMetaListResponseBodyItems Items { get; set; }
        public class DescribeCrossBackupMetaListResponseBodyItems : TeaModel {
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public List<DescribeCrossBackupMetaListResponseBodyItemsMeta> Meta { get; set; }
            public class DescribeCrossBackupMetaListResponseBodyItemsMeta : TeaModel {
                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testdb1</para>
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <para>The size of the table. Unit: KB. If the database contains more than one table, the names of these tables are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

                /// <summary>
                /// <para>An array that consists of the names of the tables that the database contains. If the database contains more than one table, the names of these tables are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>test1,test2</para>
                /// </summary>
                [NameInMap("Tables")]
                [Validation(Required=false)]
                public string Tables { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60F9A12A-16B8-4728-B099-4CA38D32C31C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPageCount")]
        [Validation(Required=false)]
        public int? TotalPageCount { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
