// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class RestartInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6DC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The return results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public RestartInstanceResponseBodyResult Result { get; set; }
        public class RestartInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-07-06T10:18:48.662Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-abc</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The configuration of the IK dictionaries.</para>
            /// </summary>
            [NameInMap("dictList")]
            [Validation(Required=false)]
            public List<RestartInstanceResponseBodyResultDictList> DictList { get; set; }
            public class RestartInstanceResponseBodyResultDictList : TeaModel {
                /// <summary>
                /// <para>The size of the Dictionary File. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2782602</para>
                /// </summary>
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// <para>The name of the dictionary file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM_MAIN.dic</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The source type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OSS: OSS open storage (need to ensure that OSS storage space is public readable.)</description></item>
                /// <item><description>ORIGIN: Open source Elasticsearch</description></item>
                /// <item><description>UPLOAD: Uploaded files</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ORIGIN</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The type of the dictionary. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>STOP: The STOP word.</description></item>
                /// <item><description>MAIN: MAIN Dictionary</description></item>
                /// <item><description>SYNONYMS: SYNONYMS</description></item>
                /// <item><description>ALI_WS: an Alibaba Dictionary.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MAIN</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The intranet access address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-nif1q8auz0003****.elasticsearch.aliyuncs.com</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The version of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6.7.0_with_X-Pack</para>
            /// </summary>
            [NameInMap("esVersion")]
            [Validation(Required=false)]
            public string EsVersion { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-n6w1o1x0w001c****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The configuration of Kibana nodes.</para>
            /// </summary>
            [NameInMap("kibanaConfiguration")]
            [Validation(Required=false)]
            public RestartInstanceResponseBodyResultKibanaConfiguration KibanaConfiguration { get; set; }
            public class RestartInstanceResponseBodyResultKibanaConfiguration : TeaModel {
                /// <summary>
                /// <para>The number of performance metrics.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <para>The size of the node storage space. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>The storage type of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The specification of data nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elasticsearch.n4.small</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// <para>The public network access address of Kibana.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-nif1q8auz0003****.kibana.elasticsearch.aliyuncs.com</para>
            /// </summary>
            [NameInMap("kibanaDomain")]
            [Validation(Required=false)]
            public string KibanaDomain { get; set; }

            /// <summary>
            /// <para>The public port of the Kibana network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5601</para>
            /// </summary>
            [NameInMap("kibanaPort")]
            [Validation(Required=false)]
            public int? KibanaPort { get; set; }

            /// <summary>
            /// <para>The configuration of dedicated master nodes.</para>
            /// </summary>
            [NameInMap("masterConfiguration")]
            [Validation(Required=false)]
            public RestartInstanceResponseBodyResultMasterConfiguration MasterConfiguration { get; set; }
            public class RestartInstanceResponseBodyResultMasterConfiguration : TeaModel {
                /// <summary>
                /// <para>The number of nodes in the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <para>The size of the node storage space. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>The storage type of the node. This tool only supports cloud_ssd (cloud SSD) disks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The node specifications of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elasticsearch.sn2ne.large</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// <para>The network configuration.</para>
            /// </summary>
            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public RestartInstanceResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class RestartInstanceResponseBodyResultNetworkConfig : TeaModel {
                /// <summary>
                /// <para>The network type. Only Virtual Private Cloud (VPC) is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp16k1dvzxtmagcva****</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The zone where the instance is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("vsArea")]
                [Validation(Required=false)]
                public string VsArea { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch associated with the specified VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1k4ec6s7sjdbudw****</para>
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

            /// <summary>
            /// <para>The number of data nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// <para>The configuration of data nodes.</para>
            /// </summary>
            [NameInMap("nodeSpec")]
            [Validation(Required=false)]
            public RestartInstanceResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class RestartInstanceResponseBodyResultNodeSpec : TeaModel {
                /// <summary>
                /// <para>The storage space size per data node. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>The storage type of the node. Valid values: cloud_ssd and cloud_efficiency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The specification of data nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elasticsearch.n4.small</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// <para>The billing method of the created ECS instance.</para>
            /// <para>Valid values: prepaid and postpaid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>postpaid</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>The public network access address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-n6w1o1x0w001c****.public.elasticsearch.aliyuncs.com</para>
            /// </summary>
            [NameInMap("publicDomain")]
            [Validation(Required=false)]
            public string PublicDomain { get; set; }

            /// <summary>
            /// <para>The public network port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9200</para>
            /// </summary>
            [NameInMap("publicPort")]
            [Validation(Required=false)]
            public int? PublicPort { get; set; }

            /// <summary>
            /// <para>The state of the cluster.</para>
            /// <para>Supported: active (normal), activating (initializing), inactive (blocked), and invalid (expired).</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The configuration of the synonym dictionaries.</para>
            /// </summary>
            [NameInMap("synonymsDicts")]
            [Validation(Required=false)]
            public List<RestartInstanceResponseBodyResultSynonymsDicts> SynonymsDicts { get; set; }
            public class RestartInstanceResponseBodyResultSynonymsDicts : TeaModel {
                /// <summary>
                /// <para>The size of the Dictionary File. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2782602</para>
                /// </summary>
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// <para>The name of the dictionary file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM_MAIN.dic</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The source type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OSS:OSS open storage (the OSS storage space must be publicly readable.)</description></item>
                /// <item><description>ORIGIN: open-source Elasticsearch</description></item>
                /// <item><description>UPLOAD</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ORIGIN</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The type of the dictionary. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>STOP: The STOP word.</description></item>
                /// <item><description>MAIN: MAIN Dictionary</description></item>
                /// <item><description>SYNONYMS: SYNONYMS</description></item>
                /// <item><description>ALI_WS: an Alibaba Dictionary.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>STOP</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The time when the instance was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-07-18T10:10:04.484Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

    }

}
