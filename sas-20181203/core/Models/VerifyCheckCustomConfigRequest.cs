// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class VerifyCheckCustomConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the check item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>The input parameters for custom check item validation.</para>
        /// </summary>
        [NameInMap("CustomCheckConfig")]
        [Validation(Required=false)]
        public VerifyCheckCustomConfigRequestCustomCheckConfig CustomCheckConfig { get; set; }
        public class VerifyCheckCustomConfigRequestCustomCheckConfig : TeaModel {
            /// <summary>
            /// <para>The definition rule of the custom check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;AssociatedData&quot;:{&quot;ToDataList&quot;:[{&quot;DataName&quot;:&quot;ACS_ECS_Instance&quot;,&quot;PropertyPath&quot;:&quot;InstanceId&quot;,&quot;FromPropertyPath&quot;:&quot;InstanceId&quot;}]},&quot;MatchProperty&quot;:{&quot;Operator&quot;:&quot;AND&quot;,&quot;MatchProperties&quot;:[{&quot;DataName&quot;:&quot;ACS_ECS_Disk&quot;,&quot;PropertyPath&quot;:&quot;DiskId&quot;,&quot;MatchOperator&quot;:&quot;EQ&quot;,&quot;MatchPropertyValue&quot;:&quot;testId&quot;}]}}</para>
            /// </summary>
            [NameInMap("CheckRule")]
            [Validation(Required=false)]
            public string CheckRule { get; set; }

            /// <summary>
            /// <para>The asset instance on which you want to test the rule.</para>
            /// </summary>
            [NameInMap("CloudAssetInstance")]
            [Validation(Required=false)]
            public VerifyCheckCustomConfigRequestCustomCheckConfigCloudAssetInstance CloudAssetInstance { get; set; }
            public class VerifyCheckCustomConfigRequestCustomCheckConfigCloudAssetInstance : TeaModel {
                /// <summary>
                /// <para>The instance ID of the asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-0jl4mjgl261cfrz5****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The region ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-southeast-1</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>The asset subtype of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DISK</para>
            /// </summary>
            [NameInMap("InstanceSubType")]
            [Validation(Required=false)]
            public string InstanceSubType { get; set; }

            /// <summary>
            /// <para>The asset type of the cloud service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ECS</b>: server</description></item>
            /// <item><description><b>SLB</b>: load balancing</description></item>
            /// <item><description><b>RDS</b>: ApsaraDB RDS database</description></item>
            /// <item><description><b>MONGODB</b>: ApsaraDB for MongoDB database</description></item>
            /// <item><description><b>KVSTORE</b>: ApsaraDB for Redis database</description></item>
            /// <item><description><b>ACR</b>: ACR</description></item>
            /// <item><description><b>CSK</b>: CSK</description></item>
            /// <item><description><b>VPC</b>: VPC</description></item>
            /// <item><description><b>ACTIONTRAIL</b>: ActionTrail</description></item>
            /// <item><description><b>CDN</b>: CDN</description></item>
            /// <item><description><b>CAS</b>: Certificate Management Service (formerly SSL Certificates Service)</description></item>
            /// <item><description><b>RDC</b>: Apsara Devops</description></item>
            /// <item><description><b>RAM</b>: RAM</description></item>
            /// <item><description><b>DDOS</b>: distributed deny of service</description></item>
            /// <item><description><b>WAF</b>: WAF</description></item>
            /// <item><description><b>OSS</b>: access control</description></item>
            /// <item><description><b>POLARDB</b>: POLARDB</description></item>
            /// <item><description><b>POSTGRESQL</b>: PostgreSQL</description></item>
            /// <item><description><b>MSE</b>: MSE</description></item>
            /// <item><description><b>NAS</b>: NAS</description></item>
            /// <item><description><b>SDDP</b>: SDDP</description></item>
            /// <item><description><b>EIP</b>: EIP.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The cloud asset vendor. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ALIYUN</b>: Alibaba Cloud</description></item>
            /// <item><description><b>Tencent</b>: Tencent Cloud</description></item>
            /// <item><description><b>HUAWEICLOUD</b>: Huawei Cloud</description></item>
            /// <item><description><b>Azure</b>: Microsoft Azure</description></item>
            /// <item><description><b>AWS</b>: Amazon Web Services (AWS).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// <para>The list of custom parameter configuration items for the check item.</para>
        /// </summary>
        [NameInMap("CustomConfigs")]
        [Validation(Required=false)]
        public List<VerifyCheckCustomConfigRequestCustomConfigs> CustomConfigs { get; set; }
        public class VerifyCheckCustomConfigRequestCustomConfigs : TeaModel {
            /// <summary>
            /// <para>The name of the custom configuration item for the check item. The name is unique within the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPList</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The operation type of the custom configuration item for the check item. Set this parameter to DELETE only for deletion operations. You do not need to specify this parameter for creation or update operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DELETE</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The user-configured value string of the custom configuration item for the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.12.4.XX</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The repair parameters supported by the repair feature of the check item.</para>
        /// </summary>
        [NameInMap("RepairConfigs")]
        [Validation(Required=false)]
        public List<VerifyCheckCustomConfigRequestRepairConfigs> RepairConfigs { get; set; }
        public class VerifyCheckCustomConfigRequestRepairConfigs : TeaModel {
            /// <summary>
            /// <para>The ID of the repair flow that corresponds to the repair operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7fec0a3395b345c18f108ffc9fc0****</para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            /// <summary>
            /// <para>The name of the repair parameter for the check item. The name is unique within the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPLists</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The operation type of the custom configuration item for the check item. Set this parameter to DELETE only for deletion operations. You do not need to specify this parameter for creation or update operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DELETE</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The user-configured value string of the repair configuration item for the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.26.49.XX</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The validation type for Threat Detection Service parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>REPAIR_CONFIG</b>: repair and custom parameter validation (default).</description></item>
        /// <item><description><b>CHECK_ITEM_CONFIG</b>: custom check item validation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>REPAIR_CONFIG</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
