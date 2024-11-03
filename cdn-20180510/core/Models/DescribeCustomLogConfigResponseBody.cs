// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCustomLogConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The format of the log configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>$time_iso8601_$request_method_$</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94E3559F-7B6A-4A5E-AFFD-44E2A208A249</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The sample.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;[9/Jun/2015:01:58:09 +0800] 188.165.15.75 - 1542 \&quot;-\&quot; \&quot;GEThttp: //<a href="http://www.aliyun.com/index.html%5C%5C">www.aliyun.com/index.html\\</a>&quot; 200</para>
        /// </summary>
        [NameInMap("Sample")]
        [Validation(Required=false)]
        public string Sample { get; set; }

        /// <summary>
        /// <para>The tag information about the log configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>img1</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
