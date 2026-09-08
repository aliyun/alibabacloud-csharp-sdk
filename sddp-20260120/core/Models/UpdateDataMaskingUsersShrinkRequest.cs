// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class UpdateDataMaskingUsersShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>fullAccess</para>
        /// </summary>
        [NameInMap("AuthRole")]
        [Validation(Required=false)]
        public string AuthRole { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2145953410000</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PRESERVE</para>
        /// </summary>
        [NameInMap("ExpireTimeOperation")]
        [Validation(Required=false)]
        public string ExpireTimeOperation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        [NameInMap("UserList")]
        [Validation(Required=false)]
        public string UserListShrink { get; set; }

    }

}
