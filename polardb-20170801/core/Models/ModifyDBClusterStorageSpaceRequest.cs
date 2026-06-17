// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterStorageSpaceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically use a coupon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c> (default): A coupon is automatically used.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: A coupon is not used.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>A client-generated token that ensures the idempotence of the request. The token must be unique for each request, case-sensitive, and a maximum of 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f54a343f1a4233c1e7d1c5c******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies the cloud provider of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENS</para>
        /// </summary>
        [NameInMap("CloudProvider")]
        [Validation(Required=false)]
        public string CloudProvider { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies the latest time to start the scheduled task. Specify the time in UTC in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The latest start time must be at least 30 minutes later than the earliest start time.</para>
        /// </description></item>
        /// <item><description><para>If you specify <c>PlannedStartTime</c> but not this parameter, the latest start time is <c>PlannedStartTime + 30 minutes</c> by default. For example, if you set <c>PlannedStartTime</c> to <c>2021-01-14T09:00:00Z</c> and leave this parameter empty, the task starts no later than <c>2021-01-14T09:30:00Z</c>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-14T09:30:00Z</para>
        /// </summary>
        [NameInMap("PlannedEndTime")]
        [Validation(Required=false)]
        public string PlannedEndTime { get; set; }

        /// <summary>
        /// <para>Specifies the earliest time to start the scheduled task. Specify the time in UTC in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only when <c>ModifyType</c> is set to <c>Upgrade</c>.</para>
        /// </description></item>
        /// <item><description><para>The start time can be a point in time within the next 24 hours. For example, if the current time is <c>2021-01-14T09:00:00Z</c>, you can set the start time to a value that is between <c>2021-01-14T09:00:00Z</c> and <c>2021-01-15T09:00:00Z</c>.</para>
        /// </description></item>
        /// <item><description><para>If you leave this parameter empty, the task runs immediately.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-14T09:00:00Z</para>
        /// </summary>
        [NameInMap("PlannedStartTime")]
        [Validation(Required=false)]
        public string PlannedStartTime { get; set; }

        /// <summary>
        /// <para>Specifies the promotion code. If you do not specify this parameter, the system uses the default coupon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>727xxxxxx934</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies the new storage space. Unit: GB.</para>
        /// <remarks>
        /// <para>For PolarDB for MySQL Standard Edition clusters, the storage space must be between 20 GB and 32,000 GB.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public long? StorageSpace { get; set; }

        /// <summary>
        /// <para>Specifies the subcategory of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>normal_exclusive</b>: dedicated</para>
        /// </description></item>
        /// <item><description><para><b>normal_general</b>: general-purpose</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal_general</para>
        /// </summary>
        [NameInMap("SubCategory")]
        [Validation(Required=false)]
        public string SubCategory { get; set; }

    }

}
