// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ExecKgCypherRequest : TeaModel {
        /// <summary>
        /// <para>The custom Cypher query instruction.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ExecCommand")]
        [Validation(Required=false)]
        public ExecKgCypherRequestExecCommand ExecCommand { get; set; }
        public class ExecKgCypherRequestExecCommand : TeaModel {
            /// <summary>
            /// <para>The maximum number of records to return.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Limit")]
            [Validation(Required=false)]
            public int? Limit { get; set; }

            /// <summary>
            /// <para>The input parameters of the query statement.</para>
            /// </summary>
            [NameInMap("Params")]
            [Validation(Required=false)]
            public List<ExecKgCypherRequestExecCommandParams> Params { get; set; }
            public class ExecKgCypherRequestExecCommandParams : TeaModel {
                /// <summary>
                /// <para>The data type of paramValue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>paramKey</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>paramValue</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The custom Cypher query statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MATCH (n) RETURN n LIMIT 10</para>
            /// </summary>
            [NameInMap("Query")]
            [Validation(Required=false)]
            public string Query { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The model ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f1d4559a4db044158305e2d89bccf81f</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
