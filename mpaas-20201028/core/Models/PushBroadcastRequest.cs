// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class PushBroadcastRequest : TeaModel {
        [NameInMap("AndroidChannel")]
        [Validation(Required=false)]
        public int? AndroidChannel { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("BindPeriod")]
        [Validation(Required=false)]
        public int? BindPeriod { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("Classification")]
        [Validation(Required=false)]
        public string Classification { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DeliveryType")]
        [Validation(Required=false)]
        public long? DeliveryType { get; set; }

        /// <summary>
        /// This parameter is required.
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
        /// This parameter is required.
        /// </summary>
        [NameInMap("Msgkey")]
        [Validation(Required=false)]
        public string Msgkey { get; set; }

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
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("ThirdChannelCategory")]
        [Validation(Required=false)]
        public Dictionary<string, object> ThirdChannelCategory { get; set; }

        [NameInMap("UnBindPeriod")]
        [Validation(Required=false)]
        public long? UnBindPeriod { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
