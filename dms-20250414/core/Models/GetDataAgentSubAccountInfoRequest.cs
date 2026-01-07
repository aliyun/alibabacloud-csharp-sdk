// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetDataAgentSubAccountInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DmsUnit")]
        [Validation(Required=false)]
        public string DmsUnit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20282*****7591</para>
        /// </summary>
        [NameInMap("SubAccountId")]
        [Validation(Required=false)]
        public string SubAccountId { get; set; }

    }

}
