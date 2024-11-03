// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainCustomLogConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the log configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

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
        /// <para>The sample log configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[9/Jun/2015:01:58:09+0800]188.165.15.75-1542\&quot;-\&quot;\&quot;GET <a href="http://www.aliyun.com/index.html%5C%5C">http://www.aliyun.com/index.html\\</a></para>
        /// </summary>
        [NameInMap("Sample")]
        [Validation(Required=false)]
        public string Sample { get; set; }

        /// <summary>
        /// <para>The tag information about the log configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>book</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
