// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class MoveResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public MoveResourceGroupResponseBodyResult Result { get; set; }
        public class MoveResourceGroupResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the cluster was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-07-06T10:18:48.662Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-abc</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The configurations of IK dictionaries.</para>
            /// </summary>
            [NameInMap("dictList")]
            [Validation(Required=false)]
            public List<MoveResourceGroupResponseBodyResultDictList> DictList { get; set; }
            public class MoveResourceGroupResponseBodyResultDictList : TeaModel {
                /// <summary>
                /// <para>The size of the dictionary file. Unit: bytes.</para>
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
                /// <para>The type of the source of the dictionary file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OSS: Object Storage Service (OSS). You must make sure that the access control list (ACL) of the related OSS bucket is public read.</description></item>
                /// <item><description>ORIGIN: previously uploaded dictionary.</description></item>
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
                /// <item><description>STOP: stopword list</description></item>
                /// <item><description>MAIN: main dictionary</description></item>
                /// <item><description>SYNONYMS: synonym dictionary</description></item>
                /// <item><description>ALI_WS: Alibaba Cloud dictionary</description></item>
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
            /// <para>The internal endpoint of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-nif1q8auz0003****.elasticsearch.aliyuncs.com</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The version of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6.7.0_with_X-Pack</para>
            /// </summary>
            [NameInMap("esVersion")]
            [Validation(Required=false)]
            public string EsVersion { get; set; }

            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-n6w1o1x0w001c****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The configurations of Kibana nodes.</para>
            /// </summary>
            [NameInMap("kibanaConfiguration")]
            [Validation(Required=false)]
            public MoveResourceGroupResponseBodyResultKibanaConfiguration KibanaConfiguration { get; set; }
            public class MoveResourceGroupResponseBodyResultKibanaConfiguration : TeaModel {
                /// <summary>
                /// <para>The number of nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <para>The storage capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>The storage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The specification category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elasticsearch.n4.small</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// <para>The public endpoint of the Kibana console of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-nif1q8auz0003****.kibana.elasticsearch.aliyuncs.com</para>
            /// </summary>
            [NameInMap("kibanaDomain")]
            [Validation(Required=false)]
            public string KibanaDomain { get; set; }

            /// <summary>
            /// <para>The port number that is used to access the Kibana console of the cluster over the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5601</para>
            /// </summary>
            [NameInMap("kibanaPort")]
            [Validation(Required=false)]
            public int? KibanaPort { get; set; }

            /// <summary>
            /// <para>The configurations of dedicated master nodes.</para>
            /// </summary>
            [NameInMap("masterConfiguration")]
            [Validation(Required=false)]
            public MoveResourceGroupResponseBodyResultMasterConfiguration MasterConfiguration { get; set; }
            public class MoveResourceGroupResponseBodyResultMasterConfiguration : TeaModel {
                /// <summary>
                /// <para>The number of nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                /// <summary>
                /// <para>The storage capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>The storage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The specification category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elasticsearch.sn2ne.large</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// <para>The network configurations.</para>
            /// </summary>
            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public MoveResourceGroupResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class MoveResourceGroupResponseBodyResultNetworkConfig : TeaModel {
                /// <summary>
                /// <para>The network type. Only the VPC is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp16k1dvzxtmagcva****</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The zone where the cluster resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("vsArea")]
                [Validation(Required=false)]
                public string VsArea { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1k4ec6s7sjdbudw****</para>
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

            /// <summary>
            /// <para>The number of data nodes in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// <para>The configurations of data nodes.</para>
            /// </summary>
            [NameInMap("nodeSpec")]
            [Validation(Required=false)]
            public MoveResourceGroupResponseBodyResultNodeSpec NodeSpec { get; set; }
            public class MoveResourceGroupResponseBodyResultNodeSpec : TeaModel {
                /// <summary>
                /// <para>The storage capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>The storage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The specification category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elasticsearch.n4.small</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// <para>The billing method of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>prepaid: subscription</description></item>
            /// <item><description>postpaid: pay-as-you-go</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>postpaid</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>The public endpoint of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-n6w1o1x0w001c****.public.elasticsearch.aliyuncs.com</para>
            /// </summary>
            [NameInMap("publicDomain")]
            [Validation(Required=false)]
            public string PublicDomain { get; set; }

            /// <summary>
            /// <para>The port number that is used to access the cluster over the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9200</para>
            /// </summary>
            [NameInMap("publicPort")]
            [Validation(Required=false)]
            public int? PublicPort { get; set; }

            /// <summary>
            /// <para>The status of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>active: The cluster is normal.</description></item>
            /// <item><description>activating: The cluster is being activated.</description></item>
            /// <item><description>Inactive: The cluster is frozen.</description></item>
            /// <item><description>invalid: The cluster is valid.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The configurations of synonym dictionaries.</para>
            /// </summary>
            [NameInMap("synonymsDicts")]
            [Validation(Required=false)]
            public List<MoveResourceGroupResponseBodyResultSynonymsDicts> SynonymsDicts { get; set; }
            public class MoveResourceGroupResponseBodyResultSynonymsDicts : TeaModel {
                /// <summary>
                /// <para>The size of the dictionary file. Unit: bytes.</para>
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
                /// <para>The type of the source of the dictionary file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OSS: Object Storage Service (OSS). You must make sure that the ACL of the related OSS bucket is public read.</description></item>
                /// <item><description>ORIGIN: previously uploaded dictionary.</description></item>
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
                /// <item><description>STOP: stopword list</description></item>
                /// <item><description>MAIN: main dictionary</description></item>
                /// <item><description>SYNONYMS: synonym dictionary</description></item>
                /// <item><description>ALI_WS: Alibaba Cloud dictionary</description></item>
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
            /// <para>The time when the cluster was last updated.</para>
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
