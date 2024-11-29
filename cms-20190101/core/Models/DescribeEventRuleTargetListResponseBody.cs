// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeEventRuleTargetListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the call was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about the recipients if alert notifications are sent to the alert contacts of an alert contact group.</para>
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
                /// <para>The name of the alert group.</para>
                /// </summary>
                [NameInMap("ContactGroupName")]
                [Validation(Required=false)]
                public string ContactGroupName { get; set; }

                /// <summary>
                /// <para>The ID of the recipient.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The alert notification methods. Valid values:</para>
                /// <para>4: Alert notifications are sent by using DingTalk chatbots and emails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

        }

        /// <summary>
        /// <para>The information about the recipients in Function Compute.</para>
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
                /// <para>The Alibaba Cloud Resource Name (ARN) of the function. </para>
                /// <para>Format: <c>arn:acs:${Service}:${Region}:${Account}:${ResourceType}/${ResourceId}</c>. Fields: </para>
                /// <list type="bullet">
                /// <item><description>Service: the code of an Alibaba Cloud service</description></item>
                /// <item><description>Region: the region ID</description></item>
                /// <item><description>Account: the ID of an Alibaba Cloud account</description></item>
                /// <item><description>ResourceType: the resource type</description></item>
                /// <item><description>ResourceId: the resource ID</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// <para>The name of the function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fcTest1</para>
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                /// <summary>
                /// <para>The ID of the recipient.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The region where Function Compute is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-qingdao</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The name of the Function Compute service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>service1</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Request is not authorization.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The notifications of Simple Message Queue (formerly MNS) (SMQ).</para>
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
                /// <para>The ARN of the MNS queue. </para>
                /// <para>Format: <c>arn:acs:${Service}:${Region}:${Account}:${ResourceType}/${ResourceId}</c>. Fields: </para>
                /// <list type="bullet">
                /// <item><description>Service: the code of an Alibaba Cloud service</description></item>
                /// <item><description>Region: the region ID</description></item>
                /// <item><description>Account: the ID of an Alibaba Cloud account</description></item>
                /// <item><description>ResourceType: the resource type</description></item>
                /// <item><description>ResourceId: the resource ID</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// <para>The ID of the recipient.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the SMQ queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testQueue</para>
                /// </summary>
                [NameInMap("Queue")]
                [Validation(Required=false)]
                public string Queue { get; set; }

                /// <summary>
                /// <para>The region for SMQ.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The SMQ topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>topic_sample</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

        }

        /// <summary>
        /// <para>The information about the recipients in OpenAPI Explorer.</para>
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
                /// <para>The name of the API operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PutLogs</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The ARN of the API operation. </para>
                /// <para>Format: <c>arn:acs:${Service}:${Region}:${Account}:${ResourceType}/${ResourceId}</c>. Fields: </para>
                /// <list type="bullet">
                /// <item><description>Service: the code of an Alibaba Cloud service</description></item>
                /// <item><description>Region: the region ID</description></item>
                /// <item><description>Account: the ID of an Alibaba Cloud account</description></item>
                /// <item><description>ResourceType: the resource type</description></item>
                /// <item><description>ResourceId: the resource ID The ARN of the Log Service Logstore.</description></item>
                /// </list>
                /// <para>Format: <c>arn:acs:${Service}:${Region}:${Account}:${ResourceType}/${ResourceId}</c>. Fields:</para>
                /// <list type="bullet">
                /// <item><description>Service: the code of an Alibaba Cloud service</description></item>
                /// <item><description>Region: the region ID</description></item>
                /// <item><description>Account: the ID of an Alibaba Cloud account</description></item>
                /// <item><description>ResourceType: the resource type</description></item>
                /// <item><description>ResourceId: the resource ID</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// <para>The ID of the recipient.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The ID of the cloud service to which the API operation belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>log</para>
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// <para>The region where the resource resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The name of the role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MyRole</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The version of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-01-01</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>87170bc7-e28a-4c93-b9bf-90a1dbe84736</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the recipients in Log Service.</para>
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
                /// <para>The ARN of the Log Service Logstore. </para>
                /// <para>Format: <c>arn:acs:${Service}:${Region}:${Account}:${ResourceType}/${ResourceId}</c>. Fields: </para>
                /// <list type="bullet">
                /// <item><description>Service: the code of an Alibaba Cloud service</description></item>
                /// <item><description>Region: the region ID</description></item>
                /// <item><description>Account: the ID of an Alibaba Cloud account</description></item>
                /// <item><description>ResourceType: the resource type</description></item>
                /// <item><description>ResourceId: the resource ID</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// <para>The ID of the recipient.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>logstore_test</para>
                /// </summary>
                [NameInMap("LogStore")]
                [Validation(Required=false)]
                public string LogStore { get; set; }

                /// <summary>
                /// <para>The name of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>project_test</para>
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The ID of the region where the Log Service project resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

        }

        /// <summary>
        /// <para>The information about the recipients if alert notifications are sent by sending a request to a callback URL.</para>
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
                /// <para>The ID of the recipient.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The HTTP request method. Valid values: GET and POST.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GET</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The protocol type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The callback URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

    }

}
