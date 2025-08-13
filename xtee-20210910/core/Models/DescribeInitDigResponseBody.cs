// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeInitDigResponseBody : TeaModel {
        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result information</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeInitDigResponseBodyResultObject ResultObject { get; set; }
        public class DescribeInitDigResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Prompt information</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云内部测试</para>
            /// </summary>
            [NameInMap("TipInfo")]
            [Validation(Required=false)]
            public string TipInfo { get; set; }

        }

    }

}
