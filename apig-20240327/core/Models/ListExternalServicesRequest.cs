// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListExternalServicesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("importableOnly")]
        [Validation(Required=false)]
        public bool? ImportableOnly { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>imah</para>
        /// </summary>
        [NameInMap("nameLike")]
        [Validation(Required=false)]
        public string NameLike { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>667435</para>
        /// </summary>
        [NameInMap("paiWorkspaceId")]
        [Validation(Required=false)]
        public string PaiWorkspaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FC3</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
