// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateAlertActionRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the alert action integration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testId</para>
        /// </summary>
        [NameInMap("alertActionId")]
        [Validation(Required=false)]
        public string AlertActionId { get; set; }

        /// <summary>
        /// <para>The name of the alert action integration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("alertActionName")]
        [Validation(Required=false)]
        public string AlertActionName { get; set; }

        /// <summary>
        /// <para>The event bus parameters.</para>
        /// </summary>
        [NameInMap("ebParam")]
        [Validation(Required=false)]
        public CreateAlertActionRequestEbParam EbParam { get; set; }
        public class CreateAlertActionRequestEbParam : TeaModel {
            /// <summary>
            /// <para>The event source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ebSource")]
            [Validation(Required=false)]
            public string EbSource { get; set; }

            /// <summary>
            /// <para>The name of the event bus.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("eventBusName")]
            [Validation(Required=false)]
            public string EventBusName { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-heyuan</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The subject.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

        }

        /// <summary>
        /// <para>The elastic scaling parameters.</para>
        /// </summary>
        [NameInMap("essParam")]
        [Validation(Required=false)]
        public CreateAlertActionRequestEssParam EssParam { get; set; }
        public class CreateAlertActionRequestEssParam : TeaModel {
            /// <summary>
            /// <para>The ID of the elastic scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testId</para>
            /// </summary>
            [NameInMap("essGroupId")]
            [Validation(Required=false)]
            public string EssGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the elastic scaling rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testId</para>
            /// </summary>
            [NameInMap("essRuleId")]
            [Validation(Required=false)]
            public string EssRuleId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The Function Compute 3.0 parameters.</para>
        /// </summary>
        [NameInMap("fc3Param")]
        [Validation(Required=false)]
        public CreateAlertActionRequestFc3Param Fc3Param { get; set; }
        public class CreateAlertActionRequestFc3Param : TeaModel {
            /// <summary>
            /// <para>The name of the function in Function Compute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("function")]
            [Validation(Required=false)]
            public string Function { get; set; }

            /// <summary>
            /// <para>The version or alias of the function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("qualifier")]
            [Validation(Required=false)]
            public string Qualifier { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-nanjing</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The Function Compute parameters.</para>
        /// </summary>
        [NameInMap("fcParam")]
        [Validation(Required=false)]
        public CreateAlertActionRequestFcParam FcParam { get; set; }
        public class CreateAlertActionRequestFcParam : TeaModel {
            /// <summary>
            /// <para>The name of the function in Function Compute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testFunction</para>
            /// </summary>
            [NameInMap("function")]
            [Validation(Required=false)]
            public string Function { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The service name of Function Compute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testService</para>
            /// </summary>
            [NameInMap("service")]
            [Validation(Required=false)]
            public string Service { get; set; }

        }

        /// <summary>
        /// <para>The Simple Message Queue (formerly MNS) (MSMQ) parameters.</para>
        /// </summary>
        [NameInMap("mnsParam")]
        [Validation(Required=false)]
        public CreateAlertActionRequestMnsParam MnsParam { get; set; }
        public class CreateAlertActionRequestMnsParam : TeaModel {
            /// <summary>
            /// <para>The resource type of Simple Message Queue (formerly MNS) (MSMQ).</para>
            /// 
            /// <b>Example:</b>
            /// <para>queue</para>
            /// </summary>
            [NameInMap("mnsType")]
            [Validation(Required=false)]
            public string MnsType { get; set; }

            /// <summary>
            /// <para>The name of the resource.</para>
            /// <list type="bullet">
            /// <item><description>If the resource type is queue, the resource name is the queue name.</description></item>
            /// <item><description>If the resource type is topic, the resource name is the topic name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The PagerDuty parameters.</para>
        /// </summary>
        [NameInMap("pagerDutyParam")]
        [Validation(Required=false)]
        public CreateAlertActionRequestPagerDutyParam PagerDutyParam { get; set; }
        public class CreateAlertActionRequestPagerDutyParam : TeaModel {
            /// <summary>
            /// <para>The integration key of PagerDuty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fds3wr54rvcxfr4543t6435</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The integration webhook URL of PagerDuty. Both V1 and V2 are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://events.pagerduty.com/v2/enqueue">https://events.pagerduty.com/v2/enqueue</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The Simple Log Service parameters.</para>
        /// </summary>
        [NameInMap("slsParam")]
        [Validation(Required=false)]
        public CreateAlertActionRequestSlsParam SlsParam { get; set; }
        public class CreateAlertActionRequestSlsParam : TeaModel {
            /// <summary>
            /// <para>The name of the Logstore in Simple Log Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testLogstore。</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// <para>The name of the project in Simple Log Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testProject</para>
            /// </summary>
            [NameInMap("project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The type of the alert action integration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The webhook parameters.</para>
        /// </summary>
        [NameInMap("webhookParam")]
        [Validation(Required=false)]
        public CreateAlertActionRequestWebhookParam WebhookParam { get; set; }
        public class CreateAlertActionRequestWebhookParam : TeaModel {
            /// <summary>
            /// <para>The data format. This parameter takes effect only when the request method is POST.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JSON</para>
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>The request header information.</para>
            /// </summary>
            [NameInMap("headers")]
            [Validation(Required=false)]
            public Dictionary<string, string> Headers { get; set; }

            /// <summary>
            /// <para>The webhook request method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POST</para>
            /// </summary>
            [NameInMap("method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>The alert callback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.test.com">http://www.test.com</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
