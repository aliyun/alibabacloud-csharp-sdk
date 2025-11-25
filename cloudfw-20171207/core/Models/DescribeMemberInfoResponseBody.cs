// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeMemberInfoResponseBody : TeaModel {
        [NameInMap("AdminName")]
        [Validation(Required=false)]
        public string AdminName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>164705101205****</para>
        /// </summary>
        [NameInMap("AdminUid")]
        [Validation(Required=false)]
        public string AdminUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsMember")]
        [Validation(Required=false)]
        public bool? IsMember { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>128720273643****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F2665618-3C41-51A4-8DAF-586FB68****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
