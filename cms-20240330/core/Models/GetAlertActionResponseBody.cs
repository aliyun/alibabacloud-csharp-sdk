// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetAlertActionResponseBody : TeaModel {
        [NameInMap("alertActions")]
        [Validation(Required=false)]
        public GetAlertActionResponseBodyAlertActions AlertActions { get; set; }
        public class GetAlertActionResponseBodyAlertActions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>testId</para>
            /// </summary>
            [NameInMap("alertActionId")]
            [Validation(Required=false)]
            public string AlertActionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("alertActionName")]
            [Validation(Required=false)]
            public string AlertActionName { get; set; }

            [NameInMap("ebParam")]
            [Validation(Required=false)]
            public GetAlertActionResponseBodyAlertActionsEbParam EbParam { get; set; }
            public class GetAlertActionResponseBodyAlertActionsEbParam : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ebSource")]
                [Validation(Required=false)]
                public string EbSource { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("eventBusName")]
                [Validation(Required=false)]
                public string EventBusName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-heyuan</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("subject")]
                [Validation(Required=false)]
                public string Subject { get; set; }

            }

            [NameInMap("essParam")]
            [Validation(Required=false)]
            public GetAlertActionResponseBodyAlertActionsEssParam EssParam { get; set; }
            public class GetAlertActionResponseBodyAlertActionsEssParam : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("essGroupId")]
                [Validation(Required=false)]
                public string EssGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("essRuleId")]
                [Validation(Required=false)]
                public string EssRuleId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            [NameInMap("fc3Param")]
            [Validation(Required=false)]
            public GetAlertActionResponseBodyAlertActionsFc3Param Fc3Param { get; set; }
            public class GetAlertActionResponseBodyAlertActionsFc3Param : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("qualifier")]
                [Validation(Required=false)]
                public string Qualifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-qingdao</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            [NameInMap("fcParam")]
            [Validation(Required=false)]
            public GetAlertActionResponseBodyAlertActionsFcParam FcParam { get; set; }
            public class GetAlertActionResponseBodyAlertActionsFcParam : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("service")]
                [Validation(Required=false)]
                public string Service { get; set; }

            }

            [NameInMap("mnsParam")]
            [Validation(Required=false)]
            public GetAlertActionResponseBodyAlertActionsMnsParam MnsParam { get; set; }
            public class GetAlertActionResponseBodyAlertActionsMnsParam : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>queue</para>
                /// </summary>
                [NameInMap("mnsType")]
                [Validation(Required=false)]
                public string MnsType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            [NameInMap("pagerDutyParam")]
            [Validation(Required=false)]
            public GetAlertActionResponseBodyAlertActionsPagerDutyParam PagerDutyParam { get; set; }
            public class GetAlertActionResponseBodyAlertActionsPagerDutyParam : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>EWR4WR4T4GREG4ET453T5Y</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://events.pagerduty.com/v2/enqueue">https://events.pagerduty.com/v2/enqueue</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("slsParam")]
            [Validation(Required=false)]
            public GetAlertActionResponseBodyAlertActionsSlsParam SlsParam { get; set; }
            public class GetAlertActionResponseBodyAlertActionsSlsParam : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FC</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("webhookParam")]
            [Validation(Required=false)]
            public GetAlertActionResponseBodyAlertActionsWebhookParam WebhookParam { get; set; }
            public class GetAlertActionResponseBodyAlertActionsWebhookParam : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>JSON</para>
                /// </summary>
                [NameInMap("contentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                [NameInMap("headers")]
                [Validation(Required=false)]
                public Dictionary<string, string> Headers { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>POST</para>
                /// </summary>
                [NameInMap("method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.test.com">http://www.test.com</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
