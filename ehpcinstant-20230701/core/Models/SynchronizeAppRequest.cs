// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class SynchronizeAppRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ci-vm-rYfypJKwlN9Y</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The list of arrays that are synchronized to the specified region. If \&quot;all\&quot; is included, it is synchronized to all other unsynchronized regions by default.</para>
        /// </summary>
        [NameInMap("TargetRegionIds")]
        [Validation(Required=false)]
        public List<string> TargetRegionIds { get; set; }

    }

}
