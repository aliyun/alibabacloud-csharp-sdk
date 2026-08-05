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
        /// <item><description>female: female.</description></item>
        /// <item><description>male: male.</description></item>
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
        /// <item><description>story: story.</description></item>
        /// <item><description>interaction: interaction.</description></item>
        /// <item><description>navigation: navigation.</description></item>
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
        /// <item><description>The description cannot exceed 256 characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>This is a personalized voice</para>
        /// </summary>
        [NameInMap("VoiceDesc")]
        [Validation(Required=false)]
        public string VoiceDesc { get; set; }

        /// <summary>
        /// <para>The custom voice ID (English name or pinyin of the voice).</para>
        /// <list type="bullet">
        /// <item><description>The ID cannot be the same as any of your other custom voice IDs.</description></item>
        /// <item><description>The ID cannot exceed 32 characters.</description></item>
        /// <item><description>Only letters and numbers are supported.</description></item>
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
        /// <para>The voice name (generally a Chinese name).</para>
        /// <list type="bullet">
        /// <item><description>The name cannot exceed 32 characters.</description></item>
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
