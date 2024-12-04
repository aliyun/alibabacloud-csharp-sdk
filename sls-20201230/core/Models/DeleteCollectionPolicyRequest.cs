// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class DeleteCollectionPolicyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>access_log</para>
        /// </summary>
        [NameInMap("dataCode")]
        [Validation(Required=false)]
        public string DataCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
