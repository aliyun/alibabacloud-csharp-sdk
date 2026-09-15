// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateHoneypotRequest : TeaModel {
        /// <summary>
        /// <para>The honeypot image ID.</para>
        /// <remarks>
        /// <para>You can obtain this value from the <b>HoneypotImageId</b> field returned by the <a href="~~ListAvailableHoneypot~~">ListAvailableHoneypot</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sha256:ebc4c102ac407d53733c2373e8888a733ddce86f163ccbe7492ae1cbf26****</para>
        /// </summary>
        [NameInMap("HoneypotImageId")]
        [Validation(Required=false)]
        public string HoneypotImageId { get; set; }

        /// <summary>
        /// <para>The honeypot image name.</para>
        /// <remarks>
        /// <para>You can obtain this value from the <b>HoneypotImageName</b> field returned by the <a href="~~ListAvailableHoneypot~~">ListAvailableHoneypot</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HoneyPotImageName</para>
        /// </summary>
        [NameInMap("HoneypotImageName")]
        [Validation(Required=false)]
        public string HoneypotImageName { get; set; }

        /// <summary>
        /// <para>The custom name of the honeypot.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ruoyi</para>
        /// </summary>
        [NameInMap("HoneypotName")]
        [Validation(Required=false)]
        public string HoneypotName { get; set; }

        /// <summary>
        /// <para>The custom configuration of the honeypot in JSON format. The following fields are included:</para>
        /// <list type="bullet">
        /// <item><description><b>trojan_git</b>: The Git counter-intelligence method. Valid values:<list type="bullet">
        /// <item><description><b>zip</b>: Git source code package.</description></item>
        /// <item><description><b>web</b>: .git folder leak.</description></item>
        /// <item><description><b>close</b>: Shutdown.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>trojan_git_addr</b>: The Git counter-intelligence endpoint.</description></item>
        /// <item><description><b>trojan_git.zip</b>: The Git counter-intelligence trojan package.</description></item>
        /// <item><description><b>burp</b>: The Burp counter-intelligence method. Valid values:<list type="bullet">
        /// <item><description><b>open</b>: Enabled.</description></item>
        /// <item><description><b>close</b>: Shutdown.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>portrait_option</b>: The tracing configuration. Valid values:<list type="bullet">
        /// <item><description><b>false</b>: Shutdown.</description></item>
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;trojan_git\&quot;:\&quot;close\&quot;,\&quot;burp\&quot;:\&quot;close\&quot;,\&quot;portrait_option\&quot;:\&quot;false\&quot;}</para>
        /// </summary>
        [NameInMap("Meta")]
        [Validation(Required=false)]
        public string Meta { get; set; }

        /// <summary>
        /// <para>The ID of the honeypot management node.</para>
        /// <remarks>
        /// <para>Call the <a href="~~ListHoneypotNode~~">ListHoneypotNode</a> operation to obtain this value.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a882e590-b87b-45a6-87b9-d0a3e5a0****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

    }

}
