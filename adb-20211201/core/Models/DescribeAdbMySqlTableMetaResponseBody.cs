// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAdbMySqlTableMetaResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2FED790E-FB61-4721-8C1C-07C627FA5A19</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TableMeta")]
        [Validation(Required=false)]
        public DescribeAdbMySqlTableMetaResponseBodyTableMeta TableMeta { get; set; }
        public class DescribeAdbMySqlTableMetaResponseBodyTableMeta : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-03-14 02:18:08.0</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>customer_id</para>
            /// </summary>
            [NameInMap("DistributeColumn")]
            [Validation(Required=false)]
            public string DistributeColumn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hash</para>
            /// </summary>
            [NameInMap("DistributeType")]
            [Validation(Required=false)]
            public string DistributeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsAllIndex")]
            [Validation(Required=false)]
            public bool? IsAllIndex { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDictEncode")]
            [Validation(Required=false)]
            public bool? IsDictEncode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsFullTextDict")]
            [Validation(Required=false)]
            public bool? IsFullTextDict { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsHidden")]
            [Validation(Required=false)]
            public bool? IsHidden { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DATE_FORMAT(login_time, \&quot;%Y%m%d\&quot;)</para>
            /// </summary>
            [NameInMap("PartitionColumn")]
            [Validation(Required=false)]
            public string PartitionColumn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("PartitionType")]
            [Validation(Required=false)]
            public string PartitionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>login_time,customer_id,phone_num</para>
            /// </summary>
            [NameInMap("PrimaryKeyColumn")]
            [Validation(Required=false)]
            public string PrimaryKeyColumn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>XUANWU</para>
            /// </summary>
            [NameInMap("TableEngine")]
            [Validation(Required=false)]
            public string TableEngine { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>external_supplier</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tpch</para>
            /// </summary>
            [NameInMap("TableSchema")]
            [Validation(Required=false)]
            public string TableSchema { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fact_table</para>
            /// </summary>
            [NameInMap("TableType")]
            [Validation(Required=false)]
            public string TableType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-25 02:07:23.0</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
