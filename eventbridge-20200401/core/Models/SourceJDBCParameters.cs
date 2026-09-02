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
        /// </summary>
        [NameInMap("BatchSize")]
        [Validation(Required=false)]
        public int? BatchSize { get; set; }

        /// <summary>
        /// <para>The custom SQL query statement (advanced mode). This parameter is mutually exclusive with TableName.</para>
        /// </summary>
        [NameInMap("CustomQuery")]
        [Validation(Required=false)]
        public string CustomQuery { get; set; }

        /// <summary>
        /// <para>The incrementing column name. Required when QueryMode is set to <c>incrementing</c> or <c>timestamp_incrementing</c>.</para>
        /// </summary>
        [NameInMap("IncrementingColumn")]
        [Validation(Required=false)]
        public string IncrementingColumn { get; set; }

        /// <summary>
        /// <para>The JDBC connection URL. ClickHouse example: <c>jdbc:clickhouse://host:8123/database</c>; MySQL example: <c>jdbc:mysql://host:3306/database</c>. The system automatically identifies the database type.</para>
        /// </summary>
        [NameInMap("JdbcUrl")]
        [Validation(Required=false)]
        public string JdbcUrl { get; set; }

        /// <summary>
        /// <para>The network type. Valid values: <c>PublicNetwork</c> (public network); <c>PrivateNetwork</c> (VPC private network, requires VpcId, VSwitchIds, and SecurityGroupId to be configured).</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        /// <summary>
        /// <para>The database password.</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The polling interval, in seconds. Minimum value: 10. Default value: 60.</para>
        /// </summary>
        [NameInMap("PollingInterval")]
        [Validation(Required=false)]
        public int? PollingInterval { get; set; }

        /// <summary>
        /// <para>The query mode. Valid values: <c>bulk</c> (full query); <c>incrementing</c> (incrementing column tracking); <c>timestamp</c> (timestamp tracking); <c>timestamp_incrementing</c> (timestamp and incrementing column dual tracking).</para>
        /// </summary>
        [NameInMap("QueryMode")]
        [Validation(Required=false)]
        public string QueryMode { get; set; }

        /// <summary>
        /// <para>The SQL query timeout period, in seconds. Default value: 30. Maximum value: 300.</para>
        /// </summary>
        [NameInMap("QueryTimeout")]
        [Validation(Required=false)]
        public int? QueryTimeout { get; set; }

        /// <summary>
        /// <para>The security group ID. Required when Network is set to PrivateNetwork.</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The target table name. This parameter is mutually exclusive with CustomQuery. Required when custom SQL is not used.</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The timestamp column name. Required when QueryMode is set to <c>timestamp</c> or <c>timestamp_incrementing</c>.</para>
        /// </summary>
        [NameInMap("TimestampColumn")]
        [Validation(Required=false)]
        public string TimestampColumn { get; set; }

        /// <summary>
        /// <para>The database username.</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. Required when Network is set to PrivateNetwork.</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

        /// <summary>
        /// <para>The VPC ID. Required when Network is set to PrivateNetwork.</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
