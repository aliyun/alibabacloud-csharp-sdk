// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDBsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned databases.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDrdsDBsResponseBodyData Data { get; set; }
        public class DescribeDrdsDBsResponseBodyData : TeaModel {
            [NameInMap("Db")]
            [Validation(Required=false)]
            public List<DescribeDrdsDBsResponseBodyDataDb> Db { get; set; }
            public class DescribeDrdsDBsResponseBodyDataDb : TeaModel {
                /// <summary>
                /// <para>The time when the database is created. The value of this parameter is a UNIX timestamp. Unit: ms.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1563773824000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The type of the database. Valid values: <b>RDS</b> and <b>POLARDB</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RDS</para>
                /// </summary>
                [NameInMap("DbInstType")]
                [Validation(Required=false)]
                public string DbInstType { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>drds_test</para>
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// <para>The partitioning mode of the database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>HORIZONTAL</b>: The database is horizontally partitioned.</description></item>
                /// <item><description><b>VERTICAL</b>: The database is vertically partitioned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HORIZONTAL</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The schema ID that is assigned to the partitioned database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>drds_test_1563773871118kxqd</para>
                /// </summary>
                [NameInMap("Schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

                /// <summary>
                /// <para>The state of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of databases returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>006B7D19-8CDB-4AA6-AAE7-23C107GS3W2T</para>
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
        /// <para>The number of returned databases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
