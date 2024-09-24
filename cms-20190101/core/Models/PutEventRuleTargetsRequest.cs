// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutEventRuleTargetsRequest : TeaModel {
        /// <summary>
        /// <para>The information about the alert contact groups that receive alert notifications.</para>
        /// </summary>
        [NameInMap("ContactParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestContactParameters> ContactParameters { get; set; }
        public class PutEventRuleTargetsRequestContactParameters : TeaModel {
            /// <summary>
            /// <para>The name of the alert contact group. Valid values of N: 1 to 5.</para>
            /// </summary>
            [NameInMap("ContactGroupName")]
            [Validation(Required=false)]
            public string ContactGroupName { get; set; }

            /// <summary>
            /// <para>The ID of the recipient that receives alert notifications. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The alert level and the corresponding notification methods. Valid values of N: 1 to 5. Valid values:</para>
            /// <para>4: Alert notifications are sent by using DingTalk chatbots and emails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

        /// <summary>
        /// <para>The information about the recipients in Function Compute.</para>
        /// </summary>
        [NameInMap("FcParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestFcParameters> FcParameters { get; set; }
        public class PutEventRuleTargetsRequestFcParameters : TeaModel {
            /// <summary>
            /// <para>The name of the function. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fc-test</para>
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// <para>The ID of the recipient that receives alert notifications. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The region where Function Compute is deployed. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The name of the Function Compute service. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fc-test</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        /// <summary>
        /// <para>The information about the recipients in Message Service (MNS).</para>
        /// </summary>
        [NameInMap("MnsParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestMnsParameters> MnsParameters { get; set; }
        public class PutEventRuleTargetsRequestMnsParameters : TeaModel {
            /// <summary>
            /// <para>The ID of the recipient that receives alert notifications. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the MNS queue. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>queue1</para>
            /// </summary>
            [NameInMap("Queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }

            /// <summary>
            /// <para>The region where Message Service (MNS) is deployed. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The MNS topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>topic_sample</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

        /// <summary>
        /// <para>The parameters of API callback notification.</para>
        /// </summary>
        [NameInMap("OpenApiParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestOpenApiParameters> OpenApiParameters { get; set; }
        public class PutEventRuleTargetsRequestOpenApiParameters : TeaModel {
            /// <summary>
            /// <para>The API name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PutLogs</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the resource. Valid values of N: 1 to 5. Format: <c>arn:acs:${Service}:${Region}:${Account}:${ResourceType}/${ResourceId}</c>. Fields:</para>
            /// <list type="bullet">
            /// <item><description>Service: the code of a cloud service</description></item>
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
            /// <para>The ID of the recipient that receives alert notifications sent by an API callback.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The parameters of the alert callback. Specify the parameters in the JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;customField1&quot;:&quot;value1&quot;,&quot;customField2&quot;:&quot;$.name&quot;}</para>
            /// </summary>
            [NameInMap("JsonParams")]
            [Validation(Required=false)]
            public string JsonParams { get; set; }

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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the alert rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testEventRule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The information about the recipients in Simple Log Service.</para>
        /// </summary>
        [NameInMap("SlsParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestSlsParameters> SlsParameters { get; set; }
        public class PutEventRuleTargetsRequestSlsParameters : TeaModel {
            /// <summary>
            /// <para>The ID of the recipient that receives alert notifications. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the Simple Log Service Logstore. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testlogstore</para>
            /// </summary>
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            /// <summary>
            /// <para>The name of the Simple Log Service project. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testproject</para>
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The region where Simple Log Service is deployed. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        /// <summary>
        /// <para>The information about the callback URLs that are used to receive alert notifications.</para>
        /// </summary>
        [NameInMap("WebhookParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestWebhookParameters> WebhookParameters { get; set; }
        public class PutEventRuleTargetsRequestWebhookParameters : TeaModel {
            /// <summary>
            /// <para>The ID of the recipient that receives alert notifications. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The HTTP request method. Valid values of N: 1 to 5.</para>
            /// <para>Valid values: GET and POST.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GET</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>The name of the protocol. Valid values of N: 1 to 5. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>http</description></item>
            /// <item><description>telnet</description></item>
            /// <item><description>ping</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The callback URL. Valid values of N: 1 to 5.</para>
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
