// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateDatasetJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dsjob-9jx1******uj9e</para>
        /// </summary>
        [NameInMap("DatasetJobId")]
        [Validation(Required=false)]
        public string DatasetJobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>99341606-****-0757724D97EE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
