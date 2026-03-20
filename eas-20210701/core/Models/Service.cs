// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class Service : TeaModel {
        /// <summary>
        /// <para>The token that is used to access the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MzJiMDI5MDliODc0MTlkYmI0ZDhlYmExYjczYTIyZTE3Zm********</para>
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>The application service configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ModelStorage&quot;:&quot;oss&quot;}</para>
        /// </summary>
        [NameInMap("AppConfig")]
        [Validation(Required=false)]
        public string AppConfig { get; set; }

        /// <summary>
        /// <para>The name of the application service specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llama_7b_fp16</para>
        /// </summary>
        [NameInMap("AppSpecName")]
        [Validation(Required=false)]
        public string AppSpecName { get; set; }

        /// <summary>
        /// <para>The application service type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LLM</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>The application service version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        [NameInMap("AutoscalerEnabled")]
        [Validation(Required=false)]
        public bool? AutoscalerEnabled { get; set; }

        /// <summary>
        /// <para>The user ID (UID) of the Alibaba Cloud account that is used to create the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20123*******</para>
        /// </summary>
        [NameInMap("CallerUid")]
        [Validation(Required=false)]
        public string CallerUid { get; set; }

        /// <summary>
        /// <para>The number of CPU cores that you applied for each instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <para>The time when the service was created. The time is displayed in the UTC RFC3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-29T11:13:20Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CronscalerEnabled")]
        [Validation(Required=false)]
        public bool? CronscalerEnabled { get; set; }

        /// <summary>
        /// <para>The version of the model that is running.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentVersion")]
        [Validation(Required=false)]
        public int? CurrentVersion { get; set; }

        /// <summary>
        /// <para>The additional information about the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;blue_green_services\&quot;:[\&quot;test\&quot;,\&quot;testxxxx\&quot;]}</para>
        /// </summary>
        [NameInMap("ExtraData")]
        [Validation(Required=false)]
        public string ExtraData { get; set; }

        [NameInMap("GPUCorePercentage")]
        [Validation(Required=false)]
        public int? GPUCorePercentage { get; set; }

        [NameInMap("GPUMemory")]
        [Validation(Required=false)]
        public int? GPUMemory { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated gateway for the service. This parameter is available only for services that are associated with dedicated gateways.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-xxxxxx</para>
        /// </summary>
        [NameInMap("Gateway")]
        [Validation(Required=false)]
        public string Gateway { get; set; }

        /// <summary>
        /// <para>The number of GPUs that you applied for each instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Gpu")]
        [Validation(Required=false)]
        public int? Gpu { get; set; }

        /// <summary>
        /// <para>The data image of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-shanghai.aliyuncs.com/eas/echo_cn-shanghai:v0.0.1-20210129111320</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("InstanceCountInResource")]
        [Validation(Required=false)]
        public ServiceInstanceCountInResource InstanceCountInResource { get; set; }
        public class ServiceInstanceCountInResource : TeaModel {
            [NameInMap("Dedicated")]
            [Validation(Required=false)]
            public int? Dedicated { get; set; }

            [NameInMap("Public")]
            [Validation(Required=false)]
            public int? Public { get; set; }

            [NameInMap("Quota")]
            [Validation(Required=false)]
            public int? Quota { get; set; }

        }

        /// <summary>
        /// <para>The public endpoint of the service. This parameter is returned only in the DescribeService API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://10123*****.cn-shanghai.aliyuncs.com/api/predict/echo">http://10123*****.cn-shanghai.aliyuncs.com/api/predict/echo</a></para>
        /// </summary>
        [NameInMap("InternetEndpoint")]
        [Validation(Required=false)]
        public string InternetEndpoint { get; set; }

        /// <summary>
        /// <para>The internal endpoint of the service. This parameter is returned only in the DescribeService API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://10123*****.vpc.cn-shanghai.aliyuncs.com/api/predict/echo">http://10123*****.vpc.cn-shanghai.aliyuncs.com/api/predict/echo</a></para>
        /// </summary>
        [NameInMap("IntranetEndpoint")]
        [Validation(Required=false)]
        public string IntranetEndpoint { get; set; }

        /// <summary>
        /// <para>The labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<ServiceLabels> Labels { get; set; }
        public class ServiceLabels : TeaModel {
            /// <summary>
            /// <para>The label key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("LabelKey")]
            [Validation(Required=false)]
            public string LabelKey { get; set; }

            /// <summary>
            /// <para>The label value.</para>
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
        /// <para>The memory size that you applied for each instance. Unit: MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The service summary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Service start successfully</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The namespace in which the service resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account that is used to create the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11234*******</para>
        /// </summary>
        [NameInMap("ParentUid")]
        [Validation(Required=false)]
        public string ParentUid { get; set; }

        /// <summary>
        /// <para>The number of instances for the pending service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PendingInstance")]
        [Validation(Required=false)]
        public int? PendingInstance { get; set; }

        /// <summary>
        /// <para>The quota ID for the service. This parameter is available only for services deployed by using Lingjun resource quotas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotaxxxxx</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <para>The reason for which the service is in the current state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The region in which the service resides.</para>
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

        [NameInMap("ResourceBurstable")]
        [Validation(Required=false)]
        public bool? ResourceBurstable { get; set; }

        /// <summary>
        /// <para>The service role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Queue</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The additional attributes of the service role. This parameter is returned only in the DescribeService API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;ApproxMaxLength\&quot;:null,\&quot;Length\&quot;:null,\&quot;MaxPayloadBytes\&quot;:null}&quot;</para>
        /// </summary>
        [NameInMap("RoleAttrs")]
        [Validation(Required=false)]
        public string RoleAttrs { get; set; }

        /// <summary>
        /// <para>The number of instances for the running service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RunningInstance")]
        [Validation(Required=false)]
        public int? RunningInstance { get; set; }

        /// <summary>
        /// <para>The security lock of the service.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>all: forbids all operations.</description></item>
        /// <item><description>dangerous: forbids the operation of deleting or stopping the service.</description></item>
        /// <item><description>none: forbids no operations.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dangerous</para>
        /// </summary>
        [NameInMap("SafetyLock")]
        [Validation(Required=false)]
        public string SafetyLock { get; set; }

        /// <summary>
        /// <para>The public endpoint that is used in the asynchronization request of the service. This parameter is returned only in the DescribeService API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://10123*****.cn-shanghai.aliyuncs.com/api/predict/async_path.echo">http://10123*****.cn-shanghai.aliyuncs.com/api/predict/async_path.echo</a></para>
        /// </summary>
        [NameInMap("SecondaryInternetEndpoint")]
        [Validation(Required=false)]
        public string SecondaryInternetEndpoint { get; set; }

        /// <summary>
        /// <para>The internal endpoint that is used in the asynchronization request of the service. This parameter is returned only in the DescribeService API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://10123*****.vpc.cn-shanghai.aliyuncs.com/api/predict/async_path.echo">http://10123*****.vpc.cn-shanghai.aliyuncs.com/api/predict/async_path.echo</a></para>
        /// </summary>
        [NameInMap("SecondaryIntranetEndpoint")]
        [Validation(Required=false)]
        public string SecondaryIntranetEndpoint { get; set; }

        /// <summary>
        /// <para>The service configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{        &quot;metadata&quot;: {             &quot;cpu&quot;:1,             &quot;instance&quot;:1,             &quot;memory&quot;:1024           },         &quot;name&quot;:&quot;echo&quot;,         &quot;processor_entry&quot;:&quot;libecho.so&quot;,         &quot;processor_path&quot;:&quot;<a href="http://oss-cn-hangzhou-zmf.aliyuncs.com/059247/echo_processor_release.tar.gz">http://oss-cn-hangzhou-zmf.aliyuncs.com/059247/echo_processor_release.tar.gz</a>&quot;,         &quot;processor_type&quot;:&quot;cpp&quot;     }</para>
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
        /// <para>The service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The service ID. ServiceUid has the same meaning as ServiceId, and the values of the two parameters are the same.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-m-xxasdat</para>
        /// </summary>
        [NameInMap("ServiceUid")]
        [Validation(Required=false)]
        public string ServiceUid { get; set; }

        /// <summary>
        /// <para>The source from which the service deployment request is initiated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsw</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The service status.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating</description></item>
        /// <item><description>Deploying</description></item>
        /// <item><description>Stopped</description></item>
        /// <item><description>Failed</description></item>
        /// <item><description>Updating</description></item>
        /// <item><description>Stopping</description></item>
        /// <item><description>Waiting</description></item>
        /// <item><description>HotUpdate</description></item>
        /// <item><description>Starting</description></item>
        /// <item><description>DeleteFailed</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Scaling</description></item>
        /// <item><description>Pending</description></item>
        /// <item><description>Deleting</description></item>
        /// </list>
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
        /// <para>The traffic state.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standalone: independent traffic.</description></item>
        /// <item><description>grouping: grouped traffic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standalone</para>
        /// </summary>
        [NameInMap("TrafficState")]
        [Validation(Required=false)]
        public string TrafficState { get; set; }

        /// <summary>
        /// <para>The time when the service was updated. The time is displayed in the UTC RFC3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-29T11:13:20Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The weight of the service in canary release.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

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
