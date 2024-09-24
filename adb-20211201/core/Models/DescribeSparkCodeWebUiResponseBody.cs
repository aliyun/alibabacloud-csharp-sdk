// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSparkCodeWebUiResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, <b>SUCCESS</b> is returned.</description></item>
        /// <item><description>If the request failed, an error message is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>774DDC37-1908-58F6-B9CA-99E3E45965A6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The URL of the web UI for the Spark application.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://adb-subuser-cn-hangzhou-1358535755648527-100000648.oss-cn-hangzhou.aliyuncs.com/%3Facl?Expires=1681295967&OSSAccessKeyId=LTAI5tB7NAkm25oiGASu****&Signature=hKAZ1vgvhJ%2FD8hNHTuX%2FOOBWht">https://adb-subuser-cn-hangzhou-1358535755648527-100000648.oss-cn-hangzhou.aliyuncs.com/%3Facl?Expires=1681295967&amp;OSSAccessKeyId=LTAI5tB7NAkm25oiGASu****&amp;Signature=hKAZ1vgvhJ%2FD8hNHTuX%2FOOBWht</a>****</para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
