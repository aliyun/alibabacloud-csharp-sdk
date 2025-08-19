// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class Function : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2825179536350****</para>
        /// </summary>
        [NameInMap("codeChecksum")]
        [Validation(Required=false)]
        public string CodeChecksum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>412</para>
        /// </summary>
        [NameInMap("codeSize")]
        [Validation(Required=false)]
        public long? CodeSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-04-01T08:15:27Z</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("customContainerConfig")]
        [Validation(Required=false)]
        public CustomContainerConfig CustomContainerConfig { get; set; }

        [NameInMap("customDNS")]
        [Validation(Required=false)]
        public CustomDNS CustomDNS { get; set; }

        [NameInMap("customRuntimeConfig")]
        [Validation(Required=false)]
        public CustomRuntimeConfig CustomRuntimeConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my function</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("disableOndemand")]
        [Validation(Required=false)]
        public bool? DisableOndemand { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("diskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("enableLongLiving")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? EnableLongLiving { get; set; }

        [NameInMap("environmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:fc:cn-shanghai:123:functions/functionName</para>
        /// </summary>
        [NameInMap("functionArn")]
        [Validation(Required=false)]
        public string FunctionArn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aa715851-1c20-4b89-a8fb-***</para>
        /// </summary>
        [NameInMap("functionId")]
        [Validation(Required=false)]
        public string FunctionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-function-1</para>
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        [NameInMap("gpuConfig")]
        [Validation(Required=false)]
        public GPUConfig GpuConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>index.handler</para>
        /// </summary>
        [NameInMap("handler")]
        [Validation(Required=false)]
        public string Handler { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("instanceConcurrency")]
        [Validation(Required=false)]
        public int? InstanceConcurrency { get; set; }

        [NameInMap("instanceIsolationMode")]
        [Validation(Required=false)]
        public string InstanceIsolationMode { get; set; }

        [NameInMap("instanceLifecycleConfig")]
        [Validation(Required=false)]
        public InstanceLifecycleConfig InstanceLifecycleConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("internetAccess")]
        [Validation(Required=false)]
        public bool? InternetAccess { get; set; }

        [NameInMap("invocationRestriction")]
        [Validation(Required=false)]
        public FunctionRestriction InvocationRestriction { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-05-01T08:15:27Z</para>
        /// </summary>
        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InProgress</para>
        /// </summary>
        [NameInMap("lastUpdateStatus")]
        [Validation(Required=false)]
        public string LastUpdateStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The system is currently processing the acceleration optimization for the image.</para>
        /// </summary>
        [NameInMap("lastUpdateStatusReason")]
        [Validation(Required=false)]
        public string LastUpdateStatusReason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ImageOptimizing</para>
        /// </summary>
        [NameInMap("lastUpdateStatusReasonCode")]
        [Validation(Required=false)]
        public string LastUpdateStatusReasonCode { get; set; }

        [NameInMap("layers")]
        [Validation(Required=false)]
        public List<FunctionLayer> Layers { get; set; }

        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public LogConfig LogConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("memorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        [NameInMap("ossMountConfig")]
        [Validation(Required=false)]
        public OSSMountConfig OssMountConfig { get; set; }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:ram::188077086902****:role/fc-test</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>python3.10</para>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public string Runtime { get; set; }

        [NameInMap("sessionAffinity")]
        [Validation(Required=false)]
        public string SessionAffinity { get; set; }

        [NameInMap("sessionAffinityConfig")]
        [Validation(Required=false)]
        public string SessionAffinityConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Pending</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Function creating</para>
        /// </summary>
        [NameInMap("stateReason")]
        [Validation(Required=false)]
        public string StateReason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Creating</para>
        /// </summary>
        [NameInMap("stateReasonCode")]
        [Validation(Required=false)]
        public string StateReasonCode { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        [NameInMap("tracingConfig")]
        [Validation(Required=false)]
        public TracingConfig TracingConfig { get; set; }

        [NameInMap("vpcConfig")]
        [Validation(Required=false)]
        public VPCConfig VpcConfig { get; set; }

    }

}
