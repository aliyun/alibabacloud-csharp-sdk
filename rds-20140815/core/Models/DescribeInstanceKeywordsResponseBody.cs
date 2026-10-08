// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeInstanceKeywordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of reserved keywords, which indicates whether the reserved keywords are for account names or database names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>account</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E43AAE0-BEE8-43DA-860D-EAF2AA0724DC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Words")]
        [Validation(Required=false)]
        public DescribeInstanceKeywordsResponseBodyWords Words { get; set; }
        public class DescribeInstanceKeywordsResponseBodyWords : TeaModel {
            [NameInMap("word")]
            [Validation(Required=false)]
            public List<string> Word { get; set; }

        }

    }

}
