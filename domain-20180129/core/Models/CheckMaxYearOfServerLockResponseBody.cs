// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class CheckMaxYearOfServerLockResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxYear")]
        [Validation(Required=false)]
        public int? MaxYear { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9DFCF6F8-243C-****-8035-4B12FEFD7D48</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
