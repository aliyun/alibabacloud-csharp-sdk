// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class CreateTextFileAdvanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>e9a93201-7e96-4dc1-9678-2832fc132d08</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1714476549</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("TextFileName")]
        [Validation(Required=false)]
        public string TextFileName { get; set; }

        [NameInMap("TextFileUrl")]
        [Validation(Required=false)]
        public Stream TextFileUrlObject { get; set; }

    }

}
