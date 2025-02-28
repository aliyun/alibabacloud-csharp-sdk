// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class GetApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the application.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetApplicationResponseBodyData Data { get; set; }
        public class GetApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>App ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>VVK605ZH00OA4MRT</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The resource tag.</para>
            /// </summary>
            [NameInMap("Checklist")]
            [Validation(Required=false)]
            public List<GetApplicationResponseBodyDataChecklist> Checklist { get; set; }
            public class GetApplicationResponseBodyDataChecklist : TeaModel {
                /// <summary>
                /// <para>The resource tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Create</para>
                /// </summary>
                [NameInMap("Lifecycle")]
                [Validation(Required=false)]
                public string Lifecycle { get; set; }

                /// <summary>
                /// <para>The region in which the instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The message returned for verification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The ID of the region.</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The service code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("ResourceCode")]
                [Validation(Required=false)]
                public string ResourceCode { get; set; }

                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The verification result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Finish</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <para>The resource specifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.0/16</para>
                /// </summary>
                [NameInMap("Specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

            }

            [NameInMap("ComplianceList")]
            [Validation(Required=false)]
            public List<GetApplicationResponseBodyDataComplianceList> ComplianceList { get; set; }
            public class GetApplicationResponseBodyDataComplianceList : TeaModel {
                [NameInMap("ResourceCode")]
                [Validation(Required=false)]
                public string ResourceCode { get; set; }

                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<GetApplicationResponseBodyDataComplianceListRules> Rules { get; set; }
                public class GetApplicationResponseBodyDataComplianceListRules : TeaModel {
                    [NameInMap("ruleDetail")]
                    [Validation(Required=false)]
                    public string RuleDetail { get; set; }

                    [NameInMap("ruleId")]
                    [Validation(Required=false)]
                    public string RuleId { get; set; }

                }

            }

            /// <summary>
            /// <para>The time when the app was created</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-09 14:37:16</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DeployPercent")]
            [Validation(Required=false)]
            public double? DeployPercent { get; set; }

            /// <summary>
            /// <para>Application description</para>
            /// 
            /// <b>Example:</b>
            /// <para>remark</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>The URL of the image in the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The details of the application.</para>
            /// </summary>
            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public string ImageURL { get; set; }

            /// <summary>
            /// <para>App name</para>
            /// 
            /// <b>Example:</b>
            /// <para>1411182597819805/sr-8DWU4RUS49NIDII0.png</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The billing results.</para>
            /// </summary>
            [NameInMap("PriceList")]
            [Validation(Required=false)]
            public List<GetApplicationResponseBodyDataPriceList> PriceList { get; set; }
            public class GetApplicationResponseBodyDataPriceList : TeaModel {
                /// <summary>
                /// <para>The billing method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PayAsYouGo</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The quantity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>Resource Fill Labels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Create</para>
                /// </summary>
                [NameInMap("Lifecycle")]
                [Validation(Required=false)]
                public string Lifecycle { get; set; }

                /// <summary>
                /// <para>The unit price of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.01</para>
                /// </summary>
                [NameInMap("OnePrice")]
                [Validation(Required=false)]
                public double? OnePrice { get; set; }

                /// <summary>
                /// <para>The original price of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.570</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public double? OriginalPrice { get; set; }

                /// <summary>
                /// <para>The service duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public int? Period { get; set; }

                /// <summary>
                /// <para>The total price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.01</para>
                /// </summary>
                [NameInMap("Price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                /// <summary>
                /// <para>Unit: USD per hour</para>
                /// 
                /// <b>Example:</b>
                /// <para>The service duration.</para>
                /// </summary>
                [NameInMap("PriceUnit")]
                [Validation(Required=false)]
                public string PriceUnit { get; set; }

                /// <summary>
                /// <para>The region in which the instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The error message that is returned when a price query fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.e3.large</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>Product code</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("ResourceCode")]
                [Validation(Required=false)]
                public string ResourceCode { get; set; }

                /// <summary>
                /// <para>The instance type. This parameter indicates the information about the instance type. For example, 192.168.0.0/16 may be returned for a Virtual Private Cloud (VPC) instance, ecs.g5.large may be returned for an Elastic Compute Service (ECS) instance, and slb.s1.small may be returned for a Server Load Balancer (SLB) instance. If the resource does not have a specific type, an empty value is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The billing method.</para>
                /// </summary>
                [NameInMap("Specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

                /// <summary>
                /// <para>The creation mode. Valid values:\
                /// 1: creates a new instance.\
                /// 2: imports an instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The ID of the resource group to which the app belongs</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzhfgmw4e6fwq</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The resource specification.</para>
            /// </summary>
            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public List<GetApplicationResponseBodyDataResourceList> ResourceList { get; set; }
            public class GetApplicationResponseBodyDataResourceList : TeaModel {
                /// <summary>
                /// <para>The billing method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PayAsYouGo</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The resource tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Create</para>
                /// </summary>
                [NameInMap("Lifecycle")]
                [Validation(Required=false)]
                public string Lifecycle { get; set; }

                [NameInMap("NodeLabel")]
                [Validation(Required=false)]
                public string NodeLabel { get; set; }

                /// <summary>
                /// <para>The deployment result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;hostName&quot;:&quot;iZ2zehnzxqixu1pywsfbx1Z&quot;,&quot;memory&quot;:32768.0,&quot;creationTime&quot;:&quot;2021-09-28T11:23:46Z&quot;,&quot;instanceName&quot;:&quot;ecs&quot;,&quot;internetMaxBandwidthOut&quot;:0.0,&quot;description&quot;:&quot;&quot;,&quot;clusterId&quot;:&quot;&quot;,&quot;private_ip&quot;:&quot;192.168.0.247&quot;,&quot;instanceId&quot;:&quot;i-2zehnzxqixu1pywsfbx1&quot;,&quot;requestId&quot;:&quot;F1C64344-3723-51A0-855B-5F08B5634323&quot;,&quot;zoneId&quot;:&quot;cn-beijing-b&quot;,&quot;ioOptimized&quot;:&quot;optimized&quot;,&quot;id&quot;:&quot;i-2zehnzxqixu1pywsfbx1&quot;,&quot;instanceNetworkType&quot;:&quot;vpc&quot;,&quot;instanceChargeType&quot;:&quot;PostPaid&quot;,&quot;imageId&quot;:&quot;centos_8_4_x64_20G_alibase_20210824.vhd&quot;,&quot;serialNumber&quot;:&quot;cee246c4-38f3-4bf3-950b-c17e88ff6527&quot;,&quot;vlanId&quot;:&quot;&quot;,&quot;instanceType&quot;:&quot;ecs.e3.large&quot;,&quot;cpu&quot;:4.0,&quot;creditSpecification&quot;:&quot;&quot;,&quot;internetMaxBandwidthIn&quot;:-1.0,&quot;expiredTime&quot;:&quot;2099-12-31T15:59Z&quot;,&quot;internetChargeType&quot;:&quot;PayByTraffic&quot;,&quot;regionId&quot;:&quot;cn-beijing&quot;,&quot;refId&quot;:&quot;79224644_0&quot;,&quot;stoppedMode&quot;:&quot;Not-applicable&quot;,&quot;status&quot;:&quot;Running&quot;}</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The service code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("ResourceCode")]
                [Validation(Required=false)]
                public string ResourceCode { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-2zehnzxqixu1pywsfbx1</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The type of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The resource deployment result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Finish</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>Verification passed</para>
            /// 
            /// <b>Example:</b>
            /// <para>Deployed_Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the template associated with the application</para>
            /// 
            /// <b>Example:</b>
            /// <para>FYS9VZ535U20V7HT</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <para>Reason for the request failure</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>A07FFDF2-78FA-1B48-9E38-88E833A93187</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
