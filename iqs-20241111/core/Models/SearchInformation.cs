// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class SearchInformation : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>700</para>
        /// </summary>
        [NameInMap("searchTime")]
        [Validation(Required=false)]
        public long? SearchTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
