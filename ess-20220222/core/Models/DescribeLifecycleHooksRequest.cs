// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeLifecycleHooksRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the lifecycle hooks.</para>
        /// <remarks>
        /// <para>Conditionally required: You must specify at least one of LifecycleHookIds or ScalingGroupId when you query lifecycle hooks. If you specify both parameters, LifecycleHookIds takes precedence. If you specify only RegionId without specifying either of the two parameters, a 400 InvalidParameter error is returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("LifecycleHookIds")]
        [Validation(Required=false)]
        public List<string> LifecycleHookIds { get; set; }

        /// <summary>
        /// <para>The name of the lifecycle hook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lifecyclehook****</para>
        /// </summary>
        [NameInMap("LifecycleHookName")]
        [Validation(Required=false)]
        public string LifecycleHookName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number of the instance status list. Pages start from 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: 50.</para>
        /// <para>Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group.</para>
        /// <remarks>
        /// <para>Conditionally required: You must specify at least one of LifecycleHookIds or ScalingGroupId when you query lifecycle hooks. If you specify only RegionId without specifying either of the two parameters, a 400 InvalidParameter error is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp1igpak5ft1flyp****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
