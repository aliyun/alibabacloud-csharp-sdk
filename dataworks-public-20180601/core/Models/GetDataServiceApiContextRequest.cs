// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class GetDataServiceApiContextRequest : TeaModel {
        /// <summary>
        /// apiId
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public long? ApiId { get; set; }

        [NameInMap("ApiStatus")]
        [Validation(Required=false)]
        public int? ApiStatus { get; set; }

        [NameInMap("CacheKey")]
        [Validation(Required=false)]
        public string CacheKey { get; set; }

        [NameInMap("ForPrivateResGroup")]
        [Validation(Required=false)]
        public bool? ForPrivateResGroup { get; set; }

        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

    }

}
