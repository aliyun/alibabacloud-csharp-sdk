// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateHoneypotPresetRequest : TeaModel {
        /// <summary>
        /// <para>The name of the image that is used for the honeypot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>metabase</para>
        /// </summary>
        [NameInMap("HoneypotImageName")]
        [Validation(Required=false)]
        public string HoneypotImageName { get; set; }

        /// <summary>
        /// <para>The ID of the honeypot template.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListHoneypotPreset~~">ListHoneypotPreset</a> operation to query the IDs of honeypot templates.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f75eddce-e9d3-4a88-af95-b10b6f65xxxx</para>
        /// </summary>
        [NameInMap("HoneypotPresetId")]
        [Validation(Required=false)]
        public string HoneypotPresetId { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The custom configurations of the honeypot template. The value is a JSON string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>portrait_option</b>: Social Source Tracing</description></item>
        /// <item><description><b>burp</b>: Burp-specific Defense</description></item>
        /// <item><description><b>trojan_git</b>: Git-specific Defense</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;portrait_option&quot;:true,&quot;burp&quot;:&quot;open&quot;}</para>
        /// </summary>
        [NameInMap("Meta")]
        [Validation(Required=false)]
        public string Meta { get; set; }

        /// <summary>
        /// <para>The custom name of the honeypot template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apc_web_python</para>
        /// </summary>
        [NameInMap("PresetName")]
        [Validation(Required=false)]
        public string PresetName { get; set; }

    }

}
