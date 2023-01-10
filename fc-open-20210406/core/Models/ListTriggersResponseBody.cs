// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListTriggersResponseBody : TeaModel {
        /// <summary>
        /// The token used to obtain more results. If this parameter is left empty, all the results are returned.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The information about triggers.
        /// </summary>
        [NameInMap("triggers")]
        [Validation(Required=false)]
        public List<ListTriggersResponseBodyTriggers> Triggers { get; set; }
        public class ListTriggersResponseBodyTriggers : TeaModel {
            /// <summary>
            /// The time when the trigger was created.
            /// </summary>
            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// The description of the trigger.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The domain name used to invoke the function by using HTTP. You can add this domain name as the prefix to the endpoint of Function Compute. This way, you can invoke the function that corresponds to the trigger by using HTTP. For example, `{domainName}.cn-shanghai.fc.aliyuncs.com`.
            /// </summary>
            [NameInMap("domainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// The ARN of the RAM role that is used by the event source to invoke the function.
            /// </summary>
            [NameInMap("invocationRole")]
            [Validation(Required=false)]
            public string InvocationRole { get; set; }

            /// <summary>
            /// The time when the trigger was last modified.
            /// </summary>
            [NameInMap("lastModifiedTime")]
            [Validation(Required=false)]
            public string LastModifiedTime { get; set; }

            /// <summary>
            /// The version or alias of the service.
            /// </summary>
            [NameInMap("qualifier")]
            [Validation(Required=false)]
            public string Qualifier { get; set; }

            /// <summary>
            /// The ARN of the event source.
            /// </summary>
            [NameInMap("sourceArn")]
            [Validation(Required=false)]
            public string SourceArn { get; set; }

            /// <summary>
            /// The configurations of the trigger. The configurations vary based on the trigger type. For more information about the format, see the following topics:
            /// 
            /// *   OSS trigger: [OSSTriggerConfig](javascript:void\(0\)).
            /// *   Log Service trigger: [LogTriggerConfig](javascript:void\(0\)).
            /// *   Time trigger: [TimeTriggerConfig](javascript:void\(0\)).
            /// *   HTTP trigger: [HTTPTriggerConfig](javascript:void\(0\)).
            /// *   Tablestore trigger: Specify the **SourceArn** parameter and leave this parameter empty.
            /// *   Alibaba Cloud CDN event trigger: [CDNEventsTriggerConfig](javascript:void\(0\)).
            /// *   MNS topic trigger: [MnsTopicTriggerConfig](javascript:void\(0\)).
            /// </summary>
            [NameInMap("triggerConfig")]
            [Validation(Required=false)]
            public string TriggerConfig { get; set; }

            /// <summary>
            /// The unique ID of the trigger.
            /// </summary>
            [NameInMap("triggerId")]
            [Validation(Required=false)]
            public string TriggerId { get; set; }

            /// <summary>
            /// The name of the trigger.
            /// </summary>
            [NameInMap("triggerName")]
            [Validation(Required=false)]
            public string TriggerName { get; set; }

            /// <summary>
            /// The trigger type, such as **oss**, **log**, **tablestore**, **timer**, **http**, **cdn_events**, and **mns_topic**.
            /// </summary>
            [NameInMap("triggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            /// <summary>
            /// The public domain address. You can access HTTP triggers over the Internet by using HTTP or HTTPS.
            /// </summary>
            [NameInMap("urlInternet")]
            [Validation(Required=false)]
            public string UrlInternet { get; set; }

            /// <summary>
            /// The private endpoint. In a VPC, you can access HTTP triggers by using HTTP or HTTPS.
            /// </summary>
            [NameInMap("urlIntranet")]
            [Validation(Required=false)]
            public string UrlIntranet { get; set; }

        }

    }

}
