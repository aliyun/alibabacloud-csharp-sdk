// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class ListHiveColumnLineagesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListHiveColumnLineagesResponseBodyData Data { get; set; }
        public class ListHiveColumnLineagesResponseBodyData : TeaModel {
            [NameInMap("DownstreamLineages")]
            [Validation(Required=false)]
            public List<ListHiveColumnLineagesResponseBodyDataDownstreamLineages> DownstreamLineages { get; set; }
            public class ListHiveColumnLineagesResponseBodyDataDownstreamLineages : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>C-D033DD5FB82436A6</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>balance</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-11-10 11:33:52</para>
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
                /// <para>0</para>
                /// </summary>
                [NameInMap("DirectDownColumnNumber")]
                [Validation(Required=false)]
                public int? DirectDownColumnNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DirectDownTableNumber")]
                [Validation(Required=false)]
                public int? DirectDownTableNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DirectUpperColumnNumber")]
                [Validation(Required=false)]
                public int? DirectUpperColumnNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DirectUpperTableNumber")]
                [Validation(Required=false)]
                public int? DirectUpperTableNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-11-10 11:33:52</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HIVE</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pt_table_090901_emr_child</para>
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
            public List<ListHiveColumnLineagesResponseBodyDataUpstreamLineages> UpstreamLineages { get; set; }
            public class ListHiveColumnLineagesResponseBodyDataUpstreamLineages : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>C-D033DD5FB82436A6</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>balance</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-11-10 11:33:51</para>
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
                /// <para>1</para>
                /// </summary>
                [NameInMap("DirectDownColumnNumber")]
                [Validation(Required=false)]
                public int? DirectDownColumnNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DirectDownTableNumber")]
                [Validation(Required=false)]
                public int? DirectDownTableNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DirectUpperColumnNumber")]
                [Validation(Required=false)]
                public int? DirectUpperColumnNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DirectUpperTableNumber")]
                [Validation(Required=false)]
                public int? DirectUpperTableNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-11-10 11:33:51</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HIVE</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pt_table_090901_emr_child</para>
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
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>58D5334A-B013-430E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
