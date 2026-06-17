// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutEventRuleTargetsRequest : TeaModel {
        /// <summary>
        /// <para>The alert contact group notification method.</para>
        /// </summary>
        [NameInMap("ContactParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestContactParameters> ContactParameters { get; set; }
        public class PutEventRuleTargetsRequestContactParameters : TeaModel {
            /// <summary>
            /// <para>The name of the alert contact group. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default alert contact group</para>
            /// </summary>
            [NameInMap("ContactGroupName")]
            [Validation(Required=false)]
            public string ContactGroupName { get; set; }

            /// <summary>
            /// <para>The unique identifier of the rule target. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The alert notification level. Valid values of N: 1 to 5. Valid values:</para>
            /// <para>&lt;props=&quot;china&quot;&gt;- 2: phone call, text message, DingTalk, and email</para>
            /// <para>&lt;props=&quot;china&quot;&gt;- 3: text message, DingTalk, and email</para>
            /// <para>&lt;props=&quot;china&quot;&gt;- 4: DingTalk and email</para>
            /// <para>&lt;props=&quot;intl&quot;&gt;4: DingTalk and email</para>
            /// <para>&lt;props=&quot;partner&quot;&gt;4: DingTalk and email.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

        /// <summary>
        /// <para>The Function Compute notification method.</para>
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
            /// <para>The unique identifier of the rule target. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The region where the Function Compute service resides. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The service name of the Function Compute service. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fc-test</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        /// <summary>
        /// <para>The Simple Message Queue (formerly MNS) notification method.</para>
        /// </summary>
        [NameInMap("MnsParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestMnsParameters> MnsParameters { get; set; }
        public class PutEventRuleTargetsRequestMnsParameters : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the rule target. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the queue. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>queue1</para>
            /// </summary>
            [NameInMap("Queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }

            /// <summary>
            /// <para>The region where Simple Message Queue (formerly MNS) resides. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The topic of Simple Message Queue (formerly MNS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>topic_sample</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

        /// <summary>
        /// <para>The list of API callback notification parameters.</para>
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
            /// <para>The Alibaba Cloud Resource Name (ARN) of the resource. Valid values of N: 1 to 5.
            /// Format: <c>arn:acs:${Service}:${Region}:${Account}:${ResourceType}/${ResourceId}</c>. The fields are described as follows:</para>
            /// <list type="bullet">
            /// <item><description>Service: the Alibaba Cloud service.</description></item>
            /// <item><description>Region: the region ID.</description></item>
            /// <item><description>Account: the Alibaba Cloud account ID.</description></item>
            /// <item><description>ResourceType: the resource type.</description></item>
            /// <item><description>ResourceId: the resource ID.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// <para>The unique identifier of the API callback notification method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The JSON-formatted parameters of the alert callback.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;customField1&quot;:&quot;value1&quot;,&quot;customField2&quot;:&quot;$.name&quot;}</para>
            /// </summary>
            [NameInMap("JsonParams")]
            [Validation(Required=false)]
            public string JsonParams { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud service to which the API belongs.</para>
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
            /// <para>The role name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyRole</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The API version.</para>
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
        /// <para>The Simple Log Service notification method.</para>
        /// </summary>
        [NameInMap("SlsParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestSlsParameters> SlsParameters { get; set; }
        public class PutEventRuleTargetsRequestSlsParameters : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the rule target. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The Logstore of Simple Log Service. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testlogstore</para>
            /// </summary>
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            /// <summary>
            /// <para>The project of Simple Log Service. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testproject</para>
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The region where Simple Log Service resides. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        /// <summary>
        /// <para>The URL callback notification method.</para>
        /// </summary>
        [NameInMap("WebhookParameters")]
        [Validation(Required=false)]
        public List<PutEventRuleTargetsRequestWebhookParameters> WebhookParameters { get; set; }
        public class PutEventRuleTargetsRequestWebhookParameters : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the rule target. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The request method of the HTTP callback. Valid values of N: 1 to 5.</para>
            /// <para>Only GET and POST are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GET</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>The protocol name. Valid values of N: 1 to 5. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>http</description></item>
            /// <item><description>telnet</description></item>
            /// <item><description>ping.</description></item>
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
