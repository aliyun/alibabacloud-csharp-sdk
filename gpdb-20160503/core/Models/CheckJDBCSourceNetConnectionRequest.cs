// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CheckJDBCSourceNetConnectionRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Either DataSourceId or JdbcConnectionString must be specified as input, otherwise an error will occur. If both parameters are specified, JdbcConnectionString will be used preferentially.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>JDBC connection string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jdbc:mysql://rm-xxx.mysql.rds.aliyuncs.com:3306/testadmin</para>
        /// </summary>
        [NameInMap("JdbcConnectionString")]
        [Validation(Required=false)]
        public string JdbcConnectionString { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
