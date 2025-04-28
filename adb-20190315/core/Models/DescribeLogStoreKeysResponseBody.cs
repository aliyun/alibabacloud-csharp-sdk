// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeLogStoreKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried log keywords.</para>
        /// </summary>
        [NameInMap("LogStoreKeys")]
        [Validation(Required=false)]
        public DescribeLogStoreKeysResponseBodyLogStoreKeys LogStoreKeys { get; set; }
        public class DescribeLogStoreKeysResponseBodyLogStoreKeys : TeaModel {
            [NameInMap("LogStoreKey")]
            [Validation(Required=false)]
            public List<string> LogStoreKey { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3BB185E9-BB54-1727-B876-13243E4C0EB5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
