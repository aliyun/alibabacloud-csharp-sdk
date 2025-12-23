// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ValidateDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FA2B338-AFDC-46B4-A132-B5487820C2BF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ValidateDataSourcesResponseBodyResult> Result { get; set; }
        public class ValidateDataSourcesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The code returned for the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCEED</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("dataSource")]
            [Validation(Required=false)]
            public ValidateDataSourcesResponseBodyResultDataSource DataSource { get; set; }
            public class ValidateDataSourcesResponseBodyResultDataSource : TeaModel {
                /// <summary>
                /// <para>The parameters of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameters { get; set; }

                /// <summary>
                /// <para>The name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user_activity_decision</para>
                /// </summary>
                [NameInMap("tableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The type of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The status of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>successful</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

    }

}
