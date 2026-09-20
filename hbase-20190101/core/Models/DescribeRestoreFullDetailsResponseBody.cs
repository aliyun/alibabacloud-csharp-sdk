// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeRestoreFullDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CFE525CF-C691-4140-A981-D004DAA7A840</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The full restoration details.</para>
        /// </summary>
        [NameInMap("RestoreFull")]
        [Validation(Required=false)]
        public DescribeRestoreFullDetailsResponseBodyRestoreFull RestoreFull { get; set; }
        public class DescribeRestoreFullDetailsResponseBodyRestoreFull : TeaModel {
            /// <summary>
            /// <para>The total data size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2 kB</para>
            /// </summary>
            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public string DataSize { get; set; }

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

            [NameInMap("RestoreFullDetails")]
            [Validation(Required=false)]
            public DescribeRestoreFullDetailsResponseBodyRestoreFullRestoreFullDetails RestoreFullDetails { get; set; }
            public class DescribeRestoreFullDetailsResponseBodyRestoreFullRestoreFullDetails : TeaModel {
                [NameInMap("RestoreFullDetail")]
                [Validation(Required=false)]
                public List<DescribeRestoreFullDetailsResponseBodyRestoreFullRestoreFullDetailsRestoreFullDetail> RestoreFullDetail { get; set; }
                public class DescribeRestoreFullDetailsResponseBodyRestoreFullRestoreFullDetailsRestoreFullDetail : TeaModel {
                    [NameInMap("DataSize")]
                    [Validation(Required=false)]
                    public string DataSize { get; set; }

                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("Process")]
                    [Validation(Required=false)]
                    public string Process { get; set; }

                    [NameInMap("Speed")]
                    [Validation(Required=false)]
                    public string Speed { get; set; }

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
            /// <para>The total restoration speed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.00 MB/s</para>
            /// </summary>
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public string Speed { get; set; }

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
