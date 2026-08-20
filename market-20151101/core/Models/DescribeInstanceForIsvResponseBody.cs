// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeInstanceForIsvResponseBody : TeaModel {
        /// <summary>
        /// <para>The activation URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://*****.com</para>
        /// </summary>
        [NameInMap("ActiveAddress")]
        [Validation(Required=false)]
        public string ActiveAddress { get; set; }

        /// <summary>
        /// <para>The application information. The metric description of the parameters in the example is as follows:</para>
        /// <para>username: the username.
        /// passowrd: the password.
        /// frontEndUrl: the frontend URL.
        /// adminUrl: the administration URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;frontEndUrl&quot;:&quot;https://<em><em><b>.aliyundoc.com&quot;,&quot;password&quot;:&quot;Sjtv</b></em>&quot;,&quot;adminUrl&quot;:&quot;https://</em><em><b>.aliyundoc.com&quot;,&quot;username&quot;:&quot;aliyun</b></em>&quot;}</para>
        /// </summary>
        [NameInMap("AppJson")]
        [Validation(Required=false)]
        public string AppJson { get; set; }

        /// <summary>
        /// <para>The automatic payment information for epoch-based products. A non-empty value indicates that you enable auto-renewal.
        /// autoRenewCycle: Day, Month, or Year.
        /// autoRenewDuration: the renewal epoch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;autoRenewCycle&quot;:&quot;Year&quot;,&quot;autoRenewDuration&quot;:1}</para>
        /// </summary>
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
        /// <para>The business module. The metric description of the parameters in the example is as follows:</para>
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
        /// <para>username: the username.
        /// passowrd: the password.
        /// ip: the host IP address.
        /// innerIp: the internal network IP address of the host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;password&quot;:&quot;<em><b>&quot;,&quot;ip&quot;:&quot;118.31.</b></em>.41&quot;,&quot;innerIp&quot;:&quot;118.31.<em><b>.41&quot;,&quot;region&quot;:&quot;&quot;,&quot;username&quot;:&quot;</b></em>&quot;,&quot;beianInfo&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("HostJson")]
        [Validation(Required=false)]
        public string HostJson { get; set; }

        /// <summary>
        /// <para>The image instance information.
        /// imageId: the image ID.
        /// instanceId: the instance ID.
        /// ecsInstanceId: the ECS instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;imageId&quot;:&quot;m-*******&quot;,&quot;instanceId&quot;:********}</para>
        /// </summary>
        [NameInMap("ImageJson")]
        [Validation(Required=false)]
        public string ImageJson { get; set; }

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

        /// <summary>
        /// <para>The activation code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("LicenseCode")]
        [Validation(Required=false)]
        public string LicenseCode { get; set; }

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
        public DescribeInstanceForIsvResponseBodyRelationalData RelationalData { get; set; }
        public class DescribeInstanceForIsvResponseBodyRelationalData : TeaModel {
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EF60BEC-<b><b>-</b></b>-****-270359FB54A7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The business status. Different values are set based on the product type.</para>
        /// <para>When ProductType is set to MIRROR:</para>
        /// <list type="bullet">
        /// <item><description>PRODUCE: being provisioned.</description></item>
        /// <item><description>USING: in use.</description></item>
        /// <item><description>UNUSED: not in use.</description></item>
        /// <item><description>EXPIRED: expired.</description></item>
        /// <item><description>CLOSED: released.</description></item>
        /// </list>
        /// <para>When ProductType is set to SERVICE:</para>
        /// <list type="bullet">
        /// <item><description>READYING: not started.</description></item>
        /// <item><description>STARTED: in service.</description></item>
        /// <item><description>CONFIRM: completed.</description></item>
        /// <item><description>EXPIRED: expired.</description></item>
        /// <item><description>CLOSED: released.</description></item>
        /// </list>
        /// <para>When ProductType is set to APP, DOWNLOAD, API_SERVICE, or DOCKER:</para>
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
