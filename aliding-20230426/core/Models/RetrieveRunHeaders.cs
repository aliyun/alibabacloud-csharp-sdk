// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class RetrieveRunHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

    }

}
