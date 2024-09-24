// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateHoneypotRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the honeypot.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListHoneypot~~">ListHoneypot</a> operation to query the IDs of honeypots.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>945607c2ae2a1a737c04599d6608065688bfc6048d9b9d306ce8dc8191c278b4</para>
        /// </summary>
        [NameInMap("HoneypotId")]
        [Validation(Required=false)]
        public string HoneypotId { get; set; }

        /// <summary>
        /// <para>The custom name of the honeypot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExtMail</para>
        /// </summary>
        [NameInMap("HoneypotName")]
        [Validation(Required=false)]
        public string HoneypotName { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The custom configuration of the honeypot.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListAvailableHoneypot~~">ListAvailableHoneypot</a> operation to query the configurations of honeypots from the <b>Template</b> response parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;burp\&quot;:\&quot;open\&quot;,\&quot;webshell\&quot;:\&quot;open\&quot;,\&quot;trojan_git\&quot;:\&quot;close\&quot;,\&quot;portrait_option\&quot;:\&quot;true\&quot;}</para>
        /// </summary>
        [NameInMap("Meta")]
        [Validation(Required=false)]
        public string Meta { get; set; }

    }

}
