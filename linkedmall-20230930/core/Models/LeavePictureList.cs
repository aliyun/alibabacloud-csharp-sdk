// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class LeavePictureList : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>退款凭证</para>
        /// </summary>
        [NameInMap("desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>https://</para>
        /// </summary>
        [NameInMap("picture")]
        [Validation(Required=false)]
        public string Picture { get; set; }

    }

}
