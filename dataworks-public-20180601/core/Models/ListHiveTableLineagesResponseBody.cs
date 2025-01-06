// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class ListHiveTableLineagesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListHiveTableLineagesResponseBodyData Data { get; set; }
        public class ListHiveTableLineagesResponseBodyData : TeaModel {
            [NameInMap("DownstreamLineages")]
            [Validation(Required=false)]
            public List<ListHiveTableLineagesResponseBodyDataDownstreamLineages> DownstreamLineages { get; set; }
            public class ListHiveTableLineagesResponseBodyDataDownstreamLineages : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>C-D033DD5FB82436A6</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-01-09 18:16:15</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mr</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>job_1234567055_0006</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-01-09 18:16:37</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>create table parquet_example_0407 select id as one,name as two,salary as three  from PTtable_0407_emr</para>
                /// </summary>
                [NameInMap("QueryText")]
                [Validation(Required=false)]
                public string QueryText { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HIVE</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pt_table_090901_emr_orc</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DownstreamNumber")]
            [Validation(Required=false)]
            public int? DownstreamNumber { get; set; }

            [NameInMap("UpstreamLineages")]
            [Validation(Required=false)]
            public List<ListHiveTableLineagesResponseBodyDataUpstreamLineages> UpstreamLineages { get; set; }
            public class ListHiveTableLineagesResponseBodyDataUpstreamLineages : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>C-D033DD5FB82436A6</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-01-09 18:16:15</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mr</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>job_1234567055_0006</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-01-09 18:16:37</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>create table parquet_example_0407 select id as one,name as two,salary as three  from PTtable_0407_emr</para>
                /// </summary>
                [NameInMap("QueryText")]
                [Validation(Required=false)]
                public string QueryText { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HIVE</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pt_table_090901_emr_orc</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("UpstreamNumber")]
            [Validation(Required=false)]
            public int? UpstreamNumber { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>691CA452-D37A-4ED0-9441</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
