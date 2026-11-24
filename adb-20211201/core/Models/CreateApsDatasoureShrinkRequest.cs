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
        /// <para>The Databricks data source information.</para>
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
        /// <para>The data source description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("DatasourceDescription")]
        [Validation(Required=false)]
        public string DatasourceDescription { get; set; }

        /// <summary>
        /// <para>The data source name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sls-******</para>
        /// </summary>
        [NameInMap("DatasourceName")]
        [Validation(Required=false)]
        public string DatasourceName { get; set; }

        /// <summary>
        /// <para>The data source type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KAFKA</para>
        /// </summary>
        [NameInMap("DatasourceType")]
        [Validation(Required=false)]
        public string DatasourceType { get; set; }

        /// <summary>
        /// <para>The Hive data source information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Vswitch&quot;:&quot;vsw-bp1*<b><b>k&quot;,&quot;SecurityGroup&quot;:&quot;sg-uf</b></b>***h&quot;}</para>
        /// </summary>
        [NameInMap("HiveInfo")]
        [Validation(Required=false)]
        public string HiveInfoShrink { get; set; }

        /// <summary>
        /// <para>The Kafka information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;KafkaClusterId&quot;:&quot;alikafka_pre-cn-aaa1a1aaa111&quot;,&quot;KafkaTopic&quot;:&quot;example-topic&quot;}</para>
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
        /// <para>The PolarDB for MySQL data source information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RegionId&quot;:&quot;cn-shanghai&quot;}</para>
        /// </summary>
        [NameInMap("PolarDBMysqlInfo")]
        [Validation(Required=false)]
        public string PolarDBMysqlInfoShrink { get; set; }

        /// <summary>
        /// <para>The PolarDB-X data source information.</para>
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
        /// <para>The ApsaraDB RDS for MySQL data source information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RegionId&quot;:&quot;cn-shanghai&quot;}</para>
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
        /// <para>The Simple Log Service (SLS) information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Project&quot;:&quot;example-project&quot;,&quot;Store&quot;:&quot;example-logstore&quot;,&quot;Across&quot;:false}</para>
        /// </summary>
        [NameInMap("SlsInfo")]
        [Validation(Required=false)]
        public string SlsInfoShrink { get; set; }

    }

}
