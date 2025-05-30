// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateHotwordLibraryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>存放名人的词库</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em>a0052ff71efbfd4e7e6c66</em></para>
        /// </summary>
        [NameInMap("HotwordLibraryId")]
        [Validation(Required=false)]
        public string HotwordLibraryId { get; set; }

        [NameInMap("Hotwords")]
        [Validation(Required=false)]
        public List<Hotword> Hotwords { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my_hotwords</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
