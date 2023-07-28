// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutEventRuleTargetsRequest : TeaModel {
        [NameInMap("ContactParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestContactParameters> ContactParameters { get; set; }
        public class PutEventRuleTargetsRequestContactParameters : TeaModel {
            /// <summary>
            /// The operation that you want to perform. Set the value to **PutEventRuleTargets**.
            /// </summary>
            [NameInMap("ContactGroupName")]
            [Validation(Required=false)]
            public string ContactGroupName { get; set; }

            /// <summary>
            /// The HTTP request method. Valid values of N: 1 to 5.
            /// 
            /// Valid values: GET and POST.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The name of the event-triggered alert rule.
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

        [NameInMap("FcParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestFcParameters> FcParameters { get; set; }
        public class PutEventRuleTargetsRequestFcParameters : TeaModel {
            /// <summary>
            /// The number of resources that failed to be created or modified.
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// The HTTP status code.
            /// 
            /// >  The status code 200 indicates that the call was successful.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The MNS topic.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The region where Log Service is deployed. Valid values of N: 1 to 5.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        [NameInMap("MnsParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestMnsParameters> MnsParameters { get; set; }
        public class PutEventRuleTargetsRequestMnsParameters : TeaModel {
            /// <summary>
            /// The ID of the recipient that receives alert notifications. Valid values of N: 1 to 5.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The version of the API.
            /// </summary>
            [NameInMap("Queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }

            /// <summary>
            /// The ID of the recipient that receives alert notifications. Valid values of N: 1 to 5.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the resource. Valid values of N: 1 to 5.
            /// 
            /// Format: `arn:acs:${Service}:${Region}:${Account}:${ResourceType}/${ResourceId}`. Fields:
            /// 
            /// *   Service: the code of a cloud service
            /// *   Region: the region ID
            /// *   Account: the ID of an Alibaba Cloud account
            /// *   ResourceType: the resource type
            /// *   ResourceId: the resource ID
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

        [NameInMap("OpenApiParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestOpenApiParameters> OpenApiParameters { get; set; }
        public class PutEventRuleTargetsRequestOpenApiParameters : TeaModel {
            /// <summary>
            /// The ID of the recipient that receives alert notifications sent by an API callback.
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// The region where Function Compute is deployed. Valid values of N: 1 to 5.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The region where Message Service (MNS) is deployed. Valid values of N: 1 to 5.
            /// </summary>
            [NameInMap("JsonParams")]
            [Validation(Required=false)]
            public string JsonParams { get; set; }

            /// <summary>
            /// The name of the Log Service project. Valid values of N: 1 to 5.
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// The callback URL. Valid values of N: 1 to 5.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// This parameter is returned if the specified alert contact groups in the request failed to be created or modified.
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// The name of the alert contact group.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the protocol. Valid values of N: 1 to 5. Valid values:
        /// 
        /// *   http
        /// *   telnet
        /// *   ping
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("SlsParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestSlsParameters> SlsParameters { get; set; }
        public class PutEventRuleTargetsRequestSlsParameters : TeaModel {
            /// <summary>
            /// The name of the alert contact group. Valid values of N: 1 to 5.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The name of the Log Service Logstore. Valid values of N: 1 to 5.
            /// </summary>
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            /// <summary>
            /// The parameters of the alert callback. The parameters are in the JSON format.
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// The ID of the recipient that receives alert notifications. Valid values of N: 1 to 5.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        [NameInMap("WebhookParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestWebhookParameters> WebhookParameters { get; set; }
        public class PutEventRuleTargetsRequestWebhookParameters : TeaModel {
            /// <summary>
            /// The alert notification methods. Valid values of N: 1 to 5. Valid values:
            /// 
            /// 4: Alert notifications are sent by using DingTalk chatbots and emails.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The region where the resource resides.
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// The ID of the recipient.
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// The name of the function. Valid values of N: 1 to 5.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
