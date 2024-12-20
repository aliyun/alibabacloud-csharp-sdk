// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeJDBCDataSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the service was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the service. The description can be up to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql data source config</para>
        /// </summary>
        [NameInMap("DataSourceDescription")]
        [Validation(Required=false)]
        public string DataSourceDescription { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>The name of data soruce</para>
        /// 
        /// <b>Example:</b>
        /// <para>hdfs_pxf</para>
        /// </summary>
        [NameInMap("DataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <para>The status of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Init</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Exception</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DataSourceStatus")]
        [Validation(Required=false)]
        public string DataSourceStatus { get; set; }

        /// <summary>
        /// <para>The type of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The id of the external data service</para>
        /// 
        /// <b>Example:</b>
        /// <para>2989</para>
        /// </summary>
        [NameInMap("ExternalDataServiceId")]
        [Validation(Required=false)]
        public string ExternalDataServiceId { get; set; }

        /// <summary>
        /// <para>The JDBC connection string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("JDBCConnectionString")]
        [Validation(Required=false)]
        public string JDBCConnectionString { get; set; }

        /// <summary>
        /// <para>The password of the database account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("JDBCPassword")]
        [Validation(Required=false)]
        public string JDBCPassword { get; set; }

        /// <summary>
        /// <para>The name of the database account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("JDBCUserName")]
        [Validation(Required=false)]
        public string JDBCUserName { get; set; }

        /// <summary>
        /// <para>The time when the data source was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-27T02:01:10Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The message of the status</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("StatusMessage")]
        [Validation(Required=false)]
        public string StatusMessage { get; set; }

    }

}
