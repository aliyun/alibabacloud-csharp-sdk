// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateAlertActionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("alertActionName")]
        [Validation(Required=false)]
        public string AlertActionName { get; set; }

        [NameInMap("ebParam")]
        [Validation(Required=false)]
        public UpdateAlertActionRequestEbParam EbParam { get; set; }
        public class UpdateAlertActionRequestEbParam : TeaModel {
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
        public UpdateAlertActionRequestEssParam EssParam { get; set; }
        public class UpdateAlertActionRequestEssParam : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>testId</para>
            /// </summary>
            [NameInMap("essGroupId")]
            [Validation(Required=false)]
            public string EssGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testId</para>
            /// </summary>
            [NameInMap("essRuleId")]
            [Validation(Required=false)]
            public string EssRuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("fc3Param")]
        [Validation(Required=false)]
        public UpdateAlertActionRequestFc3Param Fc3Param { get; set; }
        public class UpdateAlertActionRequestFc3Param : TeaModel {
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
            /// <para>cn-heyuan</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("fcParam")]
        [Validation(Required=false)]
        public UpdateAlertActionRequestFcParam FcParam { get; set; }
        public class UpdateAlertActionRequestFcParam : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("function")]
            [Validation(Required=false)]
            public string Function { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testService</para>
            /// </summary>
            [NameInMap("service")]
            [Validation(Required=false)]
            public string Service { get; set; }

        }

        [NameInMap("mnsParam")]
        [Validation(Required=false)]
        public UpdateAlertActionRequestMnsParam MnsParam { get; set; }
        public class UpdateAlertActionRequestMnsParam : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>queue</para>
            /// </summary>
            [NameInMap("mnsType")]
            [Validation(Required=false)]
            public string MnsType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("pagerDutyParam")]
        [Validation(Required=false)]
        public UpdateAlertActionRequestPagerDutyParam PagerDutyParam { get; set; }
        public class UpdateAlertActionRequestPagerDutyParam : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>fwe4rwr543t543t43t43t43</para>
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
        public UpdateAlertActionRequestSlsParam SlsParam { get; set; }
        public class UpdateAlertActionRequestSlsParam : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>testLogstore</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testProject</para>
            /// </summary>
            [NameInMap("project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
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
        public UpdateAlertActionRequestWebhookParam WebhookParam { get; set; }
        public class UpdateAlertActionRequestWebhookParam : TeaModel {
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

}
