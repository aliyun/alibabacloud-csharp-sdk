// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteLiveStreamTranscodeRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The main streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The transcoding template ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard transcoding:</para>
        /// <list type="bullet">
        /// <item><description>lld: low definition</description></item>
        /// <item><description>lsd: standard definition</description></item>
        /// <item><description>lhd: high definition</description></item>
        /// <item><description>lud : ultra-high definition</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Narrowband HD™ transcoding:</para>
        /// <list type="bullet">
        /// <item><description>ld: low definition</description></item>
        /// <item><description>sd: standard definition</description></item>
        /// <item><description>hd: high definition</description></item>
        /// <item><description>ud: ultra-high definition</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Custom transcoding: a custom ID</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lld</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

    }

}
