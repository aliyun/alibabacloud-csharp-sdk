// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UpdateRepoTriggerRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the image repository.
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// The ID of the trigger.
        /// </summary>
        [NameInMap("TriggerId")]
        [Validation(Required=false)]
        public string TriggerId { get; set; }

        /// <summary>
        /// The name of the trigger.
        /// 
        /// You can specify the TriggerName or TriggerUrl parameter. The TriggerName parameter is optional.
        /// </summary>
        [NameInMap("TriggerName")]
        [Validation(Required=false)]
        public string TriggerName { get; set; }

        /// <summary>
        /// The image tag based on which the trigger is set.
        /// </summary>
        [NameInMap("TriggerTag")]
        [Validation(Required=false)]
        public string TriggerTag { get; set; }

        /// <summary>
        /// The type of the trigger. Valid values:
        /// 
        /// *   `ALL`: a trigger that supports both tags and regular expressions.
        /// *   `TAG_LISTTAG`: a tag-based trigger.
        /// *   `TAG_REG_EXP`: a regular expression-based trigger.
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        /// <summary>
        /// The URL of the trigger.
        /// </summary>
        [NameInMap("TriggerUrl")]
        [Validation(Required=false)]
        public string TriggerUrl { get; set; }

    }

}
