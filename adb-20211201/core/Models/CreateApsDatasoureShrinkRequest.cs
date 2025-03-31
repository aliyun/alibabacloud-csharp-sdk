// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateApsDatasoureShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-xxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The information about the Databricks data source.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("DatabricksInfo")]
        [Validation(Required=false)]
        public string DatabricksInfoShrink { get; set; }

        /// <summary>
        /// <para>The description of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("DatasourceDescription")]
        [Validation(Required=false)]
        public string DatasourceDescription { get; set; }

        /// <summary>
        /// <para>The name of the data source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sls-******</para>
        /// </summary>
        [NameInMap("DatasourceName")]
        [Validation(Required=false)]
        public string DatasourceName { get; set; }

        /// <summary>
        /// <para>The type of the data source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KAFKA</para>
        /// </summary>
        [NameInMap("DatasourceType")]
        [Validation(Required=false)]
        public string DatasourceType { get; set; }

        /// <summary>
        /// <para>The information about the Hive data source.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("HiveInfo")]
        [Validation(Required=false)]
        public string HiveInfoShrink { get; set; }

        /// <summary>
        /// <para>The information about the source Apache Kafka instance.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("KafkaInfo")]
        [Validation(Required=false)]
        public string KafkaInfoShrink { get; set; }

        /// <summary>
        /// <para>The mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALI_CLOUD_INSTANCE</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The information about the source PolarDB for MySQL cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("PolarDBMysqlInfo")]
        [Validation(Required=false)]
        public string PolarDBMysqlInfoShrink { get; set; }

        /// <summary>
        /// <para>The information about the source PolarDB-X instance.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("PolarDBXInfo")]
        [Validation(Required=false)]
        public string PolarDBXInfoShrink { get; set; }

        /// <summary>
        /// <para>The information about the source ApsaraDB RDS for MySQL instance.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("RdsMysqlInfo")]
        [Validation(Required=false)]
        public string RdsMysqlInfoShrink { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The information about the source Simple Log Service (SLS) instance or cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("SlsInfo")]
        [Validation(Required=false)]
        public string SlsInfoShrink { get; set; }

    }

}
