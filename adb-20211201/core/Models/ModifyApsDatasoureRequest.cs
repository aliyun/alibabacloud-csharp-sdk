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
        /// <para>The description of the data source.</para>
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
        /// <para>The name of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sls-******</para>
        /// </summary>
        [NameInMap("DatasourceName")]
        [Validation(Required=false)]
        public string DatasourceName { get; set; }

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
        [NameInMap("KafkaInfo")]
        [Validation(Required=false)]
        public ModifyApsDatasoureRequestKafkaInfo KafkaInfo { get; set; }
        public class ModifyApsDatasoureRequestKafkaInfo : TeaModel {
            /// <summary>
            /// <para>The ID of the Kafka instance.</para>
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
            /// <para>The topic of the Kafka instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-topic</para>
            /// </summary>
            [NameInMap("KafkaTopic")]
            [Validation(Required=false)]
            public string KafkaTopic { get; set; }

        }

        /// <summary>
        /// <para>The lakehouse ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("LakehouseId")]
        [Validation(Required=false)]
        public ModifyApsDatasoureRequestLakehouseId LakehouseId { get; set; }
        public class ModifyApsDatasoureRequestLakehouseId : TeaModel {
            /// <summary>
            /// <para>The name of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-******</para>
            /// </summary>
            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public string SecurityGroup { get; set; }

            /// <summary>
            /// <para>The virtual private cloud (VPC) ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-******</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The name of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-******</para>
            /// </summary>
            [NameInMap("Vswitch")]
            [Validation(Required=false)]
            public string Vswitch { get; set; }

        }

        /// <summary>
        /// <para>The retired data source.</para>
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
        /// <para>The retired data source.</para>
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
        /// <para>The information about Simple Log Service (SLS).</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("SlsInfo")]
        [Validation(Required=false)]
        public ModifyApsDatasoureRequestSlsInfo SlsInfo { get; set; }
        public class ModifyApsDatasoureRequestSlsInfo : TeaModel {
            /// <summary>
            /// <para>Specifies whether to use a cross-account resource as the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Across")]
            [Validation(Required=false)]
            public bool? Across { get; set; }

            /// <summary>
            /// <para>The name of the cross-account role.</para>
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
            /// <para>The region ID.</para>
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
