// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class RenamePlaybookNodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned new name of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_process</para>
        /// </summary>
        [NameInMap("RenameResult")]
        [Validation(Required=false)]
        public string RenameResult { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E1EC464-3BD7-518F-9937-BCC12E6855FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
