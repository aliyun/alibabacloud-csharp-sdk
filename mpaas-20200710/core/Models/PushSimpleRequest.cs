// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class PushSimpleRequest : TeaModel {
        [NameInMap("ActivityContentState")]
        [Validation(Required=false)]
        public object ActivityContentState { get; set; }

        [NameInMap("ActivityEvent")]
        [Validation(Required=false)]
        public string ActivityEvent { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("Classification")]
        [Validation(Required=false)]
        public string Classification { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeliveryType")]
        [Validation(Required=false)]
        public long? DeliveryType { get; set; }

        [NameInMap("DismissalDate")]
        [Validation(Required=false)]
        public long? DismissalDate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ExpiredSeconds")]
        [Validation(Required=false)]
        public long? ExpiredSeconds { get; set; }

        [NameInMap("ExtendedParams")]
        [Validation(Required=false)]
        public string ExtendedParams { get; set; }

        [NameInMap("IconUrls")]
        [Validation(Required=false)]
        public string IconUrls { get; set; }

        [NameInMap("ImageUrls")]
        [Validation(Required=false)]
        public string ImageUrls { get; set; }

        [NameInMap("MiChannelId")]
        [Validation(Required=false)]
        public string MiChannelId { get; set; }

        [NameInMap("NotifyLevel")]
        [Validation(Required=false)]
        public Dictionary<string, object> NotifyLevel { get; set; }

        [NameInMap("NotifyType")]
        [Validation(Required=false)]
        public string NotifyType { get; set; }

        [NameInMap("PushAction")]
        [Validation(Required=false)]
        public long? PushAction { get; set; }

        [NameInMap("PushStyle")]
        [Validation(Required=false)]
        public int? PushStyle { get; set; }

        [NameInMap("Silent")]
        [Validation(Required=false)]
        public long? Silent { get; set; }

        [NameInMap("StrategyContent")]
        [Validation(Required=false)]
        public string StrategyContent { get; set; }

        [NameInMap("StrategyType")]
        [Validation(Required=false)]
        public int? StrategyType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TargetMsgkey")]
        [Validation(Required=false)]
        public string TargetMsgkey { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("ThirdChannelCategory")]
        [Validation(Required=false)]
        public Dictionary<string, object> ThirdChannelCategory { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("TransparentMessagePayload")]
        [Validation(Required=false)]
        public object TransparentMessagePayload { get; set; }

        [NameInMap("TransparentMessageUrgency")]
        [Validation(Required=false)]
        public string TransparentMessageUrgency { get; set; }

        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
