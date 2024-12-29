// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeApsDatasourceResponseBody : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("ApsDatasource")]
        [Validation(Required=false)]
        public DescribeApsDatasourceResponseBodyApsDatasource ApsDatasource { get; set; }
        public class DescribeApsDatasourceResponseBodyApsDatasource : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-04-12T15:03:38Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>amv-******</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("DatabricksInfo")]
            [Validation(Required=false)]
            public DescribeApsDatasourceResponseBodyApsDatasourceDatabricksInfo DatabricksInfo { get; set; }
            public class DescribeApsDatasourceResponseBodyApsDatasourceDatabricksInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("accessToken")]
                [Validation(Required=false)]
                public string AccessToken { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("workspaceURL")]
                [Validation(Required=false)]
                public string WorkspaceURL { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DatasourceDescription")]
            [Validation(Required=false)]
            public string DatasourceDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>kafka-2024***</para>
            /// </summary>
            [NameInMap("DatasourceName")]
            [Validation(Required=false)]
            public string DatasourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>KAFKA</para>
            /// </summary>
            [NameInMap("DatasourceType")]
            [Validation(Required=false)]
            public string DatasourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("HiveInfo")]
            [Validation(Required=false)]
            public DescribeApsDatasourceResponseBodyApsDatasourceHiveInfo HiveInfo { get; set; }
            public class DescribeApsDatasourceResponseBodyApsDatasourceHiveInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("EmrClusterId")]
                [Validation(Required=false)]
                public string EmrClusterId { get; set; }

                /// <summary>
                /// <para>hive meta store url。</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("MetaStoreUri")]
                [Validation(Required=false)]
                public string MetaStoreUri { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sg-******</para>
                /// </summary>
                [NameInMap("SecurityGroup")]
                [Validation(Required=false)]
                public string SecurityGroup { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-******</para>
                /// </summary>
                [NameInMap("Vswitch")]
                [Validation(Required=false)]
                public string Vswitch { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("KafkaInfo")]
            [Validation(Required=false)]
            public DescribeApsDatasourceResponseBodyApsDatasourceKafkaInfo KafkaInfo { get; set; }
            public class DescribeApsDatasourceResponseBodyApsDatasourceKafkaInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("KafkaClusterId")]
                [Validation(Required=false)]
                public string KafkaClusterId { get; set; }

                /// <summary>
                /// <para>kafka topic</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;value\&quot;: \&quot;hongxian_test\&quot;}]</para>
                /// </summary>
                [NameInMap("KafkaTopic")]
                [Validation(Required=false)]
                public string KafkaTopic { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("PolarDBMysqlInfo")]
            [Validation(Required=false)]
            public DescribeApsDatasourceResponseBodyApsDatasourcePolarDBMysqlInfo PolarDBMysqlInfo { get; set; }
            public class DescribeApsDatasourceResponseBodyApsDatasourcePolarDBMysqlInfo : TeaModel {
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
                [NameInMap("Across")]
                [Validation(Required=false)]
                public bool? Across { get; set; }

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
                [NameInMap("AcrossRole")]
                [Validation(Required=false)]
                public string AcrossRole { get; set; }

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
                [NameInMap("AcrossUid")]
                [Validation(Required=false)]
                public string AcrossUid { get; set; }

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
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

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
                [NameInMap("SecurityGroup")]
                [Validation(Required=false)]
                public string SecurityGroup { get; set; }

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
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("RdsMysqlInfo")]
            [Validation(Required=false)]
            public DescribeApsDatasourceResponseBodyApsDatasourceRdsMysqlInfo RdsMysqlInfo { get; set; }
            public class DescribeApsDatasourceResponseBodyApsDatasourceRdsMysqlInfo : TeaModel {
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
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

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
                [NameInMap("SecurityGroup")]
                [Validation(Required=false)]
                public string SecurityGroup { get; set; }

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
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("SlsInfo")]
            [Validation(Required=false)]
            public DescribeApsDatasourceResponseBodyApsDatasourceSlsInfo SlsInfo { get; set; }
            public class DescribeApsDatasourceResponseBodyApsDatasourceSlsInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Across")]
                [Validation(Required=false)]
                public bool? Across { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AcrossRole")]
                [Validation(Required=false)]
                public string AcrossRole { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("AcrossUid")]
                [Validation(Required=false)]
                public string AcrossUid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("SourceRegionId")]
                [Validation(Required=false)]
                public string SourceRegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Store")]
                [Validation(Required=false)]
                public string Store { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>******-<b>D8-5</b><em>-A</em>**-****587</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
