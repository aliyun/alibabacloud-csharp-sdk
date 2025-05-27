// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EduEmbed20240101.Models
{
    public class PageListLabSessionsRequest : TeaModel {
        [NameInMap("Finished")]
        [Validation(Required=false)]
        public bool? Finished { get; set; }

        [NameInMap("LabId")]
        [Validation(Required=false)]
        public long? LabId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RamAccountId")]
        [Validation(Required=false)]
        public long? RamAccountId { get; set; }

    }

}
