// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateAppNotificationSceneRequest : TeaModel {
        /// <summary>
        /// <para>The business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250703155602000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The notification channels in a JSON array string, such as [&quot;sms&quot;,&quot;email&quot;].</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;sms&quot;,&quot;email&quot;]</para>
        /// </summary>
        [NameInMap("ChannelsJson")]
        [Validation(Required=false)]
        public string ChannelsJson { get; set; }

        /// <summary>
        /// <para>The description of the scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn_graph_prod</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The email notification fields in a JSON array string. A maximum of 10 fields are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("EmailFieldsJson")]
        [Validation(Required=false)]
        public string EmailFieldsJson { get; set; }

        /// <summary>
        /// <para>The email sending limit in a JSON string, including the minInterval and dailyLimit fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("EmailLimitJson")]
        [Validation(Required=false)]
        public string EmailLimitJson { get; set; }

        /// <summary>
        /// <para>The list of email recipient IDs in a JSON array string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("EmailRecipientIdsJson")]
        [Validation(Required=false)]
        public string EmailRecipientIdsJson { get; set; }

        /// <summary>
        /// <para>The name of the scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>设备能力手册</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of SMS recipient IDs in a JSON array string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("PhoneRecipientIdsJson")]
        [Validation(Required=false)]
        public string PhoneRecipientIdsJson { get; set; }

        /// <summary>
        /// <para>The SMS notification fields in a JSON array string. A maximum of 3 fields are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("SmsFieldsJson")]
        [Validation(Required=false)]
        public string SmsFieldsJson { get; set; }

        /// <summary>
        /// <para>The SMS sending limit in a JSON string, including the minInterval and dailyLimit fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("SmsLimitJson")]
        [Validation(Required=false)]
        public string SmsLimitJson { get; set; }

        /// <summary>
        /// <para>The name of the monitored data table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default.ai_advertising_material_rec_train_v1103</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The trigger events in a JSON array string, such as [&quot;INSERT&quot;,&quot;UPDATE&quot;,&quot;DELETE&quot;].</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;INSERT&quot;,&quot;UPDATE&quot;,&quot;DELETE&quot;]</para>
        /// </summary>
        [NameInMap("TriggerEventsJson")]
        [Validation(Required=false)]
        public string TriggerEventsJson { get; set; }

    }

}
