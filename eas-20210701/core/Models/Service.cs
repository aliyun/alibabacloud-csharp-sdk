// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class Service : TeaModel {
        /// <summary>
        /// <para>The access token for the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MzJiMDI5MDliODc0MTlkYmI0ZDhlYmExYjczYTIyZTE3Zm********</para>
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>The application configuration for the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ModelStorage&quot;:&quot;oss&quot;}</para>
        /// </summary>
        [NameInMap("AppConfig")]
        [Validation(Required=false)]
        public string AppConfig { get; set; }

        /// <summary>
        /// <para>The application specification name for the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llama_7b_fp16</para>
        /// </summary>
        [NameInMap("AppSpecName")]
        [Validation(Required=false)]
        public string AppSpecName { get; set; }

        /// <summary>
        /// <para>The application type of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LLM</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>The application version of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether auto scaling is enabled for the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoscalerEnabled")]
        [Validation(Required=false)]
        public bool? AutoscalerEnabled { get; set; }

        /// <summary>
        /// <para>The UID of the account that created the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20123*******</para>
        /// </summary>
        [NameInMap("CallerUid")]
        [Validation(Required=false)]
        public string CallerUid { get; set; }

        /// <summary>
        /// <para>The number of CPU cores requested for each instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <para>The time when the service was created, in RFC 3339 format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-29T11:13:20Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether scheduled scaling is enabled for the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CronscalerEnabled")]
        [Validation(Required=false)]
        public bool? CronscalerEnabled { get; set; }

        /// <summary>
        /// <para>The current version of the running model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentVersion")]
        [Validation(Required=false)]
        public int? CurrentVersion { get; set; }

        /// <summary>
        /// <para>Additional information about the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;blue_green_services&quot;:[&quot;test&quot;,&quot;testxxxx&quot;]}</para>
        /// </summary>
        [NameInMap("ExtraData")]
        [Validation(Required=false)]
        public string ExtraData { get; set; }

        /// <summary>
        /// <para>The percentage of GPU computing power requested for each instance when GPU sharing is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("GPUCorePercentage")]
        [Validation(Required=false)]
        public int? GPUCorePercentage { get; set; }

        /// <summary>
        /// <para>The amount of GPU memory requested for each instance when GPU sharing is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("GPUMemory")]
        [Validation(Required=false)]
        public int? GPUMemory { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated gateway for the service. This field is returned only for services that are bound to a dedicated gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-xxxxxx</para>
        /// </summary>
        [NameInMap("Gateway")]
        [Validation(Required=false)]
        public string Gateway { get; set; }

        /// <summary>
        /// <para>The number of GPUs requested for each instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Gpu")]
        [Validation(Required=false)]
        public int? Gpu { get; set; }

        /// <summary>
        /// <para>The image used by the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-shanghai.aliyuncs.com/eas/echo_cn-shanghai:v0.0.1-20210129111320</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>A breakdown of the instance count by resource type.</para>
        /// </summary>
        [NameInMap("InstanceCountInResource")]
        [Validation(Required=false)]
        public ServiceInstanceCountInResource InstanceCountInResource { get; set; }
        public class ServiceInstanceCountInResource : TeaModel {
            /// <summary>
            /// <para>The number of instances that use dedicated or self-managed resource groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Dedicated")]
            [Validation(Required=false)]
            public int? Dedicated { get; set; }

            /// <summary>
            /// <para>The number of instances that use public resource groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Public")]
            [Validation(Required=false)]
            public int? Public { get; set; }

            /// <summary>
            /// <para>The number of instances that use a Lingjun quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Quota")]
            [Validation(Required=false)]
            public int? Quota { get; set; }

        }

        /// <summary>
        /// <para>The internet endpoint of the service. This field is returned only by the <c>DescribeService</c> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://10123*****.cn-shanghai.aliyuncs.com/api/predict/echo">http://10123*****.cn-shanghai.aliyuncs.com/api/predict/echo</a></para>
        /// </summary>
        [NameInMap("InternetEndpoint")]
        [Validation(Required=false)]
        public string InternetEndpoint { get; set; }

        /// <summary>
        /// <para>The intranet endpoint of the service. This field is returned only by the <c>DescribeService</c> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://10123*****.vpc.cn-shanghai.aliyuncs.com/api/predict/echo">http://10123*****.vpc.cn-shanghai.aliyuncs.com/api/predict/echo</a></para>
        /// </summary>
        [NameInMap("IntranetEndpoint")]
        [Validation(Required=false)]
        public string IntranetEndpoint { get; set; }

        /// <summary>
        /// <para>The labels of the service.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<ServiceLabels> Labels { get; set; }
        public class ServiceLabels : TeaModel {
            /// <summary>
            /// <para>The key of the service label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("LabelKey")]
            [Validation(Required=false)]
            public string LabelKey { get; set; }

            /// <summary>
            /// <para>The value of the service label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("LabelValue")]
            [Validation(Required=false)]
            public string LabelValue { get; set; }

        }

        /// <summary>
        /// <para>The latest version of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public int? LatestVersion { get; set; }

        /// <summary>
        /// <para>The amount of memory requested for each instance, in MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>A message that provides information about the service status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Service start successfully</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The namespace where the service is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The UID of the primary account used to create the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11234*******</para>
        /// </summary>
        [NameInMap("ParentUid")]
        [Validation(Required=false)]
        public string ParentUid { get; set; }

        /// <summary>
        /// <para>The number of pending instances for the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PendingInstance")]
        [Validation(Required=false)]
        public int? PendingInstance { get; set; }

        /// <summary>
        /// <para>The quota ID of the service. This field is returned only for services that are deployed on a Lingjun resource quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotaxxxxx</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <para>The reason for the service status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The region where the service is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group to which the service belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-r-xxxxxxx</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// <para>The alias of the resource group to which the service belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_resource</para>
        /// </summary>
        [NameInMap("ResourceAlias")]
        [Validation(Required=false)]
        public string ResourceAlias { get; set; }

        /// <summary>
        /// <para>Indicates whether a burstable resource pool is enabled for the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ResourceBurstable")]
        [Validation(Required=false)]
        public bool? ResourceBurstable { get; set; }

        /// <summary>
        /// <para>The role of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Queue</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>Additional attributes of the service role. This field is returned only by the <c>DescribeService</c> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ApproxMaxLength&quot;:null,&quot;Length&quot;:null,&quot;MaxPayloadBytes&quot;:null}</para>
        /// </summary>
        [NameInMap("RoleAttrs")]
        [Validation(Required=false)]
        public string RoleAttrs { get; set; }

        /// <summary>
        /// <para>The number of running instances of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RunningInstance")]
        [Validation(Required=false)]
        public int? RunningInstance { get; set; }

        /// <summary>
        /// <para>The safety lock status of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dangerous</para>
        /// </summary>
        [NameInMap("SafetyLock")]
        [Validation(Required=false)]
        public string SafetyLock { get; set; }

        /// <summary>
        /// <para>The internet endpoint for synchronous requests to an asynchronous service. This field is returned only by the <c>DescribeService</c> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://10123*****.cn-shanghai.aliyuncs.com/api/predict/async_path.echo">http://10123*****.cn-shanghai.aliyuncs.com/api/predict/async_path.echo</a></para>
        /// </summary>
        [NameInMap("SecondaryInternetEndpoint")]
        [Validation(Required=false)]
        public string SecondaryInternetEndpoint { get; set; }

        /// <summary>
        /// <para>The intranet endpoint for synchronous requests to an asynchronous service. This field is returned only by the <c>DescribeService</c> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://10123*****.vpc.cn-shanghai.aliyuncs.com/api/predict/async_path.echo">http://10123*****.vpc.cn-shanghai.aliyuncs.com/api/predict/async_path.echo</a></para>
        /// </summary>
        [NameInMap("SecondaryIntranetEndpoint")]
        [Validation(Required=false)]
        public string SecondaryIntranetEndpoint { get; set; }

        /// <summary>
        /// <para>The configuration of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;metadata&quot;:{&quot;cpu&quot;:1,&quot;instance&quot;:1,&quot;memory&quot;:1024},&quot;name&quot;:&quot;echo&quot;,&quot;processor_entry&quot;:&quot;libecho.so&quot;,&quot;processor_path&quot;:&quot;<a href="http://oss-cn-hangzhou-zmf.aliyuncs.com/059247/echo_processor_release.tar.gz%22,%22processor_type%22:%22cpp%22%7D">http://oss-cn-hangzhou-zmf.aliyuncs.com/059247/echo_processor_release.tar.gz&quot;,&quot;processor_type&quot;:&quot;cpp&quot;}</a></para>
        /// </summary>
        [NameInMap("ServiceConfig")]
        [Validation(Required=false)]
        public string ServiceConfig { get; set; }

        /// <summary>
        /// <para>The group to which the service belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_group</para>
        /// </summary>
        [NameInMap("ServiceGroup")]
        [Validation(Required=false)]
        public string ServiceGroup { get; set; }

        /// <summary>
        /// <para>The unique ID of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-m-xxasdat</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The name of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The service ID. This value is the same as <c>ServiceId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-m-xxasdat</para>
        /// </summary>
        [NameInMap("ServiceUid")]
        [Validation(Required=false)]
        public string ServiceUid { get; set; }

        /// <summary>
        /// <para>The deployment source of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsw</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The status of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of instances for the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalInstance")]
        [Validation(Required=false)]
        public int? TotalInstance { get; set; }

        /// <summary>
        /// <para>The traffic state of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standalone</para>
        /// </summary>
        [NameInMap("TrafficState")]
        [Validation(Required=false)]
        public string TrafficState { get; set; }

        /// <summary>
        /// <para>The time when the service was last updated, in RFC 3339 format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-29T11:13:20Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The traffic weight for the canary release of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

        [NameInMap("WorkloadType")]
        [Validation(Required=false)]
        public string WorkloadType { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the service belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123445</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
