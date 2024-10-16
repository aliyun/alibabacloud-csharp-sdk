// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetRoutineStagingCodeUploadInfoRequest : TeaModel {
        [NameInMap("CodeDescription")]
        [Validation(Required=false)]
        public string CodeDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GetRoutineStagingCodeUploadInfo</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
