// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteLiveStreamTranscodeRequest : TeaModel {
        /// <summary>
        /// <para>The AppName of the live stream.</para>
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
        /// <item><description><para>lld: low definition</para>
        /// </description></item>
        /// <item><description><para>lsd: standard definition</para>
        /// </description></item>
        /// <item><description><para>lhd: high definition</para>
        /// </description></item>
        /// <item><description><para>lud : ultra-high definition</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Narrowband HD™ transcoding:</para>
        /// <list type="bullet">
        /// <item><description><para>ld: low definition</para>
        /// </description></item>
        /// <item><description><para>sd: standard definition</para>
        /// </description></item>
        /// <item><description><para>hd: high definition</para>
        /// </description></item>
        /// <item><description><para>ud: ultra-high definition</para>
        /// </description></item>
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
