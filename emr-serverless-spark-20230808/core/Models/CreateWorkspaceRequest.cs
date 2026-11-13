// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. This parameter is required when the paymentType parameter is set to Pre.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("autoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal period. This parameter is required when the paymentType parameter is set to Pre.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("autoRenewPeriod")]
        [Validation(Required=false)]
        public string AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The auto-renewal epoch. This parameter is required when the paymentType parameter is set to Pre.</para>
        /// 
        /// <b>Example:</b>
        /// <para>month</para>
        /// </summary>
        [NameInMap("autoRenewPeriodUnit")]
        [Validation(Required=false)]
        public string AutoRenewPeriodUnit { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically start a session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("autoStartSessionCluster")]
        [Validation(Required=false)]
        public bool? AutoStartSessionCluster { get; set; }

        /// <summary>
        /// <para>The client token for idempotence verification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8e6aae2810c8f67229ca70bb31cd****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The DLF catalog information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123xxxxx</para>
        /// </summary>
        [NameInMap("dlfCatalogId")]
        [Validation(Required=false)]
        public string DlfCatalogId { get; set; }

        /// <summary>
        /// <para>The DLF binding type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlf1.0</para>
        /// </summary>
        [NameInMap("dlfType")]
        [Validation(Required=false)]
        public string DlfType { get; set; }

        /// <summary>
        /// <para>The number of subscription periods. This parameter is required when the paymentType parameter is set to Pre.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12452</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The list of GPU instance types.</para>
        /// </summary>
        [NameInMap("gpuSpec")]
        [Validation(Required=false)]
        public List<string> GpuSpec { get; set; }

        /// <summary>
        /// <para>The OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/</para>
        /// </summary>
        [NameInMap("ossBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        /// <summary>
        /// <para>The subscription period unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("paymentDurationUnit")]
        [Validation(Required=false)]
        public string PaymentDurationUnit { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayAsYouGo: pay-as-you-go</description></item>
        /// <item><description>Pre: subscription</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The name of the RAM role used to execute Spark jobs.</para>
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
        /// <para>The ID of the resource group.</para>
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
            /// <para>The resource limit of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("cu")]
            [Validation(Required=false)]
            public string Cu { get; set; }

            /// <summary>
            /// <para>The number of GPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("gpu")]
            [Validation(Required=false)]
            public int? Gpu { get; set; }

        }

        /// <summary>
        /// <para>The list of tags.</para>
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
        /// <para>The name of the workspace.</para>
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
