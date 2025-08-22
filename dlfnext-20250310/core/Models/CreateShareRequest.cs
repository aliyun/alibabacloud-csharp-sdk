// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class CreateShareRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("enableWrite")]
        [Validation(Required=false)]
        public bool? EnableWrite { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>share_name</para>
        /// </summary>
        [NameInMap("shareName")]
        [Validation(Required=false)]
        public string ShareName { get; set; }

    }

}
