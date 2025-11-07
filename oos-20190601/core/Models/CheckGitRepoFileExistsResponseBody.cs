// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CheckGitRepoFileExistsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FileExists")]
        [Validation(Required=false)]
        public bool? FileExists { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A5320F1D-92D9-44BB-A416-5FC525ED6D57</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
