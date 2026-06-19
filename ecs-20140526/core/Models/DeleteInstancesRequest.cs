// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeleteInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request.</para>
        /// <list type="bullet">
        /// <item><description>true: sends a check request without querying resource status. The check items include whether your AccessKey pair is valid, whether Resource Access Management (RAM) user authorization is granted, and whether the required parameters are specified. If the check fails, the corresponding error is returned. If the check succeeds, the DRYRUN.SUCCESS error code is returned.</description></item>
        /// <item><description>false: sends a Normal request. After the check succeeds, a 2xx HTTP status code is returned and the resource status is queried directly.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully release an instance that is in the <b>Running</b> (<c>Running</c>) state.</para>
        /// <list type="bullet">
        /// <item><description>true: forcefully releases ECS instance that is in the <b>Running</b> (<c>Running</c>) state.</description></item>
        /// <item><description>false: releases ECS instance only when it is in the <b>Stopped</b> (<c>Stopped</c>) state.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>Warning: Forceful release is equivalent to powering off ECS instance. All in-memory data and temporary data in the storage are erased and cannot be recovered..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully shut down the instance before release when the instance is in the <b>Running</b> (<c>Running</c>) state. This parameter takes effect only when <c>Force=true</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: forcefully shuts down and releases the instance. This is equivalent to a power-off operation. The instance directly enters the resource release process.<remarks>
        /// <para>Warning: Forceful release is equivalent to powering off the instance. All in-memory data and temporary data in the storage are erased and cannot be recovered.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>false: performs a standard shutdown before releasing the instance. This mode causes the release process to take several minutes. You can configure service draining actions during the operating system shutdown to reduce noise in your business systems.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceStop")]
        [Validation(Required=false)]
        public bool? ForceStop { get; set; }

        /// <summary>
        /// <para>The instance ID array. Array length: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1g6zv0ce8oghu7****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the instances. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to release an expired subscription instance.</para>
        /// <list type="bullet">
        /// <item><description>true: releases the instance.</description></item>
        /// <item><description>false: does not release the instance.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TerminateSubscription")]
        [Validation(Required=false)]
        public bool? TerminateSubscription { get; set; }

    }

}
