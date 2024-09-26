// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QueryDISyncTaskConfigProcessResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The information returned for the parameters that are asynchronously generated and used to create or update a real-time synchronization task in Data Integration.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDISyncTaskConfigProcessResultResponseBodyData Data { get; set; }
        public class QueryDISyncTaskConfigProcessResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reason why the parameters fail to be obtained. If the parameters are obtained, the value null is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fileId:[100] is invalid.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Indicates whether the parameters are obtained. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>success: The parameters are obtained.</description></item>
            /// <item><description>fail: The parameters fail to be obtained. You can view the reason for the failure and troubleshoot the issue based on the reason.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The parameters that are obtained. The parameters are used as the request parameters of the <a href="https://help.aliyun.com/document_detail/278725.html">CreateDISyncTask</a> or <a href="https://help.aliyun.com/document_detail/289109.html">UpdateDISyncTask</a> operation to create or update a real-time synchronization task in Data Integration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;extend&quot;:{&quot;mode&quot;:&quot;migration_holo&quot;,&quot;resourceGroup&quot;:&quot;280749&quot;,&quot;name&quot;:&quot;h&quot;},&quot;type&quot;:&quot;job&quot;,&quot;steps&quot;:[{&quot;stepType&quot;:&quot;mysql&quot;,&quot;parameter&quot;:{&quot;connection&quot;:[{&quot;datasourceType&quot;:&quot;mysql&quot;,&quot;datasource&quot;:&quot;mm&quot;,&quot;selectedTables&quot;:[{&quot;schema&quot;:[{&quot;tableInfos&quot;:[{&quot;enable&quot;:true,&quot;table&quot;:&quot;m_v1&quot;,&quot;tableName&quot;:&quot;m_v1&quot;}]}],&quot;dbName&quot;:&quot;m&quot;}]}]},&quot;name&quot;:&quot;reader&quot;,&quot;category&quot;:&quot;reader&quot;},{&quot;stepType&quot;:&quot;holo&quot;,&quot;parameter&quot;:{&quot;datasource&quot;:&quot;h&quot;,&quot;tableMappingRule&quot;:{&quot;datasource&quot;:[{&quot;tableRule&quot;:[{&quot;srcTable&quot;:&quot;m_v1&quot;,&quot;mergeIntoCycleType&quot;:&quot;DEFAULT&quot;,&quot;hourDeltaEnable&quot;:false,&quot;dstTable&quot;:&quot;m.m_v1&quot;,&quot;dayDeltaEnable&quot;:false,&quot;primaryKeyInfo&quot;:{&quot;column&quot;:[&quot;id&quot;],&quot;type&quot;:&quot;pk&quot;},&quot;dstCreateTableInfo&quot;:{&quot;indexType&quot;:&quot;m_v1&quot;,&quot;dataColumn&quot;:[{&quot;columnSize&quot;:0,&quot;name&quot;:&quot;id&quot;,&quot;index&quot;:0,&quot;comment&quot;:&quot;&quot;,&quot;newDigit&quot;:0,&quot;type&quot;:&quot;int8&quot;,&quot;digit&quot;:0,&quot;primaryKey&quot;:true}],&quot;schemaName&quot;:&quot;m&quot;,&quot;tableName&quot;:&quot;m_v1&quot;},&quot;srcDbName&quot;:&quot;m&quot;],&quot;srcDatasourceName&quot;:&quot;mm&quot;}],&quot;totalTableMapping&quot;:1},&quot;writeMode&quot;:&quot;replay&quot;},&quot;name&quot;:&quot;writer&quot;,&quot;category&quot;:&quot;writer&quot;}],&quot;version&quot;:&quot;2.0&quot;,&quot;order&quot;:{&quot;hops&quot;:[{&quot;from&quot;:&quot;reader&quot;,&quot;to&quot;:&quot;writer&quot;}]}}</para>
            /// </summary>
            [NameInMap("TaskContent")]
            [Validation(Required=false)]
            public string TaskContent { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can locate logs and troubleshoot issues based on the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1411515937635973****</para>
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
