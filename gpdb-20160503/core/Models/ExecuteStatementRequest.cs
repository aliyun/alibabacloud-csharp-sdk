// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ExecuteStatementRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a region, including instance IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adbtest</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The list of configuration parameters.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<object> Parameters { get; set; }

        /// <summary>
        /// <para>The vector dataset parameters.</para>
        /// <remarks>
        /// <para>If WorkspaceId is not empty, this parameter is required.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RagWorkspaceCollection")]
        [Validation(Required=false)]
        public ExecuteStatementRequestRagWorkspaceCollection RagWorkspaceCollection { get; set; }
        public class ExecuteStatementRequestRagWorkspaceCollection : TeaModel {
            /// <summary>
            /// <para>The collection name.</para>
            /// <remarks>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401503.html">ListCollections</a> operation to query the list.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>mycollection</para>
            /// </summary>
            [NameInMap("Collection")]
            [Validation(Required=false)]
            public string Collection { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// <remarks>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation to query the list.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>mynamespace</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

        }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The run type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>synchronous: synchronous execution.</description></item>
        /// <item><description>asynchronous: asynchronous execution. Currently not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>synchronous</para>
        /// </summary>
        [NameInMap("RunType")]
        [Validation(Required=false)]
        public string RunType { get; set; }

        /// <summary>
        /// <para>The access credential. Created by calling the CreateSecret operation.</para>
        /// <remarks>
        /// <para>When you access this operation by using a RAM user, you must have the UseSecret or GetSecretValue permission on this SecretArn.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:gpdb:cn-beijing:1033**:secret/testsecret-eG2AQGRIwQ0zFp4VA7mYL3uiCXTfDQbQ</para>
        /// </summary>
        [NameInMap("SecretArn")]
        [Validation(Required=false)]
        public string SecretArn { get; set; }

        /// <summary>
        /// <para>The SQL statement to execute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select * from table1</para>
        /// </summary>
        [NameInMap("Sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

        /// <summary>
        /// <para>The list of multiple SQL statements.</para>
        /// </summary>
        [NameInMap("Sqls")]
        [Validation(Required=false)]
        public List<string> Sqls { get; set; }

        /// <summary>
        /// <para>The name of the execution statement. This parameter takes effect only when RunType is set to asynchronous.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("StatementName")]
        [Validation(Required=false)]
        public string StatementName { get; set; }

        /// <summary>
        /// <para>The ID of the workspace that consists of multiple database instances. This parameter and DBInstanceId cannot both be empty. If both this parameter and DBInstanceId are specified, this parameter takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-ws-*****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
