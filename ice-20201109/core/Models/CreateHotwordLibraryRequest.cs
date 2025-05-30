// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateHotwordLibraryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>存放名人的词库</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Hotwords")]
        [Validation(Required=false)]
        public List<Hotword> Hotwords { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_hotwords</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
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
