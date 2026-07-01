// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateCustomizedVoiceJobRequest : TeaModel {
        /// <summary>
        /// <para>The gender. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>female</para>
        /// </description></item>
        /// <item><description><para>male</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>female</para>
        /// </summary>
        [NameInMap("Gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// <para>The scenario. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>story</para>
        /// </description></item>
        /// <item><description><para>interaction</para>
        /// </description></item>
        /// <item><description><para>navigation</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>story</para>
        /// </summary>
        [NameInMap("Scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

        /// <summary>
        /// <para>The voice description.</para>
        /// <list type="bullet">
        /// <item><description>Must be 256 characters or fewer.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>这是一个个性化声音</para>
        /// </summary>
        [NameInMap("VoiceDesc")]
        [Validation(Required=false)]
        public string VoiceDesc { get; set; }

        /// <summary>
        /// <para>The custom voice ID. This is typically an English name or Pinyin.</para>
        /// <list type="bullet">
        /// <item><description><para>Must be unique among your other custom voices.</para>
        /// </description></item>
        /// <item><description><para>Must be 32 characters or fewer.</para>
        /// </description></item>
        /// <item><description><para>Can contain only letters and numbers.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xiaozhuan</para>
        /// </summary>
        [NameInMap("VoiceId")]
        [Validation(Required=false)]
        public string VoiceId { get; set; }

        /// <summary>
        /// <para>The voice name, typically in Chinese.</para>
        /// <list type="bullet">
        /// <item><description>Must be 32 characters or fewer.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>小专</para>
        /// </summary>
        [NameInMap("VoiceName")]
        [Validation(Required=false)]
        public string VoiceName { get; set; }

    }

}
