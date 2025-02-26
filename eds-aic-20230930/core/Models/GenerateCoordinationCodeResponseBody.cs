// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class GenerateCoordinationCodeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>CSHGDK</para>
        /// </summary>
        [NameInMap("CoordinatorCode")]
        [Validation(Required=false)]
        public string CoordinatorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1A923337-44D9-5CAD-9A53-95084BD4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
