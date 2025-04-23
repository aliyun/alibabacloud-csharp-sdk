// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SubmitServerlessJobShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the array job.</para>
        /// <remarks>
        /// <para> The value of an array job index is passed to a serverless job container through the environment variable <c>EHPC_ARRAY_TASK_ID</c>. Users can access the container from business programs.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ArrayProperties")]
        [Validation(Required=false)]
        public string ArrayPropertiesShrink { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The properties of the Serverless job container.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Container")]
        [Validation(Required=false)]
        public string ContainerShrink { get; set; }

        /// <summary>
        /// <para>The vCPU size of the serverless job container. Unit: cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The dependencies of the serverless job.</para>
        /// </summary>
        [NameInMap("DependsOn")]
        [Validation(Required=false)]
        public string DependsOnShrink { get; set; }

        /// <summary>
        /// <para>The size of the temporary storage space added to the serverless job container. Unit: GiB.</para>
        /// <remarks>
        /// <para> By default, a space of 30 GiB is provided free of charge. If you require a larger space, you can pass this parameter to specify your required space size.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("EphemeralStorage")]
        [Validation(Required=false)]
        public int? EphemeralStorage { get; set; }

        /// <summary>
        /// <para>The Elastic Compute Service (ECS) instance types used by the serverless job container.</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceTypeShrink { get; set; }

        /// <summary>
        /// <para>The name of the serverless job.</para>
        /// <remarks>
        /// <para> The name can contain lowercase letters, digits, and hyphens (-). It cannot start or end with a hyphen.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testjob</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The scheduling priority of the serverless job. Valid values: 0 to 999. A greater value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("JobPriority")]
        [Validation(Required=false)]
        public long? JobPriority { get; set; }

        /// <summary>
        /// <para>The memory size of the serverless job container. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// <para>The Resource Access Manamement (RAM) role that is associated with the Serverless job container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRamRoleName</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The retry policy of the serverless job.</para>
        /// </summary>
        [NameInMap("RetryStrategy")]
        [Validation(Required=false)]
        public string RetryStrategyShrink { get; set; }

        /// <summary>
        /// <para>The maximum hourly price of the preemptible elastic container instance. The value can be accurate to three decimal places.</para>
        /// <para>If you set SpotStrategy to SpotWithPriceLimit, you must specify the SpotPriceLimit parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.062</para>
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The bidding policy of the ECS instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The instance is created as a pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: The instance is created as a preemptible instance for which you specify the maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The instance is created as a preemptible instance for which the market price at the time of purchase is automatically used as the bid price.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SpotWithPriceLimit</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The validity period of the serverless job. After the validity period expires, the job is forcibly terminated. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// <para>The IDs of the vSwitches to which the serverless job container belongs.</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchIdShrink { get; set; }

    }

}
