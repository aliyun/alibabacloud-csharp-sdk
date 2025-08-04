// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListIndexFileDetailsRequest : TeaModel {
        [NameInMap("DocumentName")]
        [Validation(Required=false)]
        public string DocumentName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FINISH</para>
        /// </summary>
        [NameInMap("DocumentStatus")]
        [Validation(Required=false)]
        public string DocumentStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableNameLike")]
        [Validation(Required=false)]
        public string EnableNameLike { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>79c0alxxxx</para>
        /// </summary>
        [NameInMap("IndexId")]
        [Validation(Required=false)]
        public string IndexId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
