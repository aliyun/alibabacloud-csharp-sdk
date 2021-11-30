// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UpdateEventCenterRuleRequest : TeaModel {
        [NameInMap("EventChannel")]
        [Validation(Required=false)]
        public string EventChannel { get; set; }

        [NameInMap("EventConfig")]
        [Validation(Required=false)]
        public string EventConfig { get; set; }

        [NameInMap("EventScope")]
        [Validation(Required=false)]
        public string EventScope { get; set; }

        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Namespaces")]
        [Validation(Required=false)]
        public List<string> Namespaces { get; set; }

        [NameInMap("RepoNames")]
        [Validation(Required=false)]
        public List<string> RepoNames { get; set; }

        [NameInMap("RepoTagFilterPattern")]
        [Validation(Required=false)]
        public string RepoTagFilterPattern { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
