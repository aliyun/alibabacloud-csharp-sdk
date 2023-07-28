// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeEventRuleTargetListResponseBody : TeaModel {
        /// <summary>
        /// The alert notification methods. Valid values:
        /// 
        /// 4: Alert notifications are sent by using DingTalk chatbots and emails.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// For more information about common request parameters, see [Common parameters](~~199331~~).
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
                /// Queries the details of an event-triggered alert rule.
                /// </summary>
                [NameInMap("ContactGroupName")]
                [Validation(Required=false)]
                public string ContactGroupName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

        }

        [NameInMap("FcParameters")]
        [Validation(Required=false)]
        public DescribeEventRuleTargetListResponseBodyFcParameters FcParameters { get; set; }
        public class DescribeEventRuleTargetListResponseBodyFcParameters : TeaModel {
            [NameInMap("FCParameter")]
            [Validation(Required=false)]
            public List<DescribeEventRuleTargetListResponseBodyFcParametersFCParameter> FCParameter { get; set; }
            public class DescribeEventRuleTargetListResponseBodyFcParametersFCParameter : TeaModel {
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

        }

        /// <summary>
        /// The information about the recipients if alert notifications are sent to the alert contacts of an alert contact group.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("MnsParameters")]
        [Validation(Required=false)]
        public DescribeEventRuleTargetListResponseBodyMnsParameters MnsParameters { get; set; }
        public class DescribeEventRuleTargetListResponseBodyMnsParameters : TeaModel {
            [NameInMap("MnsParameter")]
            [Validation(Required=false)]
            public List<DescribeEventRuleTargetListResponseBodyMnsParametersMnsParameter> MnsParameter { get; set; }
            public class DescribeEventRuleTargetListResponseBodyMnsParametersMnsParameter : TeaModel {
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Queue")]
                [Validation(Required=false)]
                public string Queue { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

        }

        [NameInMap("OpenApiParameters")]
        [Validation(Required=false)]
        public DescribeEventRuleTargetListResponseBodyOpenApiParameters OpenApiParameters { get; set; }
        public class DescribeEventRuleTargetListResponseBodyOpenApiParameters : TeaModel {
            [NameInMap("OpenApiParameters")]
            [Validation(Required=false)]
            public List<DescribeEventRuleTargetListResponseBodyOpenApiParametersOpenApiParameters> OpenApiParameters { get; set; }
            public class DescribeEventRuleTargetListResponseBodyOpenApiParametersOpenApiParameters : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

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

        [NameInMap("SlsParameters")]
        [Validation(Required=false)]
        public DescribeEventRuleTargetListResponseBodySlsParameters SlsParameters { get; set; }
        public class DescribeEventRuleTargetListResponseBodySlsParameters : TeaModel {
            [NameInMap("SlsParameter")]
            [Validation(Required=false)]
            public List<DescribeEventRuleTargetListResponseBodySlsParametersSlsParameter> SlsParameter { get; set; }
            public class DescribeEventRuleTargetListResponseBodySlsParametersSlsParameter : TeaModel {
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("LogStore")]
                [Validation(Required=false)]
                public string LogStore { get; set; }

                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

        }

        [NameInMap("WebhookParameters")]
        [Validation(Required=false)]
        public DescribeEventRuleTargetListResponseBodyWebhookParameters WebhookParameters { get; set; }
        public class DescribeEventRuleTargetListResponseBodyWebhookParameters : TeaModel {
            [NameInMap("WebhookParameter")]
            [Validation(Required=false)]
            public List<DescribeEventRuleTargetListResponseBodyWebhookParametersWebhookParameter> WebhookParameter { get; set; }
            public class DescribeEventRuleTargetListResponseBodyWebhookParametersWebhookParameter : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

    }

}
