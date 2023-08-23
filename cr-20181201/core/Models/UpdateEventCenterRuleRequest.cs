// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UpdateEventCenterRuleRequest : TeaModel {
        /// <summary>
        /// The event notification channel.
        /// </summary>
        [NameInMap("EventChannel")]
        [Validation(Required=false)]
        public string EventChannel { get; set; }

        /// <summary>
        /// The event configuration.
        /// </summary>
        [NameInMap("EventConfig")]
        [Validation(Required=false)]
        public string EventConfig { get; set; }

        /// <summary>
        /// The event scope. Valid values:
        /// 
        /// *   `INSTANCE`
        /// *   `NAMESPACE`
        /// *   `REPO`
        /// 
        /// Default value: `INSTANCE`
        /// </summary>
        [NameInMap("EventScope")]
        [Validation(Required=false)]
        public string EventScope { get; set; }

        /// <summary>
        /// The type of the event. Valid values:
        /// 
        /// *   `cr:Artifact:DeliveryChainCompleted`: The delivery chain is processed.
        /// *   `cr:Artifact:SynchronizationCompleted`: The image is replicated.
        /// *   `cr:Artifact:BuildCompleted`: The image is built.
        /// *   `cr:Artifact:ScanCompleted`: The image is scanned.
        /// *   `cr:Artifact:SigningCompleted`: The image is signed.
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The namespaces to which the event notification rule applies.
        /// </summary>
        [NameInMap("Namespaces")]
        [Validation(Required=false)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// The names of the repositories to which the event notification rule applies.
        /// </summary>
        [NameInMap("RepoNames")]
        [Validation(Required=false)]
        public List<string> RepoNames { get; set; }

        /// <summary>
        /// The regular expression for image tags.
        /// </summary>
        [NameInMap("RepoTagFilterPattern")]
        [Validation(Required=false)]
        public string RepoTagFilterPattern { get; set; }

        /// <summary>
        /// The ID of the event notification rule.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// The name of the event notification rule.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
