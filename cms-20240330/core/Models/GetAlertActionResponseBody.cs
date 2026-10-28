// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetAlertActionResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of alert action integration configurations.</para>
        /// </summary>
        [NameInMap("alertActions")]
        [Validation(Required=false)]
        public GetAlertActionResponseBodyAlertActions AlertActions { get; set; }
        public class GetAlertActionResponseBodyAlertActions : TeaModel {
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
            public GetAlertActionResponseBodyAlertActionsEbParam EbParam { get; set; }
            public class GetAlertActionResponseBodyAlertActionsEbParam : TeaModel {
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
            public GetAlertActionResponseBodyAlertActionsEssParam EssParam { get; set; }
            public class GetAlertActionResponseBodyAlertActionsEssParam : TeaModel {
                /// <summary>
                /// <para>The ID of the elastic scaling group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("essGroupId")]
                [Validation(Required=false)]
                public string EssGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the elastic scaling rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
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
            public GetAlertActionResponseBodyAlertActionsFc3Param Fc3Param { get; set; }
            public class GetAlertActionResponseBodyAlertActionsFc3Param : TeaModel {
                /// <summary>
                /// <para>The name of the function.</para>
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
                /// <para>cn-qingdao</para>
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
            public GetAlertActionResponseBodyAlertActionsFcParam FcParam { get; set; }
            public class GetAlertActionResponseBodyAlertActionsFcParam : TeaModel {
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
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The service name in Function Compute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("service")]
                [Validation(Required=false)]
                public string Service { get; set; }

            }

            /// <summary>
            /// <para>The Simple Message Queue (formerly MNS) parameters.</para>
            /// </summary>
            [NameInMap("mnsParam")]
            [Validation(Required=false)]
            public GetAlertActionResponseBodyAlertActionsMnsParam MnsParam { get; set; }
            public class GetAlertActionResponseBodyAlertActionsMnsParam : TeaModel {
                /// <summary>
                /// <para>The resource type of Simple Message Queue (formerly MNS).</para>
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
                /// <item><description>If the resource type is queue, the resource name is the name of the queue.</description></item>
                /// <item><description>If the resource type is topic, the resource name is the name of the topic.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
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
            public GetAlertActionResponseBodyAlertActionsPagerDutyParam PagerDutyParam { get; set; }
            public class GetAlertActionResponseBodyAlertActionsPagerDutyParam : TeaModel {
                /// <summary>
                /// <para>The integration key of PagerDuty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EWR4WR4T4GREG4ET453T5Y</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The integration webhook URL for PagerDuty. V1 and V2 are supported.</para>
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
            public GetAlertActionResponseBodyAlertActionsSlsParam SlsParam { get; set; }
            public class GetAlertActionResponseBodyAlertActionsSlsParam : TeaModel {
                /// <summary>
                /// <para>The name of the Simple Log Service Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <para>The name of the Simple Log Service project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

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
            /// <para>The type of the alert action integration.</para>
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
            public GetAlertActionResponseBodyAlertActionsWebhookParam WebhookParam { get; set; }
            public class GetAlertActionResponseBodyAlertActionsWebhookParam : TeaModel {
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
                /// <para>The URL for the alert callback.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.test.com">http://www.test.com</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
