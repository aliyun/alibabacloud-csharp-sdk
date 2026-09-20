// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeRestoreSchemaDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC682A80-7677-4294-975C-CFEA425381DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The schema restoration details.</para>
        /// </summary>
        [NameInMap("RestoreSchema")]
        [Validation(Required=false)]
        public DescribeRestoreSchemaDetailsResponseBodyRestoreSchema RestoreSchema { get; set; }
        public class DescribeRestoreSchemaDetailsResponseBodyRestoreSchema : TeaModel {
            /// <summary>
            /// <para>The number of failed restorations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Fail")]
            [Validation(Required=false)]
            public int? Fail { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("RestoreSchemaDetails")]
            [Validation(Required=false)]
            public DescribeRestoreSchemaDetailsResponseBodyRestoreSchemaRestoreSchemaDetails RestoreSchemaDetails { get; set; }
            public class DescribeRestoreSchemaDetailsResponseBodyRestoreSchemaRestoreSchemaDetails : TeaModel {
                [NameInMap("RestoreSchemaDetail")]
                [Validation(Required=false)]
                public List<DescribeRestoreSchemaDetailsResponseBodyRestoreSchemaRestoreSchemaDetailsRestoreSchemaDetail> RestoreSchemaDetail { get; set; }
                public class DescribeRestoreSchemaDetailsResponseBodyRestoreSchemaRestoreSchemaDetailsRestoreSchemaDetail : TeaModel {
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    [NameInMap("Table")]
                    [Validation(Required=false)]
                    public string Table { get; set; }

                }

            }

            /// <summary>
            /// <para>The number of successful restorations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Succeed")]
            [Validation(Required=false)]
            public int? Succeed { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

    }

}
