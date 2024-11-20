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
        /// <item><description>female</description></item>
        /// <item><description>male</description></item>
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
        /// <item><description>story</description></item>
        /// <item><description>interaction</description></item>
        /// <item><description>navigation</description></item>
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
        /// <item><description>The description can be up to 256 characters in length.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("VoiceDesc")]
        [Validation(Required=false)]
        public string VoiceDesc { get; set; }

        /// <summary>
        /// <para>The voice ID. It can be the English name or Chinese Pinyin of the voice.</para>
        /// <list type="bullet">
        /// <item><description>The value must be a unique ID that is not used by other custom voices.</description></item>
        /// <item><description>The ID can be up to 32 characters in length.</description></item>
        /// <item><description>Only letters and digits are supported.</description></item>
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
        /// <para>The voice name.</para>
        /// <list type="bullet">
        /// <item><description>The name can be up to 32 characters in length.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("VoiceName")]
        [Validation(Required=false)]
        public string VoiceName { get; set; }

    }

}
