// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetHotwordLibraryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the hotword library.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>96e8864746a0b6f3</b></b></para>
        /// </summary>
        [NameInMap("HotwordLibraryId")]
        [Validation(Required=false)]
        public string HotwordLibraryId { get; set; }

    }

}
