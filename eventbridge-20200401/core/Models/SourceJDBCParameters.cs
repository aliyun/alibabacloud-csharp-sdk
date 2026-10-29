// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SourceJDBCParameters : TeaModel {
        /// <summary>
        /// <para>The maximum number of rows returned per query. Default value: 1000. Maximum value: 10000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("BatchSize")]
        [Validation(Required=false)]
        public int? BatchSize { get; set; }

        /// <summary>
        /// <para>The custom SQL query statement for advanced mode. This parameter is mutually exclusive with TableName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT * FROM example_table</para>
        /// </summary>
        [NameInMap("CustomQuery")]
        [Validation(Required=false)]
        public string CustomQuery { get; set; }

        /// <summary>
        /// <para>The name of the auto-increment column. This parameter is required when QueryMode is set to <c>incrementing</c> or <c>timestamp_incrementing</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id</para>
        /// </summary>
        [NameInMap("IncrementingColumn")]
        [Validation(Required=false)]
        public string IncrementingColumn { get; set; }

        /// <summary>
        /// <para>The JDBC connection URL. ClickHouse example: <c>jdbc:clickhouse://host:8123/database</c>. MySQL example: <c>jdbc:mysql://host:3306/database</c>. The system automatically identifies the database type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jdbc:mysql://host:3306/database</para>
        /// </summary>
        [NameInMap("JdbcUrl")]
        [Validation(Required=false)]
        public string JdbcUrl { get; set; }

        /// <summary>
        /// <para>The network type. Valid values: <c>PublicNetwork</c> (public network) and <c>PrivateNetwork</c> (VPC private network, which requires VpcId, VSwitchIds, and SecurityGroupId to be configured).</para>
        /// 
        /// <b>Example:</b>
        /// <para>PublicNetwork</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        /// <summary>
        /// <para>The database password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example_password</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The polling interval in seconds. Minimum value: 10. Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("PollingInterval")]
        [Validation(Required=false)]
        public int? PollingInterval { get; set; }

        /// <summary>
        /// <para>The query mode. Valid values: <c>bulk</c> (full query), <c>incrementing</c> (auto-increment column tracking), <c>timestamp</c> (timestamp tracking), and <c>timestamp_incrementing</c> (dual tracking by timestamp and auto-increment column).</para>
        /// 
        /// <b>Example:</b>
        /// <para>bulk</para>
        /// </summary>
        [NameInMap("QueryMode")]
        [Validation(Required=false)]
        public string QueryMode { get; set; }

        /// <summary>
        /// <para>The SQL query timeout in seconds. Default value: 30. Maximum value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("QueryTimeout")]
        [Validation(Required=false)]
        public int? QueryTimeout { get; set; }

        /// <summary>
        /// <para>The security group ID. This parameter is required when Network is set to PrivateNetwork.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-a1b2c3d4e5f6g7h8i9j0</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The name of the target table. This parameter is mutually exclusive with CustomQuery and is required when custom SQL is not used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example_table</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The name of the timestamp column. This parameter is required when QueryMode is set to <c>timestamp</c> or <c>timestamp_incrementing</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>updated_at</para>
        /// </summary>
        [NameInMap("TimestampColumn")]
        [Validation(Required=false)]
        public string TimestampColumn { get; set; }

        /// <summary>
        /// <para>The database username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example_user</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The vSwitch IDs. This parameter is required when Network is set to PrivateNetwork.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-a1b2c3d4e5f6g7h8i9j0k</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

        /// <summary>
        /// <para>The VPC ID. This parameter is required when Network is set to PrivateNetwork.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-a1b2c3d4e5f6g7h8i9j0k</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
