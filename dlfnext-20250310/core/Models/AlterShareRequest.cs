// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class AlterShareRequest : TeaModel {
        /// <summary>
        /// <para>The comment for the share.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the write permission for the share.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableWrite")]
        [Validation(Required=false)]
        public bool? EnableWrite { get; set; }

        /// <summary>
        /// <para>The name of the share.</para>
        /// 
        /// <b>Example:</b>
        /// <para>share_name</para>
        /// </summary>
        [NameInMap("shareName")]
        [Validation(Required=false)]
        public string ShareName { get; set; }

    }

}
