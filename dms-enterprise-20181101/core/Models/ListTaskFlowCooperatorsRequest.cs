// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowCooperatorsRequest : TeaModel {
        /// <summary>
        /// The username.
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
