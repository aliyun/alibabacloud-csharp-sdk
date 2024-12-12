// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryCopyrightJobListRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1627357325</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public long? CreateTimeEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1627357322</para>
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public long? CreateTimeStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>cdb3e74639973036bc84</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
