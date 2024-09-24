// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteMediaInfosResponseBody : TeaModel {
        [NameInMap("ForbiddenList")]
        [Validation(Required=false)]
        public List<string> ForbiddenList { get; set; }

        [NameInMap("IgnoredList")]
        [Validation(Required=false)]
        public List<string> IgnoredList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0622C702-41BE-467E-AF2E-883D4517962E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
