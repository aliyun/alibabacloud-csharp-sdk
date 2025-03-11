// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRecycleBinTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data object returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeRecycleBinTablesResponseBodyData> Data { get; set; }
        public class DescribeRecycleBinTablesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the table was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-09-16 14:42:06</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The original name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BIN_T4AG3CY5WWXPKHITCHJY</para>
            /// </summary>
            [NameInMap("OriginalTableName")]
            [Validation(Required=false)]
            public string OriginalTableName { get; set; }

            /// <summary>
            /// <para>The name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5D64DE5944A1E541E0CB908A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
