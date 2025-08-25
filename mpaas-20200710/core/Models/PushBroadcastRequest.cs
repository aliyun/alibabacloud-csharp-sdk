// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class PushBroadcastRequest : TeaModel {
        [NameInMap("AndroidChannel")]
        [Validation(Required=false)]
        public long? AndroidChannel { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("BindEndTime")]
        [Validation(Required=false)]
        public long? BindEndTime { get; set; }

        [NameInMap("BindStartTime")]
        [Validation(Required=false)]
        public long? BindStartTime { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("Classification")]
        [Validation(Required=false)]
        public string Classification { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeliveryType")]
        [Validation(Required=false)]
        public long? DeliveryType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ExpiredSeconds")]
        [Validation(Required=false)]
        public long? ExpiredSeconds { get; set; }

        [NameInMap("ExtendedParams")]
        [Validation(Required=false)]
        public string ExtendedParams { get; set; }

        [NameInMap("MiChannelId")]
        [Validation(Required=false)]
        public string MiChannelId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Msgkey")]
        [Validation(Required=false)]
        public string Msgkey { get; set; }

        [NameInMap("NotifyLevel")]
        [Validation(Required=false)]
        public Dictionary<string, object> NotifyLevel { get; set; }

        [NameInMap("NotifyType")]
        [Validation(Required=false)]
        public string NotifyType { get; set; }

        [NameInMap("PushAction")]
        [Validation(Required=false)]
        public long? PushAction { get; set; }

        [NameInMap("PushStatus")]
        [Validation(Required=false)]
        public long? PushStatus { get; set; }

        [NameInMap("Silent")]
        [Validation(Required=false)]
        public long? Silent { get; set; }

        [NameInMap("StrategyContent")]
        [Validation(Required=false)]
        public string StrategyContent { get; set; }

        [NameInMap("StrategyType")]
        [Validation(Required=false)]
        public int? StrategyType { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        [NameInMap("TemplateKeyValue")]
        [Validation(Required=false)]
        public string TemplateKeyValue { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("ThirdChannelCategory")]
        [Validation(Required=false)]
        public Dictionary<string, object> ThirdChannelCategory { get; set; }

        [NameInMap("TimeMode")]
        [Validation(Required=false)]
        public int? TimeMode { get; set; }

        [NameInMap("TransparentMessagePayload")]
        [Validation(Required=false)]
        public object TransparentMessagePayload { get; set; }

        [NameInMap("TransparentMessageUrgency")]
        [Validation(Required=false)]
        public string TransparentMessageUrgency { get; set; }

        [NameInMap("UnBindEndTime")]
        [Validation(Required=false)]
        public long? UnBindEndTime { get; set; }

        [NameInMap("UnBindPeriod")]
        [Validation(Required=false)]
        public long? UnBindPeriod { get; set; }

        [NameInMap("UnBindStartTime")]
        [Validation(Required=false)]
        public long? UnBindStartTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
