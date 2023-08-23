// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoTriggerResponseBody : TeaModel {
        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   `true`: The request is successful.
        /// *   `false`: The request fails.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The triggers of the repository.
        /// </summary>
        [NameInMap("Triggers")]
        [Validation(Required=false)]
        public List<ListRepoTriggerResponseBodyTriggers> Triggers { get; set; }
        public class ListRepoTriggerResponseBodyTriggers : TeaModel {
            /// <summary>
            /// The type of the event that activates the trigger. Valid values:
            /// 
            /// *   `BUILD_SUCCESS`: The trigger is activated when an image building task is successful.
            /// *   `BUILD_Fail`: The trigger is activated when an image building task fails.
            /// </summary>
            [NameInMap("RepoEvent")]
            [Validation(Required=false)]
            public string RepoEvent { get; set; }

            /// <summary>
            /// The ID of the trigger.
            /// </summary>
            [NameInMap("TriggerId")]
            [Validation(Required=false)]
            public string TriggerId { get; set; }

            /// <summary>
            /// The name of the trigger.
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

}
