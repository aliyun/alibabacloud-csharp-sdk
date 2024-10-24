// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class Member : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ken_12345</para>
        /// </summary>
        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WorkspaceAdmin</para>
        /// </summary>
        [NameInMap("MemberType")]
        [Validation(Required=false)]
        public string MemberType { get; set; }

    }

}
