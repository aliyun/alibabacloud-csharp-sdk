// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyApsDatasoureShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-*******</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The data source description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DatasourceDescription")]
        [Validation(Required=false)]
        public string DatasourceDescription { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DatasourceId")]
        [Validation(Required=false)]
        public long? DatasourceId { get; set; }

        /// <summary>
        /// <para>The data source name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sls-******</para>
        /// </summary>
        [NameInMap("DatasourceName")]
        [Validation(Required=false)]
        public string DatasourceName { get; set; }

        /// <summary>
        /// <para>The Kafka data source information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;KafkaTopic&quot;:&quot;test-topic&quot;}</para>
        /// </summary>
        [NameInMap("KafkaInfo")]
        [Validation(Required=false)]
        public string KafkaInfoShrink { get; set; }

        /// <summary>
        /// <para>The Lakehouse ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VpcId&quot;:&quot;vpc-******&quot;}</para>
        /// </summary>
        [NameInMap("LakehouseId")]
        [Validation(Required=false)]
        public string LakehouseIdShrink { get; set; }

        /// <summary>
        /// <para>The deprecated data source information.</para>
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
        /// <para>The deprecated data source information.</para>
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
