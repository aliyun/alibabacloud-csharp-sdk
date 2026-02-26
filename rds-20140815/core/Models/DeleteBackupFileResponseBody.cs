// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DeleteBackupFileResponseBody : TeaModel {
        [NameInMap("DeletedBaksetIds")]
        [Validation(Required=false)]
        public DeleteBackupFileResponseBodyDeletedBaksetIds DeletedBaksetIds { get; set; }
        public class DeleteBackupFileResponseBodyDeletedBaksetIds : TeaModel {
            [NameInMap("DeletedBaksetIds")]
            [Validation(Required=false)]
            public List<int?> DeletedBaksetIds { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7B3A91C-0ACD-4948-ACAE-xxxxxxxD4069</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
