// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ClearLogStoreStorageRequest : TeaModel {
        /// <summary>
        /// <para>The name of the site. If you have only one Logstore, you can leave this parameter empty. If you have two Logstores, set this parameter to cn or intl.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("Site")]
        [Validation(Required=false)]
        public string Site { get; set; }

    }

}
