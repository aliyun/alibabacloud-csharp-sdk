// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleAlertMetricFilterDef : TeaModel {
        [NameInMap("dim")]
        [Validation(Required=false)]
        public string Dim { get; set; }

        [NameInMap("dimDisabled")]
        [Validation(Required=false)]
        public bool? DimDisabled { get; set; }

        [NameInMap("displayNameCn")]
        [Validation(Required=false)]
        public string DisplayNameCn { get; set; }

        [NameInMap("displayNameEn")]
        [Validation(Required=false)]
        public string DisplayNameEn { get; set; }

        [NameInMap("hidden")]
        [Validation(Required=false)]
        public bool? Hidden { get; set; }

        [NameInMap("labelDisabled")]
        [Validation(Required=false)]
        public bool? LabelDisabled { get; set; }

        [NameInMap("opt")]
        [Validation(Required=false)]
        public string Opt { get; set; }

        [NameInMap("supportedOpts")]
        [Validation(Required=false)]
        public List<AlertRuleAlertMetricFilterDefSupportedOpts> SupportedOpts { get; set; }
        public class AlertRuleAlertMetricFilterDefSupportedOpts : TeaModel {
            [NameInMap("displayNameCn")]
            [Validation(Required=false)]
            public string DisplayNameCn { get; set; }

            [NameInMap("displayNameEn")]
            [Validation(Required=false)]
            public string DisplayNameEn { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
