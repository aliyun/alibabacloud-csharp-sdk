// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class GetScenePreviewResourceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Draft")]
        [Validation(Required=false)]
        public bool? Draft { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2deb941b3e1****</para>
        /// </summary>
        [NameInMap("PreviewToken")]
        [Validation(Required=false)]
        public string PreviewToken { get; set; }

    }

}
