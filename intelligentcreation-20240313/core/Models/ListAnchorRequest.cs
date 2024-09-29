// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class ListAnchorRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PUBLIC_MODEL</para>
        /// </summary>
        [NameInMap("anchorType")]
        [Validation(Required=false)]
        public string AnchorType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9:16</para>
        /// </summary>
        [NameInMap("coverRate")]
        [Validation(Required=false)]
        public string CoverRate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>staticTransparency</para>
        /// </summary>
        [NameInMap("digitalHumanType")]
        [Validation(Required=false)]
        public string DigitalHumanType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>offlineSynthesis</para>
        /// </summary>
        [NameInMap("useScene")]
        [Validation(Required=false)]
        public string UseScene { get; set; }

    }

}
