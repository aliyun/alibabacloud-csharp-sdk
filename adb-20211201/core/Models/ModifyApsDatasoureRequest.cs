// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyApsDatasoureRequest : TeaModel {
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
        public ModifyApsDatasoureRequestKafkaInfo KafkaInfo { get; set; }
        public class ModifyApsDatasoureRequestKafkaInfo : TeaModel {
            /// <summary>
            /// <para>The Kafka instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("KafkaClusterId")]
            [Validation(Required=false)]
            public string KafkaClusterId { get; set; }

            /// <summary>
            /// <para>The Kafka topic name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-topic</para>
            /// </summary>
            [NameInMap("KafkaTopic")]
            [Validation(Required=false)]
            public string KafkaTopic { get; set; }

        }

        /// <summary>
        /// <para>The Lakehouse ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VpcId&quot;:&quot;vpc-******&quot;}</para>
        /// </summary>
        [NameInMap("LakehouseId")]
        [Validation(Required=false)]
        public ModifyApsDatasoureRequestLakehouseId LakehouseId { get; set; }
        public class ModifyApsDatasoureRequestLakehouseId : TeaModel {
            /// <summary>
            /// <para>The security group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-******</para>
            /// </summary>
            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public string SecurityGroup { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-******</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The vSwitch name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-******</para>
            /// </summary>
            [NameInMap("Vswitch")]
            [Validation(Required=false)]
            public string Vswitch { get; set; }

        }

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
        public ModifyApsDatasoureRequestPolarDBMysqlInfo PolarDBMysqlInfo { get; set; }
        public class ModifyApsDatasoureRequestPolarDBMysqlInfo : TeaModel {
            /// <summary>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ConnectUrl")]
            [Validation(Required=false)]
            public string ConnectUrl { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

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
        public ModifyApsDatasoureRequestRdsMysqlInfo RdsMysqlInfo { get; set; }
        public class ModifyApsDatasoureRequestRdsMysqlInfo : TeaModel {
            /// <summary>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ConnectUrl")]
            [Validation(Required=false)]
            public string ConnectUrl { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

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
        public ModifyApsDatasoureRequestSlsInfo SlsInfo { get; set; }
        public class ModifyApsDatasoureRequestSlsInfo : TeaModel {
            /// <summary>
            /// <para>Specifies whether the resource is cross-account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The current network instance is a cross-account resource.</description></item>
            /// <item><description><b>false</b>: The current network instance is a resource within the current account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Across")]
            [Validation(Required=false)]
            public bool? Across { get; set; }

            /// <summary>
            /// <para>The cross-account role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-role</para>
            /// </summary>
            [NameInMap("AcrossRole")]
            [Validation(Required=false)]
            public string AcrossRole { get; set; }

            /// <summary>
            /// <para>The cross-account UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("AcrossUid")]
            [Validation(Required=false)]
            public string AcrossUid { get; set; }

            /// <summary>
            /// <para>The source region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("SourceRegionId")]
            [Validation(Required=false)]
            public string SourceRegionId { get; set; }

        }

    }

}
