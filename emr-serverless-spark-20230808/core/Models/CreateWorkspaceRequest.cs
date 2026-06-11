// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. This parameter is required if you set <c>paymentType</c> to <c>Pre</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("autoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration. This parameter is required if <c>autoRenew</c> is set to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("autoRenewPeriod")]
        [Validation(Required=false)]
        public string AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The unit of the auto-renewal duration. This parameter is required if <c>autoRenew</c> is set to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>month</para>
        /// </summary>
        [NameInMap("autoRenewPeriodUnit")]
        [Validation(Required=false)]
        public string AutoRenewPeriodUnit { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically start a session cluster when the workspace is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("autoStartSessionCluster")]
        [Validation(Required=false)]
        public bool? AutoStartSessionCluster { get; set; }

        /// <summary>
        /// <para>A token that ensures the idempotency of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8e6aae2810c8f67229ca70bb31cd****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The DLF Catalog ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123xxxxx</para>
        /// </summary>
        [NameInMap("dlfCatalogId")]
        [Validation(Required=false)]
        public string DlfCatalogId { get; set; }

        /// <summary>
        /// <para>The DLF type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlf1.0</para>
        /// </summary>
        [NameInMap("dlfType")]
        [Validation(Required=false)]
        public string DlfType { get; set; }

        /// <summary>
        /// <para>The subscription duration. This parameter is required if you set <c>paymentType</c> to <c>Pre</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12452</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The specifications for the GPU resources.</para>
        /// </summary>
        [NameInMap("gpuSpec")]
        [Validation(Required=false)]
        public List<string> GpuSpec { get; set; }

        /// <summary>
        /// <para>The OSS bucket for the workspace. The path must be in the <c>oss://&lt;bucket-name&gt;/</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/</para>
        /// </summary>
        [NameInMap("ossBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. This parameter is required if you set <c>paymentType</c> to <c>Pre</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("paymentDurationUnit")]
        [Validation(Required=false)]
        public string PaymentDurationUnit { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PayAsYouGo</c>: pay-as-you-go</para>
        /// </description></item>
        /// <item><description><para><c>Pre</c>: subscription</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The name of the RAM role used to run Spark jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunEMRSparkJobRunDefaultRole</para>
        /// </summary>
        [NameInMap("ramRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The release type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pro</para>
        /// </summary>
        [NameInMap("releaseType")]
        [Validation(Required=false)]
        public string ReleaseType { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmwpi66knkxny</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The resource specifications.</para>
        /// </summary>
        [NameInMap("resourceSpec")]
        [Validation(Required=false)]
        public CreateWorkspaceRequestResourceSpec ResourceSpec { get; set; }
        public class CreateWorkspaceRequestResourceSpec : TeaModel {
            /// <summary>
            /// <para>The resource quota for the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("cu")]
            [Validation(Required=false)]
            public string Cu { get; set; }

            /// <summary>
            /// <para>The GPU resource quota for the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("gpu")]
            [Validation(Required=false)]
            public int? Gpu { get; set; }

        }

        /// <summary>
        /// <para>The tags to add to the workspace.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("tag")]
        [Validation(Required=false)]
        public List<CreateWorkspaceRequestTag> Tag { get; set; }
        public class CreateWorkspaceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The workspace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("workspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
