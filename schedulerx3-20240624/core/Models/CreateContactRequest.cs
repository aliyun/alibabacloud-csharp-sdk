// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class CreateContactRequest : TeaModel {
        /// <summary>
        /// <para>The JSON character string for channel parameter settings. Example for the IM type: {&quot;channels&quot;:[{&quot;channelType&quot;:&quot;dingtalk&quot;,&quot;clientId&quot;:&quot;xxx&quot;,&quot;clientSecret&quot;:&quot;xxx&quot;,&quot;targetType&quot;:&quot;group&quot;,&quot;targetId&quot;:&quot;xxx&quot;,&quot;robotCode&quot;:&quot;xxx&quot;}]}</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;channels&quot;:[{&quot;channelType&quot;:&quot;dingtalk&quot;,&quot;clientId&quot;:&quot;xxx&quot;,&quot;clientSecret&quot;:&quot;xxx&quot;,&quot;targetType&quot;:&quot;group&quot;,&quot;targetId&quot;:&quot;xxx&quot;,&quot;robotCode&quot;:&quot;xxx&quot;}]}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The name of the alert contact.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Chen Rui</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>The contact type.</para>
        /// <list type="bullet">
        /// <item><description>IM: Configures an IM channel notification contact.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IM</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
