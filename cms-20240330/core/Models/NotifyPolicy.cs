// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyPolicy : TeaModel {
        /// <summary>
        /// <para>The creation time, which is a UNIX timestamp string in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710000000000</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Production environment alert notification policy</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the policy is enabled. This field is read-only and is controlled by the Enable or Disable API operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Production environment alert notification policy</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The details of the notification policy sub-entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("notifyStrategy")]
        [Validation(Required=false)]
        public NotifyStrategyDetail NotifyStrategy { get; set; }

        /// <summary>
        /// <para>The details of the response plan sub-entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("responsePlan")]
        [Validation(Required=false)]
        public ResponsePlanDetail ResponsePlan { get; set; }

        /// <summary>
        /// <para>The details of the subscription sub-entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("subscription")]
        [Validation(Required=false)]
        public SubscriptionDetail Subscription { get; set; }

        /// <summary>
        /// <para>The update time, which is a UNIX timestamp string in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710000000000</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04779a183add4f2ca06ab440f16cc580</para>
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
        /// <para>default-cms-xxxx-cn-hangzhou</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
