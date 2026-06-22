// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ClearLogStoreStorageRequest : TeaModel {
        /// <summary>
        /// <para>The site name for which to clear logs. If only one logStore exists, you can leave this parameter empty. If two logStores exist, set this parameter to cn or intl.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("Site")]
        [Validation(Required=false)]
        public string Site { get; set; }

    }

}
