// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAlertActionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of alert action integration configurations.</para>
        /// </summary>
        [NameInMap("alertActions")]
        [Validation(Required=false)]
        public List<ListAlertActionsResponseBodyAlertActions> AlertActions { get; set; }
        public class ListAlertActionsResponseBodyAlertActions : TeaModel {
            /// <summary>
            /// <para>The unique ID of the alert action integration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
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
            /// <para>Specifies the event bus.</para>
            /// </summary>
            [NameInMap("ebParam")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsEbParam EbParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsEbParam : TeaModel {
                /// <summary>
                /// <para>The event provider.</para>
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
            /// <para>The parameters of Auto Scaling.</para>
            /// </summary>
            [NameInMap("essParam")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsEssParam EssParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsEssParam : TeaModel {
                /// <summary>
                /// <para>The ID of the Auto Scaling group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testId</para>
                /// </summary>
                [NameInMap("essGroupId")]
                [Validation(Required=false)]
                public string EssGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the scaling rule.</para>
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
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>The parameters of Function Compute 3.0.</para>
            /// </summary>
            [NameInMap("fc3Param")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsFc3Param Fc3Param { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsFc3Param : TeaModel {
                /// <summary>
                /// <para>The function name of the Function Compute service.</para>
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
            /// <para>The parameters of Function Compute.</para>
            /// </summary>
            [NameInMap("fcParam")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsFcParam FcParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsFcParam : TeaModel {
                /// <summary>
                /// <para>The function name of the Function Compute service.</para>
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
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The service name of Function Compute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("service")]
                [Validation(Required=false)]
                public string Service { get; set; }

            }

            /// <summary>
            /// <para>The parameters of Simple Message Queue (formerly MNS).</para>
            /// </summary>
            [NameInMap("mnsParam")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsMnsParam MnsParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsMnsParam : TeaModel {
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
                /// <item><description><para>If the resource type is \<c>queue\\</c>, this parameter specifies the queue name.</para>
                /// </description></item>
                /// <item><description><para>If the resource type is \<c>topic\\</c>, this parameter specifies the topic name.</para>
                /// </description></item>
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
                /// <para>cn-hangzhou</para>
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
            public ListAlertActionsResponseBodyAlertActionsPagerDutyParam PagerDutyParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsPagerDutyParam : TeaModel {
                /// <summary>
                /// <para>The integration key of PagerDuty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fsfer4543t5t65g4t4</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The integration webhook of PagerDuty. Versions 1 and 2 are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://events.pagerduty.com/v2/enqueue">https://events.pagerduty.com/v2/enqueue</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The parameters of Simple Log Service.</para>
            /// </summary>
            [NameInMap("slsParam")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsSlsParam SlsParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsSlsParam : TeaModel {
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
                /// <para>cn-hangzhou</para>
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
            public ListAlertActionsResponseBodyAlertActionsWebhookParam WebhookParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsWebhookParam : TeaModel {
                /// <summary>
                /// <para>The data format. This parameter is valid only when the request method is POST.</para>
                /// 
                /// <b>Example:</b>
                /// <para>JSON</para>
                /// </summary>
                [NameInMap("contentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>The request headers.</para>
                /// </summary>
                [NameInMap("headers")]
                [Validation(Required=false)]
                public Dictionary<string, string> Headers { get; set; }

                /// <summary>
                /// <para>The request method of the webhook.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GET</para>
                /// </summary>
                [NameInMap("method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The callback URL for alerts.</para>
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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
