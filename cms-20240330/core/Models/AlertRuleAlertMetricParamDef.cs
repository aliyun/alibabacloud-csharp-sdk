// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleAlertMetricParamDef : TeaModel {
        [NameInMap("maxWidth")]
        [Validation(Required=false)]
        public int? MaxWidth { get; set; }

        [NameInMap("minWidth")]
        [Validation(Required=false)]
        public int? MinWidth { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("placeholderCn")]
        [Validation(Required=false)]
        public string PlaceholderCn { get; set; }

        [NameInMap("placeholderEn")]
        [Validation(Required=false)]
        public string PlaceholderEn { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        [NameInMap("values")]
        [Validation(Required=false)]
        public List<AlertRuleAlertMetricParamDefValues> Values { get; set; }
        public class AlertRuleAlertMetricParamDefValues : TeaModel {
            [NameInMap("labelCn")]
            [Validation(Required=false)]
            public string LabelCn { get; set; }

            [NameInMap("labelEn")]
            [Validation(Required=false)]
            public string LabelEn { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
