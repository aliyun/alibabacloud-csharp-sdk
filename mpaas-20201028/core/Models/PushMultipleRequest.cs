// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class PushMultipleRequest : TeaModel {
        [NameInMap("ActivityContentState")]
        [Validation(Required=false)]
        public object ActivityContentState { get; set; }

        [NameInMap("ActivityEvent")]
        [Validation(Required=false)]
        public string ActivityEvent { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("Classification")]
        [Validation(Required=false)]
        public string Classification { get; set; }

        [NameInMap("DeliveryType")]
        [Validation(Required=false)]
        public long? DeliveryType { get; set; }

        [NameInMap("DismissalDate")]
        [Validation(Required=false)]
        public long? DismissalDate { get; set; }

        [NameInMap("ExpiredSeconds")]
        [Validation(Required=false)]
        public long? ExpiredSeconds { get; set; }

        [NameInMap("ExtendedParams")]
        [Validation(Required=false)]
        public string ExtendedParams { get; set; }

        [NameInMap("MiChannelId")]
        [Validation(Required=false)]
        public string MiChannelId { get; set; }

        [NameInMap("NotifyType")]
        [Validation(Required=false)]
        public string NotifyType { get; set; }

        [NameInMap("PushAction")]
        [Validation(Required=false)]
        public long? PushAction { get; set; }

        [NameInMap("Silent")]
        [Validation(Required=false)]
        public long? Silent { get; set; }

        [NameInMap("StrategyContent")]
        [Validation(Required=false)]
        public string StrategyContent { get; set; }

        [NameInMap("StrategyType")]
        [Validation(Required=false)]
        public int? StrategyType { get; set; }

        [NameInMap("TargetMsg")]
        [Validation(Required=false)]
        public List<PushMultipleRequestTargetMsg> TargetMsg { get; set; }
        public class PushMultipleRequestTargetMsg : TeaModel {
            [NameInMap("ExtendedParams")]
            [Validation(Required=false)]
            public string ExtendedParams { get; set; }

            [NameInMap("MsgKey")]
            [Validation(Required=false)]
            public string MsgKey { get; set; }

            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            [NameInMap("TemplateKeyValue")]
            [Validation(Required=false)]
            public string TemplateKeyValue { get; set; }

        }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("ThirdChannelCategory")]
        [Validation(Required=false)]
        public Dictionary<string, object> ThirdChannelCategory { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
