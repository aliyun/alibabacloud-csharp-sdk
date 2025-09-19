// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class VerifyCheckCustomConfigRequest : TeaModel {
        /// <summary>
        /// <para>Check item ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>Custom check item to validate input parameters.</para>
        /// </summary>
        [NameInMap("CustomCheckConfig")]
        [Validation(Required=false)]
        public VerifyCheckCustomConfigRequestCustomCheckConfig CustomCheckConfig { get; set; }
        public class VerifyCheckCustomConfigRequestCustomCheckConfig : TeaModel {
            /// <summary>
            /// <para>Define rules for custom inspection items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;AssociatedData&quot;:{&quot;ToDataList&quot;:[{&quot;DataName&quot;:&quot;ACS_ECS_Instance&quot;,&quot;PropertyPath&quot;:&quot;InstanceId&quot;,&quot;FromPropertyPath&quot;:&quot;InstanceId&quot;}]},&quot;MatchProperty&quot;:{&quot;Operator&quot;:&quot;AND&quot;,&quot;MatchProperties&quot;:[{&quot;DataName&quot;:&quot;ACS_ECS_Disk&quot;,&quot;PropertyPath&quot;:&quot;DiskId&quot;,&quot;MatchOperator&quot;:&quot;EQ&quot;,&quot;MatchPropertyValue&quot;:&quot;testId&quot;}]}}</para>
            /// </summary>
            [NameInMap("CheckRule")]
            [Validation(Required=false)]
            public string CheckRule { get; set; }

            /// <summary>
            /// <para>Asset instance that requires testing rules</para>
            /// </summary>
            [NameInMap("CloudAssetInstance")]
            [Validation(Required=false)]
            public VerifyCheckCustomConfigRequestCustomCheckConfigCloudAssetInstance CloudAssetInstance { get; set; }
            public class VerifyCheckCustomConfigRequestCustomCheckConfigCloudAssetInstance : TeaModel {
                /// <summary>
                /// <para>Instance ID of the asset.</para>
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
            /// <para>Asset subtype of the cloud product</para>
            /// 
            /// <b>Example:</b>
            /// <para>DISK</para>
            /// </summary>
            [NameInMap("InstanceSubType")]
            [Validation(Required=false)]
            public string InstanceSubType { get; set; }

            /// <summary>
            /// <para>Asset types of cloud products. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>ECS</b>: Elastic Compute Service </description></item>
            /// <item><description><b>SLB</b>: Server Load Balancer </description></item>
            /// <item><description><b>RDS</b>: Relational Database Service </description></item>
            /// <item><description><b>MONGODB</b>: MongoDB Database </description></item>
            /// <item><description><b>KVSTORE</b>: Redis Database </description></item>
            /// <item><description><b>ACR</b>: Container Registry </description></item>
            /// <item><description><b>CSK</b>: CSK </description></item>
            /// <item><description><b>VPC</b>: Virtual Private Cloud </description></item>
            /// <item><description><b>ACTIONTRAIL</b>: Action Trail </description></item>
            /// <item><description><b>CDN</b>: Content Delivery Network </description></item>
            /// <item><description><b>CAS</b>: Digital Certificate Management Service [formerly SSL Certificates] </description></item>
            /// <item><description><b>RDC</b>: DevOps </description></item>
            /// <item><description><b>RAM</b>: Resource Access Management </description></item>
            /// <item><description><b>DDOS</b>: Distributed Denial of Service </description></item>
            /// <item><description><b>WAF</b>: Web Application Firewall </description></item>
            /// <item><description><b>OSS</b>: Object Storage Service </description></item>
            /// <item><description><b>POLARDB</b>: POLARDB </description></item>
            /// <item><description><b>POSTGRESQL</b>: PostgreSQL </description></item>
            /// <item><description><b>MSE</b>: MSE </description></item>
            /// <item><description><b>NAS</b>: Network Attached Storage </description></item>
            /// <item><description><b>SDDP</b>: Sensitive Data Discovery and Protection </description></item>
            /// <item><description><b>EIP</b>: Elastic IP</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>Cloud asset vendor. Values: </para>
            /// <list type="bullet">
            /// <item><description><b>ALIYUN</b>: Alibaba Cloud </description></item>
            /// <item><description><b>Tencent</b>: Tencent Cloud </description></item>
            /// <item><description><b>HUAWEICLOUD</b>: Huawei Cloud </description></item>
            /// <item><description><b>Azure</b>: Microsoft </description></item>
            /// <item><description><b>AWS</b>: Amazon Web Services (AWS)</description></item>
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
        /// <para>List of custom configuration items for the check item.</para>
        /// </summary>
        [NameInMap("CustomConfigs")]
        [Validation(Required=false)]
        public List<VerifyCheckCustomConfigRequestCustomConfigs> CustomConfigs { get; set; }
        public class VerifyCheckCustomConfigRequestCustomConfigs : TeaModel {
            /// <summary>
            /// <para>Name of the custom configuration item for the check item, unique within the same check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPList</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Operation type for the custom configuration item of the check item. Only pass DELETE when deleting; no need to pass for creation or update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DELETE</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>User-configured value string for the custom configuration item of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.12.4.XX</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Repair parameters supported by the check item\&quot;s repair function.</para>
        /// </summary>
        [NameInMap("RepairConfigs")]
        [Validation(Required=false)]
        public List<VerifyCheckCustomConfigRequestRepairConfigs> RepairConfigs { get; set; }
        public class VerifyCheckCustomConfigRequestRepairConfigs : TeaModel {
            /// <summary>
            /// <para>ID of the repair process during the repair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7fec0a3395b345c18f108ffc9fc0****</para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            /// <summary>
            /// <para>Name of the repair parameter for the check item, unique within the same check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPLists</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Operation type for the custom configuration item of the check item. Only pass DELETE when deleting; no need to pass for creation or update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DELETE</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>User-configured value string for the repair parameter of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.26.49.XX</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Situation Awareness parameter validation types: </para>
        /// <list type="bullet">
        /// <item><description><b>REPAIR_CONFIG</b>: Repair and custom parameter validation (default) </description></item>
        /// <item><description><b>CHECK_ITEM_CONFIG</b>: Custom check item validation</description></item>
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
