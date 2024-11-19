// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnFullDomainsBlockIPConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <para>The value of Code is not 0 in the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>The format of the IP address is invalid.</description></item>
        /// <item><description>The number of IP addresses exceeds the upper limit.</description></item>
        /// <item><description>Other abnormal scenarios.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned results. If the operation is successful, URLs of OSS objects are returned. If the operation fails, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxxx-api.oss-cn-hangzhou.aliyuncs.com/blocklist%2Fxxxxxxxxxxxx.txt?Expires=1682663947&OSSAccessKeyId=xxxxxxxxxx&Signature=xxxxxx">http://xxxx-api.oss-cn-hangzhou.aliyuncs.com/blocklist%2Fxxxxxxxxxxxx.txt?Expires=1682663947&amp;OSSAccessKeyId=xxxxxxxxxx&amp;Signature=xxxxxx</a></para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95994621-8382-464B-8762-C708E73568D1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
