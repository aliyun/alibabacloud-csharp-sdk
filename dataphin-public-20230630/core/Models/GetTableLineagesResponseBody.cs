// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetTableLineagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The table lineage list.</para>
        /// </summary>
        [NameInMap("TableLineageList")]
        [Validation(Required=false)]
        public List<GetTableLineagesResponseBodyTableLineageList> TableLineageList { get; set; }
        public class GetTableLineagesResponseBodyTableLineageList : TeaModel {
            /// <summary>
            /// <para>The ID of the business unit to which the input table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InputBizUnitId")]
            [Validation(Required=false)]
            public long? InputBizUnitId { get; set; }

            /// <summary>
            /// <para>The ID of the data source to which the input table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InputDataSourceId")]
            [Validation(Required=false)]
            public long? InputDataSourceId { get; set; }

            /// <summary>
            /// <para>The type of the data source to which the input table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MAX_COMPUTE</para>
            /// </summary>
            [NameInMap("InputDataSourceType")]
            [Validation(Required=false)]
            public string InputDataSourceType { get; set; }

            /// <summary>
            /// <para>The ID of the project to which the input table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1233</para>
            /// </summary>
            [NameInMap("InputProjectId")]
            [Validation(Required=false)]
            public long? InputProjectId { get; set; }

            /// <summary>
            /// <para>Indicates whether the input table has been deleted.</para>
            /// </summary>
            [NameInMap("InputTableDeleted")]
            [Validation(Required=false)]
            public bool? InputTableDeleted { get; set; }

            /// <summary>
            /// <para>The environment to which the input table belongs. Valid values: dev and prod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("InputTableEnv")]
            [Validation(Required=false)]
            public string InputTableEnv { get; set; }

            /// <summary>
            /// <para>The GUID of the input table. Each asset has a unique identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123211</para>
            /// </summary>
            [NameInMap("InputTableGuid")]
            [Validation(Required=false)]
            public string InputTableGuid { get; set; }

            /// <summary>
            /// <para>The name of the input table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t_input</para>
            /// </summary>
            [NameInMap("InputTableName")]
            [Validation(Required=false)]
            public string InputTableName { get; set; }

            /// <summary>
            /// <para>The environment to which the task belongs. Valid values: dev and prod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("NodeEnv")]
            [Validation(Required=false)]
            public string NodeEnv { get; set; }

            /// <summary>
            /// <para>The task ID associated with the lineage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110021</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The ID of the business unit to which the output table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OutputBizUnitId")]
            [Validation(Required=false)]
            public long? OutputBizUnitId { get; set; }

            /// <summary>
            /// <para>The ID of the data source to which the output table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OutputDataSourceId")]
            [Validation(Required=false)]
            public long? OutputDataSourceId { get; set; }

            /// <summary>
            /// <para>The type of the data source to which the output table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MAX_COMPUTE</para>
            /// </summary>
            [NameInMap("OutputDataSourceType")]
            [Validation(Required=false)]
            public string OutputDataSourceType { get; set; }

            /// <summary>
            /// <para>The ID of the project to which the output table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1233</para>
            /// </summary>
            [NameInMap("OutputProjectId")]
            [Validation(Required=false)]
            public long? OutputProjectId { get; set; }

            /// <summary>
            /// <para>Indicates whether the output table has been deleted.</para>
            /// </summary>
            [NameInMap("OutputTableDeleted")]
            [Validation(Required=false)]
            public bool? OutputTableDeleted { get; set; }

            /// <summary>
            /// <para>The environment to which the output table belongs. Valid values: dev and prod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("OutputTableEnv")]
            [Validation(Required=false)]
            public string OutputTableEnv { get; set; }

            /// <summary>
            /// <para>The GUID of the output table. Each asset has a unique identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2231</para>
            /// </summary>
            [NameInMap("OutputTableGuid")]
            [Validation(Required=false)]
            public string OutputTableGuid { get; set; }

            /// <summary>
            /// <para>The name of the output table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t_output</para>
            /// </summary>
            [NameInMap("OutputTableName")]
            [Validation(Required=false)]
            public string OutputTableName { get; set; }

        }

    }

}
