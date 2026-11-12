// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class UpdateContactRequest : TeaModel {
        /// <summary>
        /// <para>The JSON character string for channel parameter settings. This parameter is optional. If specified, the settings are updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;channels&quot;:[{&quot;channelType&quot;:&quot;dingtalk&quot;,&quot;clientId&quot;:&quot;xxx&quot;,&quot;clientSecret&quot;:&quot;xxx&quot;,&quot;targetType&quot;:&quot;group&quot;,&quot;targetId&quot;:&quot;xxx&quot;,&quot;robotCode&quot;:&quot;xxx&quot;}]}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The name of the contact to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tom</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable or disable the notification channel for the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The type of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IM</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
