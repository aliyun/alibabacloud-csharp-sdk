// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateHoneypotRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the honeypot image.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListAvailableHoneypot~~">ListAvailableHoneypot</a> operation to query the IDs of images from the <b>HoneypotImageId</b> response parameter.</para>
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
        /// <para>The name of the honeypot image.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListAvailableHoneypot~~">ListAvailableHoneypot</a> operation to query the names of images from the <b>HoneypotImageName</b> response parameter.</para>
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
        /// <para>The custom configuration of the honeypot in the JSON format. The value contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>trojan_git</b>: Git-specific Defense. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zip</b>: Git Source Code Package</description></item>
        /// <item><description><b>web</b>: Git Directory Leak</description></item>
        /// <item><description><b>close</b>: Disabled</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>trojan_git_addr</b>: Git Trojan Address.</para>
        /// </description></item>
        /// <item><description><para><b>trojan_git.zip</b>: Git Trojan.</para>
        /// </description></item>
        /// <item><description><para><b>burp</b>: Burp-specific Defense. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>open</b>: Enable</description></item>
        /// <item><description><b>close</b>: Disable</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>portrait_option</b>: Source Tracing Configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Disable</description></item>
        /// <item><description><b>true</b>: Enable</description></item>
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
        /// <para>The ID of the management node.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListHoneypotNode~~">ListHoneypotNode</a> operation to query the IDs of management nodes.</para>
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
