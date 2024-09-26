// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataSourceMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataSourceMetaResponseBodyData Data { get; set; }
        public class GetDataSourceMetaResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reason why the metadata of the data source fails to be obtained. If the metadata of the data source is obtained, no value is returned for this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>read datasource time out</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The returned metadata of the data source. The returned metadata is in the JSON format.</para>
            /// <para><c>{&quot;dbTables&quot;:[{&quot;dbName&quot;:&quot;testdb&quot;,&quot;schema&quot;:[{&quot;tableInfos&quot;:[{&quot;dbName&quot;:&quot;testdb&quot;,&quot;enable&quot;:true,&quot;table&quot;:&quot;table1&quot;,&quot;tableName&quot;:&quot;table1&quot;}]},{&quot;tableInfos&quot;:[{&quot;dbName&quot;:&quot;testdb&quot;,&quot;enable&quot;:true,&quot;table&quot;:&quot;table2&quot;,&quot;tableName&quot;:&quot;table2&quot;}]}]}]}</c></para>
            /// <para>Parameter description:</para>
            /// <list type="bullet">
            /// <item><description>dbName: the name of the database in which the data source resides.</description></item>
            /// <item><description>schema: the schema of the database.</description></item>
            /// <item><description>enable: indicates whether the database is available. The valid values are true and false. The value true indicates that the database is available. The value false indicates that the database is unavailable.</description></item>
            /// <item><description>tableName: the name of the table in the database.</description></item>
            /// <item><description>tableInfos: the information about the table in the database.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;dbTables&quot;:[{&quot;dbName&quot;:&quot;testdb&quot;,&quot;schema&quot;:[{&quot;tableInfos&quot;:[{&quot;dbName&quot;:&quot;testdb&quot;,&quot;enable&quot;:true,&quot;table&quot;:&quot;table1&quot;,&quot;tableName&quot;:&quot;table1&quot;}]},{&quot;tableInfos&quot;:[{&quot;dbName&quot;:&quot;testdb&quot;,&quot;enable&quot;:true,&quot;table&quot;:&quot;table2&quot;,&quot;tableName&quot;:&quot;table2&quot;}]}]}]}</para>
            /// </summary>
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public string Meta { get; set; }

            /// <summary>
            /// <para>Indicates whether the metadata of the data source is obtained. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>success: The metadata of the data source is obtained.</description></item>
            /// <item><description>fail: The metadata of the data source failed to be obtained. You can troubleshoot issues based on the Message parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can locate logs and troubleshoot issues based on the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
