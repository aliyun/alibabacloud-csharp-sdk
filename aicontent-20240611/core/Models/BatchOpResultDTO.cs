// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class BatchOpResultDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("failed")]
        [Validation(Required=false)]
        public List<BatchFailedItemDTO> Failed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("succeeded")]
        [Validation(Required=false)]
        public List<long?> Succeeded { get; set; }

    }

}
