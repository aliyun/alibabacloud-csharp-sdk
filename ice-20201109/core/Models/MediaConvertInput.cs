// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertInput : TeaModel {
        /// <summary>
        /// <para>The input file.</para>
        /// </summary>
        [NameInMap("InputFile")]
        [Validation(Required=false)]
        public MediaObject InputFile { get; set; }

        /// <summary>
        /// <para>The name of the input file. If Output contains InputRef, use this name to reference the input file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputVideo</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
