// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetTensorboardRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc-xxxxxxxx</para>
        /// </summary>
        [NameInMap("JodId")]
        [Validation(Required=false)]
        public string JodId { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>46099</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
