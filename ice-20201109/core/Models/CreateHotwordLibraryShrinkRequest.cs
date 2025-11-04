// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateHotwordLibraryShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the hotword library. It can be up to 200 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>存放名人的词库</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The hotword list. You can add up to 300 hotword entries to a single library.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Hotwords")]
        [Validation(Required=false)]
        public string HotwordsShrink { get; set; }

        /// <summary>
        /// <para>The name of the hotword library. It can be up to 100 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_hotwords</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The usage scenario of the hotword library. Valid values:</para>
        /// <para>· ASR: Automatic Speech Recognition</para>
        /// <para>· StructuredMediaAssets: structured media analysis</para>
        /// <para>· VideoTranslation: Video translation.</para>
        /// <para>This field cannot be modified after the hotword library is created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASR</para>
        /// </summary>
        [NameInMap("UsageScenario")]
        [Validation(Required=false)]
        public string UsageScenario { get; set; }

    }

}
