// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class CreateUnionTaskShrinkRequest : TeaModel {
        [NameInMap("AnchorId")]
        [Validation(Required=false)]
        public string AnchorId { get; set; }

        [NameInMap("BrandUserId")]
        [Validation(Required=false)]
        public long? BrandUserId { get; set; }

        [NameInMap("BrandUserNick")]
        [Validation(Required=false)]
        public string BrandUserNick { get; set; }

        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ContentId")]
        [Validation(Required=false)]
        public long? ContentId { get; set; }

        [NameInMap("ContentUrl")]
        [Validation(Required=false)]
        public string ContentUrl { get; set; }

        [NameInMap("CustomCreativeType")]
        [Validation(Required=false)]
        public string CustomCreativeType { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("IndustryLabelBagId")]
        [Validation(Required=false)]
        public int? IndustryLabelBagId { get; set; }

        [NameInMap("MediaIdBlackList")]
        [Validation(Required=false)]
        public string MediaIdBlackListShrink { get; set; }

        [NameInMap("MediaIdWhiteList")]
        [Validation(Required=false)]
        public string MediaIdWhiteListShrink { get; set; }

        [NameInMap("MediaIndustry")]
        [Validation(Required=false)]
        public string MediaIndustry { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ProxyUserId")]
        [Validation(Required=false)]
        public long? ProxyUserId { get; set; }

        [NameInMap("Quota")]
        [Validation(Required=false)]
        public long? Quota { get; set; }

        [NameInMap("QuotaDay")]
        [Validation(Required=false)]
        public long? QuotaDay { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TaskBizType")]
        [Validation(Required=false)]
        public string TaskBizType { get; set; }

        [NameInMap("TaskRuleType")]
        [Validation(Required=false)]
        public string TaskRuleType { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
