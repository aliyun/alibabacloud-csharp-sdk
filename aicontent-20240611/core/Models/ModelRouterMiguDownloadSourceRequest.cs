// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterMiguDownloadSourceRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the source file. This is the sourceId returned by the upload operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f2a1b9c8d7e4f60a1b2c3d4e5f6a7b8</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

    }

}
