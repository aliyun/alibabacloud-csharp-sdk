// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ListUserCustomLogConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of log configuration IDs.</para>
        /// </summary>
        [NameInMap("ConfigIds")]
        [Validation(Required=false)]
        public ListUserCustomLogConfigResponseBodyConfigIds ConfigIds { get; set; }
        public class ListUserCustomLogConfigResponseBodyConfigIds : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public List<string> ConfigId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95D5B69F-8AEC-419B-8F3A-612B35032B0D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
