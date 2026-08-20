// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        [NameInMap("ActiveAddress")]
        [Validation(Required=false)]
        public string ActiveAddress { get; set; }

        /// <summary>
        /// <para>The application information. The metric description of the parameters in the example is as follows:</para>
        /// <list type="bullet">
        /// <item><description>username: the username.</description></item>
        /// <item><description>passowrd: the password.</description></item>
        /// <item><description>frontEndUrl: the frontend URL.</description></item>
        /// <item><description>adminUrl: the management URL.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;frontEndUrl&quot;:&quot;https://<em><em><b>.aliyundoc.com&quot;,&quot;password&quot;:&quot;Sjtv</b></em>&quot;,&quot;adminUrl&quot;:&quot;https://</em><em><b>.aliyundoc.com&quot;,&quot;username&quot;:&quot;aliyun</b></em>&quot;}</para>
        /// </summary>
        [NameInMap("AppJson")]
        [Validation(Required=false)]
        public string AppJson { get; set; }

        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public string AutoRenewal { get; set; }

        /// <summary>
        /// <para>The time when the instance was activated (timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1570634021000</para>
        /// </summary>
        [NameInMap("BeganOn")]
        [Validation(Required=false)]
        public long? BeganOn { get; set; }

        /// <summary>
        /// <para>The business module.</para>
        /// <para>The metric description of the parameters in the example is as follows:</para>
        /// <list type="bullet">
        /// <item><description>package_version: the version.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;package_version&quot;:&quot;yuncode000111&quot;}</para>
        /// </summary>
        [NameInMap("ComponentJson")]
        [Validation(Required=false)]
        public string ComponentJson { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Constraints")]
        [Validation(Required=false)]
        public string Constraints { get; set; }

        /// <summary>
        /// <para>The creation time (timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1570634018000</para>
        /// </summary>
        [NameInMap("CreatedOn")]
        [Validation(Required=false)]
        public long? CreatedOn { get; set; }

        /// <summary>
        /// <para>The expiration time (timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1602259200000</para>
        /// </summary>
        [NameInMap("EndOn")]
        [Validation(Required=false)]
        public long? EndOn { get; set; }

        /// <summary>
        /// <para>The extended information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;说明&quot;: &quot;如有使用问题，请联系...&quot;}</para>
        /// </summary>
        [NameInMap("ExtendJson")]
        [Validation(Required=false)]
        public string ExtendJson { get; set; }

        /// <summary>
        /// <para>The host information. The metric description of the parameters in the example is as follows:</para>
        /// <list type="bullet">
        /// <item><description>username: the username.</description></item>
        /// <item><description>passowrd: the password.</description></item>
        /// <item><description>ip: the host IP address.</description></item>
        /// <item><description>innerIp: the internal network IP address of the host.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;password&quot;:&quot;<em><b>&quot;,&quot;ip&quot;:&quot;118.31.</b></em>.41&quot;,&quot;innerIp&quot;:&quot;118.31.<em><b>.41&quot;,&quot;region&quot;:&quot;&quot;,&quot;username&quot;:&quot;</b></em>&quot;,&quot;beianInfo&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("HostJson")]
        [Validation(Required=false)]
        public string HostJson { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1551111111</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is a trial instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTrial")]
        [Validation(Required=false)]
        public bool? IsTrial { get; set; }

        [NameInMap("LicenseCode")]
        [Validation(Required=false)]
        public string LicenseCode { get; set; }

        [NameInMap("Modules")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyModules Modules { get; set; }
        public class DescribeInstanceResponseBodyModules : TeaModel {
            [NameInMap("Module")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyModulesModule> Module { get; set; }
            public class DescribeInstanceResponseBodyModulesModule : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Properties")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyModulesModuleProperties Properties { get; set; }
                public class DescribeInstanceResponseBodyModulesModuleProperties : TeaModel {
                    [NameInMap("Property")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceResponseBodyModulesModulePropertiesProperty> Property { get; set; }
                    public class DescribeInstanceResponseBodyModulesModulePropertiesProperty : TeaModel {
                        [NameInMap("DisplayUnit")]
                        [Validation(Required=false)]
                        public string DisplayUnit { get; set; }

                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("PropertyValues")]
                        [Validation(Required=false)]
                        public DescribeInstanceResponseBodyModulesModulePropertiesPropertyPropertyValues PropertyValues { get; set; }
                        public class DescribeInstanceResponseBodyModulesModulePropertiesPropertyPropertyValues : TeaModel {
                            [NameInMap("PropertyValue")]
                            [Validation(Required=false)]
                            public List<DescribeInstanceResponseBodyModulesModulePropertiesPropertyPropertyValuesPropertyValue> PropertyValue { get; set; }
                            public class DescribeInstanceResponseBodyModulesModulePropertiesPropertyPropertyValuesPropertyValue : TeaModel {
                                [NameInMap("DisplayName")]
                                [Validation(Required=false)]
                                public string DisplayName { get; set; }

                                [NameInMap("Max")]
                                [Validation(Required=false)]
                                public string Max { get; set; }

                                [NameInMap("Min")]
                                [Validation(Required=false)]
                                public string Min { get; set; }

                                [NameInMap("Remark")]
                                [Validation(Required=false)]
                                public string Remark { get; set; }

                                [NameInMap("Step")]
                                [Validation(Required=false)]
                                public string Step { get; set; }

                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        [NameInMap("ShowType")]
                        [Validation(Required=false)]
                        public string ShowType { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>204211111111111</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The commodity code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cmgj00**11</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The product name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>***协同办公</para>
        /// </summary>
        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <para>The SKU code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cmgj00**11-prepay</para>
        /// </summary>
        [NameInMap("ProductSkuCode")]
        [Validation(Required=false)]
        public string ProductSkuCode { get; set; }

        /// <summary>
        /// <para>The product type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>APP: application.</description></item>
        /// <item><description>SERVIC: service.</description></item>
        /// <item><description>MIRROR: image.</description></item>
        /// <item><description>DOWNLOAD: download.</description></item>
        /// <item><description>API_SERVICE: API.</description></item>
        /// <item><description>DOCKER: Docker.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>APP</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The relational information.</para>
        /// </summary>
        [NameInMap("RelationalData")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyRelationalData RelationalData { get; set; }
        public class DescribeInstanceResponseBodyRelationalData : TeaModel {
            /// <summary>
            /// <para>The service status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>READYING: not started.</description></item>
            /// <item><description>STARTED: in service.</description></item>
            /// <item><description>CONFIRM: completed.</description></item>
            /// <item><description>EXPIRED: expired.</description></item>
            /// <item><description>CLOSED: released.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STARTED</para>
            /// </summary>
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }

        }

        /// <summary>
        /// <para>The business status. The value varies based on the product type.</para>
        /// <para>If ProductType is set to MIRROR:</para>
        /// <list type="bullet">
        /// <item><description>PRODUCE: being provisioned.</description></item>
        /// <item><description>USING: in use.</description></item>
        /// <item><description>UNUSED: not used.</description></item>
        /// <item><description>EXPIRED: expired.</description></item>
        /// <item><description>CLOSED: released.</description></item>
        /// </list>
        /// <para>If ProductType is set to SERVICE:</para>
        /// <list type="bullet">
        /// <item><description>READYING: not started.</description></item>
        /// <item><description>STARTED: in service.</description></item>
        /// <item><description>CONFIRM: completed.</description></item>
        /// <item><description>EXPIRED: expired.</description></item>
        /// <item><description>CLOSED: released.</description></item>
        /// </list>
        /// <para>If ProductType is set to APP, DOWNLOAD, API_SERVICE, or DOCKER:</para>
        /// <list type="bullet">
        /// <item><description>OPENING: being activated.</description></item>
        /// <item><description>OPENED: activated.</description></item>
        /// <item><description>EXPIRED: expired.</description></item>
        /// <item><description>CLOSED: released.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OPENED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The service provider name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>*****有限公司</para>
        /// </summary>
        [NameInMap("SupplierName")]
        [Validation(Required=false)]
        public string SupplierName { get; set; }

    }

}
