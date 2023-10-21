// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeEventRuleTargetListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the recipients if alert notifications are sent to the alert contacts of an alert contact group.
        /// </summary>
        [NameInMap("ContactParameters")]
        [Validation(Required=false)]
        public DescribeEventRuleTargetListResponseBodyContactParameters ContactParameters { get; set; }
        public class DescribeEventRuleTargetListResponseBodyContactParameters : TeaModel {
            [NameInMap("ContactParameter")]
            [Validation(Required=false)]
            public List<DescribeEventRuleTargetListResponseBodyContactParametersContactParameter> ContactParameter { get; set; }
            public class DescribeEventRuleTargetListResponseBodyContactParametersContactParameter : TeaModel {
                /// <summary>
                /// The name of the alert group.
                /// </summary>
                [NameInMap("ContactGroupName")]
                [Validation(Required=false)]
                public string ContactGroupName { get; set; }

                /// <summary>
                /// The ID of the recipient.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The alert notification methods. Valid values:
                /// 
                /// 4: Alert notifications are sent by using DingTalk chatbots and emails.
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

        }

        /// <summary>
        /// The information about the recipients in Function Compute.
        /// </summary>
        [NameInMap("FcParameters")]
        [Validation(Required=false)]
        public DescribeEventRuleTargetListResponseBodyFcParameters FcParameters { get; set; }
        public class DescribeEventRuleTargetListResponseBodyFcParameters : TeaModel {
            [NameInMap("FCParameter")]
            [Validation(Required=false)]
            public List<DescribeEventRuleTargetListResponseBodyFcParametersFCParameter> FCParameter { get; set; }
            public class DescribeEventRuleTargetListResponseBodyFcParametersFCParameter : TeaModel {
                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of the function. 
                /// 
                /// Format: `arn:acs:${Service}:${Region}:${Account}:${ResourceType}/${ResourceId}`. Fields: 
                /// 
                /// - Service: the code of an Alibaba Cloud service
                /// - Region: the region ID
                /// - Account: the ID of an Alibaba Cloud account
                /// - ResourceType: the resource type
                /// - ResourceId: the resource ID
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// The name of the function.
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                /// <summary>
                /// The ID of the recipient.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The region where Function Compute is deployed.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The name of the Function Compute service.
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

        }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The information about the recipients in Message Service (MNS).
        /// </summary>
        [NameInMap("MnsParameters")]
        [Validation(Required=false)]
        public DescribeEventRuleTargetListResponseBodyMnsParameters MnsParameters { get; set; }
        public class DescribeEventRuleTargetListResponseBodyMnsParameters : TeaModel {
            [NameInMap("MnsParameter")]
            [Validation(Required=false)]
            public List<DescribeEventRuleTargetListResponseBodyMnsParametersMnsParameter> MnsParameter { get; set; }
            public class DescribeEventRuleTargetListResponseBodyMnsParametersMnsParameter : TeaModel {
                /// <summary>
                /// The ARN of the MNS queue. 
                /// 
                /// Format: `arn:acs:${Service}:${Region}:${Account}:${ResourceType}/${ResourceId}`. Fields: 
                /// 
                /// - Service: the code of an Alibaba Cloud service
                /// - Region: the region ID
                /// - Account: the ID of an Alibaba Cloud account
                /// - ResourceType: the resource type
                /// - ResourceId: the resource ID
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// The ID of the recipient.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The name of the MNS queue.
                /// </summary>
                [NameInMap("Queue")]
                [Validation(Required=false)]
                public string Queue { get; set; }

                /// <summary>
                /// The region where MNS is deployed.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The MNS topic.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

        }

        /// <summary>
        /// The information about the recipients in OpenAPI Explorer.
        /// </summary>
        [NameInMap("OpenApiParameters")]
        [Validation(Required=false)]
        public DescribeEventRuleTargetListResponseBodyOpenApiParameters OpenApiParameters { get; set; }
        public class DescribeEventRuleTargetListResponseBodyOpenApiParameters : TeaModel {
            [NameInMap("OpenApiParameters")]
            [Validation(Required=false)]
            public List<DescribeEventRuleTargetListResponseBodyOpenApiParametersOpenApiParameters> OpenApiParameters { get; set; }
            public class DescribeEventRuleTargetListResponseBodyOpenApiParametersOpenApiParameters : TeaModel {
                /// <summary>
                /// The name of the API operation.
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// The ARN of the API operation. 
                /// 
                /// Format: `arn:acs:${Service}:${Region}:${Account}:${ResourceType}/${ResourceId}`. Fields: 
                /// 
                /// - Service: the code of an Alibaba Cloud service
                /// - Region: the region ID
                /// - Account: the ID of an Alibaba Cloud account
                /// - ResourceType: the resource type
                /// - ResourceId: the resource ID The ARN of the Log Service Logstore. 
                /// 
                /// Format: `arn:acs:${Service}:${Region}:${Account}:${ResourceType}/${ResourceId}`. Fields:
                /// - Service: the code of an Alibaba Cloud service
                /// - Region: the region ID
                /// - Account: the ID of an Alibaba Cloud account
                /// - ResourceType: the resource type
                /// - ResourceId: the resource ID
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// The ID of the recipient.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The ID of the cloud service to which the API operation belongs.
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// The region where the resource resides.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The name of the role.
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// The version of the API.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the recipients in Log Service.
        /// </summary>
        [NameInMap("SlsParameters")]
        [Validation(Required=false)]
        public DescribeEventRuleTargetListResponseBodySlsParameters SlsParameters { get; set; }
        public class DescribeEventRuleTargetListResponseBodySlsParameters : TeaModel {
            [NameInMap("SlsParameter")]
            [Validation(Required=false)]
            public List<DescribeEventRuleTargetListResponseBodySlsParametersSlsParameter> SlsParameter { get; set; }
            public class DescribeEventRuleTargetListResponseBodySlsParametersSlsParameter : TeaModel {
                /// <summary>
                /// The ARN of the Log Service Logstore. 
                /// 
                /// Format: `arn:acs:${Service}:${Region}:${Account}:${ResourceType}/${ResourceId}`. Fields: 
                /// 
                /// - Service: the code of an Alibaba Cloud service
                /// - Region: the region ID
                /// - Account: the ID of an Alibaba Cloud account
                /// - ResourceType: the resource type
                /// - ResourceId: the resource ID
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// The ID of the recipient.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The name of the Logstore.
                /// </summary>
                [NameInMap("LogStore")]
                [Validation(Required=false)]
                public string LogStore { get; set; }

                /// <summary>
                /// The name of the project.
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// The ID of the region where the Log Service project resides.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

        }

        /// <summary>
        /// The information about the recipients if alert notifications are sent by sending a request to a callback URL.
        /// </summary>
        [NameInMap("WebhookParameters")]
        [Validation(Required=false)]
        public DescribeEventRuleTargetListResponseBodyWebhookParameters WebhookParameters { get; set; }
        public class DescribeEventRuleTargetListResponseBodyWebhookParameters : TeaModel {
            [NameInMap("WebhookParameter")]
            [Validation(Required=false)]
            public List<DescribeEventRuleTargetListResponseBodyWebhookParametersWebhookParameter> WebhookParameter { get; set; }
            public class DescribeEventRuleTargetListResponseBodyWebhookParametersWebhookParameter : TeaModel {
                /// <summary>
                /// The ID of the recipient.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The HTTP request method. Valid values: GET and POST.
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// The protocol type.
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// The callback URL.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

    }

}
