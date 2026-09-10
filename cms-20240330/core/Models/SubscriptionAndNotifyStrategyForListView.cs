// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SubscriptionAndNotifyStrategyForListView : TeaModel {
        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700000000</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the policy is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The migration batch ID. This field is empty for user-created entries and has a value for migration artifacts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-id-001</para>
        /// </summary>
        [NameInMap("migrationBatchId")]
        [Validation(Required=false)]
        public string MigrationBatchId { get; set; }

        /// <summary>
        /// <para>The migration metadata JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
        /// </summary>
        [NameInMap("migrationMeta")]
        [Validation(Required=false)]
        public string MigrationMeta { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The notification policy snapshot.</para>
        /// </summary>
        [NameInMap("notifyStrategy")]
        [Validation(Required=false)]
        public NotifyStrategyForSNSView NotifyStrategy { get; set; }

        /// <summary>
        /// <para>The UUID of the associated notifyStrategy, which is shared with the responsePlan UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-id-001</para>
        /// </summary>
        [NameInMap("notifyStrategyUuid")]
        [Validation(Required=false)]
        public string NotifyStrategyUuid { get; set; }

        /// <summary>
        /// <para>The UUID of the directly bound primary subscription, which has a 1:1 association in the NOTIFY mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-id-001</para>
        /// </summary>
        [NameInMap("subscriptionUuid")]
        [Validation(Required=false)]
        public string SubscriptionUuid { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700000000</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The user ID of the owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-id-001</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The UUID of the aggregate entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-id-001</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The optimistic lock version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

        /// <summary>
        /// <para>The workspace identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
