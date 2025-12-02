// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class UpdateApsWebhookRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleDBClusterId</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleRegionId</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The array of webhooks.</para>
        /// </summary>
        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public List<UpdateApsWebhookRequestWebhook> Webhook { get; set; }
        public class UpdateApsWebhookRequestWebhook : TeaModel {
            /// <summary>
            /// <para>Signed key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ABC**</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The name of the webhook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleWebhookName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The URL of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/webhook">https://example.com/webhook</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>The ID of the webhook.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b>355</b>**</para>
            /// </summary>
            [NameInMap("WebhookId")]
            [Validation(Required=false)]
            public long? WebhookId { get; set; }

            /// <summary>
            /// <para>The notification method. Valid values: dingtalk. lark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dingtalk</para>
            /// </summary>
            [NameInMap("WebhookType")]
            [Validation(Required=false)]
            public string WebhookType { get; set; }

        }

    }

}
