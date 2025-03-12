// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateBackupSetDownloadLinkResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10000***67</para>
        /// </summary>
        [NameInMap("DownloadTaskId")]
        [Validation(Required=false)]
        public long? DownloadTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
