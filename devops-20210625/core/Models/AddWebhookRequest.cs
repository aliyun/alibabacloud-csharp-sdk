// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class AddWebhookRequest : TeaModel {
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// webhook描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 使用ssl认证
        /// </summary>
        [NameInMap("enableSslVerification")]
        [Validation(Required=false)]
        public bool? EnableSslVerification { get; set; }

        /// <summary>
        /// 合并请求事件
        /// </summary>
        [NameInMap("mergeRequestsEvents")]
        [Validation(Required=false)]
        public bool? MergeRequestsEvents { get; set; }

        /// <summary>
        /// 评论事件
        /// </summary>
        [NameInMap("noteEvents")]
        [Validation(Required=false)]
        public bool? NoteEvents { get; set; }

        /// <summary>
        /// 分支推送事件
        /// </summary>
        [NameInMap("pushEvents")]
        [Validation(Required=false)]
        public bool? PushEvents { get; set; }

        [NameInMap("secretToken")]
        [Validation(Required=false)]
        public string SecretToken { get; set; }

        /// <summary>
        /// 标签推送事件
        /// </summary>
        [NameInMap("tagPushEvents")]
        [Validation(Required=false)]
        public bool? TagPushEvents { get; set; }

        /// <summary>
        /// hook url
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
