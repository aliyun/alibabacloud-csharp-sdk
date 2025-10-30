// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListAlertActionsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of alert action configurations.</para>
        /// </summary>
        [NameInMap("alertActions")]
        [Validation(Required=false)]
        public List<ListAlertActionsResponseBodyAlertActions> AlertActions { get; set; }
        public class ListAlertActionsResponseBodyAlertActions : TeaModel {
            /// <summary>
            /// <para>Unique identifier for the action integration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("alertActionId")]
            [Validation(Required=false)]
            public string AlertActionId { get; set; }

            /// <summary>
            /// <para>Alert action name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("alertActionName")]
            [Validation(Required=false)]
            public string AlertActionName { get; set; }

            /// <summary>
            /// <para>Event Bridge parameters.</para>
            /// </summary>
            [NameInMap("ebParam")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsEbParam EbParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsEbParam : TeaModel {
                /// <summary>
                /// <para>Event source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ebSource")]
                [Validation(Required=false)]
                public string EbSource { get; set; }

                /// <summary>
                /// <para>Event bus name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("eventBusName")]
                [Validation(Required=false)]
                public string EventBusName { get; set; }

                /// <summary>
                /// <para>Region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-heyuan</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Subject.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("subject")]
                [Validation(Required=false)]
                public string Subject { get; set; }

            }

            /// <summary>
            /// <para>Elastic scaling parameters.</para>
            /// </summary>
            [NameInMap("essParam")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsEssParam EssParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsEssParam : TeaModel {
                /// <summary>
                /// <para>Elastic scaling group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testId</para>
                /// </summary>
                [NameInMap("essGroupId")]
                [Validation(Required=false)]
                public string EssGroupId { get; set; }

                /// <summary>
                /// <para>Elastic scaling rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testId</para>
                /// </summary>
                [NameInMap("essRuleId")]
                [Validation(Required=false)]
                public string EssRuleId { get; set; }

                /// <summary>
                /// <para>Region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>Function Compute 3.0 parameters.</para>
            /// </summary>
            [NameInMap("fc3Param")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsFc3Param Fc3Param { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsFc3Param : TeaModel {
                /// <summary>
                /// <para>Function name of the Function Compute service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                /// <summary>
                /// <para>Version or alias of the function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("qualifier")]
                [Validation(Required=false)]
                public string Qualifier { get; set; }

                /// <summary>
                /// <para>Region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-qingdao</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>Function Compute parameters.</para>
            /// </summary>
            [NameInMap("fcParam")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsFcParam FcParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsFcParam : TeaModel {
                /// <summary>
                /// <para>Function name in the Function Compute service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                /// <summary>
                /// <para>Region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Function Compute service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("service")]
                [Validation(Required=false)]
                public string Service { get; set; }

            }

            /// <summary>
            /// <para>Lightweight Message Queue (formerly MNS) parameters.</para>
            /// </summary>
            [NameInMap("mnsParam")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsMnsParam MnsParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsMnsParam : TeaModel {
                /// <summary>
                /// <para>Resource type of the Lightweight Message Queue (formerly MNS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>queue</para>
                /// </summary>
                [NameInMap("mnsType")]
                [Validation(Required=false)]
                public string MnsType { get; set; }

                /// <summary>
                /// <para>Resource name.</para>
                /// <list type="bullet">
                /// <item><description>If the resource type is queue, the resource name is the queue name.</description></item>
                /// <item><description>If the resource type is topic, the resource name is the topic name.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>PagerDuty parameters</para>
            /// </summary>
            [NameInMap("pagerDutyParam")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsPagerDutyParam PagerDutyParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsPagerDutyParam : TeaModel {
                /// <summary>
                /// <para>Integration key for PagerDuty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fsfer4543t5t65g4t4</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>Integration webhook for PagerDuty. Supports V1 and V2 versions.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://events.pagerduty.com/v2/enqueue">https://events.pagerduty.com/v2/enqueue</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>Log Service parameters.</para>
            /// </summary>
            [NameInMap("slsParam")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsSlsParam SlsParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsSlsParam : TeaModel {
                /// <summary>
                /// <para>Logstore name of the Log Service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <para>Log Service project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>Region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>Action integration type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FC</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Webhook parameters</para>
            /// </summary>
            [NameInMap("webhookParam")]
            [Validation(Required=false)]
            public ListAlertActionsResponseBodyAlertActionsWebhookParam WebhookParam { get; set; }
            public class ListAlertActionsResponseBodyAlertActionsWebhookParam : TeaModel {
                /// <summary>
                /// <para>Data format, effective when the request method is POST.</para>
                /// 
                /// <b>Example:</b>
                /// <para>JSON</para>
                /// </summary>
                [NameInMap("contentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>Request headers.</para>
                /// </summary>
                [NameInMap("headers")]
                [Validation(Required=false)]
                public Dictionary<string, string> Headers { get; set; }

                /// <summary>
                /// <para>Webhook request method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GET</para>
                /// </summary>
                [NameInMap("method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The URL address for the alarm callback.</para>
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
        /// <para>Page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
