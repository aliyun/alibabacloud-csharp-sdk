// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CancelActiveOperationTasksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1508850,1508310,1507849,1506274,1505811</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>55A2504F-xxxx-xxxx-xxxx-C7C5E57350A6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
