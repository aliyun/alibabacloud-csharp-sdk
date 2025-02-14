// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPolicyClassesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Operation</para>
        /// </summary>
        [NameInMap("attachResourceType")]
        [Validation(Required=false)]
        public string AttachResourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InBound</para>
        /// </summary>
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

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
        /// <para>FlowControl</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
