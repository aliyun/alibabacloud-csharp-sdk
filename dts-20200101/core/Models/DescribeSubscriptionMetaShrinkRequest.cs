// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSubscriptionMetaShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the distributed change tracking task.</para>
        /// <remarks>
        /// <para>This parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtsbr4m9luv2******</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The region in which the change tracking instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The consumer group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>z38m91gg2******</para>
        /// </summary>
        [NameInMap("Sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

        /// <summary>
        /// <para>The IDs of all change tracking subtasks in the distributed change tracking task. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para>You must specify at least one of this parameter and <b>Topics</b>. We recommend that you specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;zsls58agp6f****&quot;]</para>
        /// </summary>
        [NameInMap("SubMigrationJobIds")]
        [Validation(Required=false)]
        public string SubMigrationJobIdsShrink { get; set; }

        /// <summary>
        /// <para>All topics of the distributed change tracking task. Separate multiple topics with commas (,).</para>
        /// <remarks>
        /// <para>You must specify at least one of this parameter and <b>SubMigrationJobIds</b>. We recommend that you specify <b>SubMigrationJobIds</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;rm_bp15jj3qi1p8f****&quot;]</para>
        /// </summary>
        [NameInMap("Topics")]
        [Validation(Required=false)]
        public string TopicsShrink { get; set; }

    }

}
