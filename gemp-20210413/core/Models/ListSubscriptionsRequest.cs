// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListSubscriptionsRequest : TeaModel {
        /// <summary>
        /// 幂等参数
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 通知对象名
        /// </summary>
        [NameInMap("notifyObject")]
        [Validation(Required=false)]
        public string NotifyObject { get; set; }

        /// <summary>
        /// 通知对象类型notifyWhoType:0服务组 1个人
        /// </summary>
        [NameInMap("notifyObjectType")]
        [Validation(Required=false)]
        public string NotifyObjectType { get; set; }

        /// <summary>
        /// 第几页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 一页几条
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 订阅范围类型 0全部1服务2流转规则
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// 订阅范围对象名称
        /// </summary>
        [NameInMap("scopeObject")]
        [Validation(Required=false)]
        public string ScopeObject { get; set; }

        /// <summary>
        /// 通知订阅名
        /// </summary>
        [NameInMap("subscriptionTitle")]
        [Validation(Required=false)]
        public string SubscriptionTitle { get; set; }

    }

}
