// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class AddTableRequest : TeaModel {
        /// <summary>
        /// <para>The connector ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connector-d51861492df64257</para>
        /// </summary>
        [NameInMap("ConnectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// <para>The column information of the table.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TableColumns")]
        [Validation(Required=false)]
        public List<AddTableRequestTableColumns> TableColumns { get; set; }
        public class AddTableRequestTableColumns : TeaModel {
            /// <summary>
            /// <para>The column description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("ColumnDesc")]
            [Validation(Required=false)]
            public string ColumnDesc { get; set; }

            /// <summary>
            /// <para>The column name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>column1</para>
            /// </summary>
            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            /// <summary>
            /// <para>The data type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

        }

        [NameInMap("TableDesc")]
        [Validation(Required=false)]
        public string TableDesc { get; set; }

        /// <summary>
        /// <para>The table name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ads_wjjr_basc_enterprise_di</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
