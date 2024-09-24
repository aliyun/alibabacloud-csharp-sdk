// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSparkCodeOutputResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, <b>Success</b> is returned.</description></item>
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
        /// <para>The execution result, which is in the format of JSON objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;schema\&quot;:[\&quot;id\&quot;,\&quot;name\&quot;,\&quot;age\&quot;],\&quot;data\&quot;:[\&quot;{\\\&quot;id\\\&quot;:10,\\\&quot;name\\\&quot;:\\\&quot;z\\\&quot;,\\\&quot;age\\\&quot;:123}\&quot;,\&quot;{\\\&quot;id\\\&quot;:2,\\\&quot;name\\\&quot;:\\\&quot;b\\\&quot;,\\\&quot;age\\\&quot;:17}\&quot;,\&quot;{\\\&quot;id\\\&quot;:1,\\\&quot;name\\\&quot;:\\\&quot;a\\\&quot;,\\\&quot;age\\\&quot;:15}\&quot;,\&quot;{\\\&quot;id\\\&quot;:3,\\\&quot;name\\\&quot;:\\\&quot;c\\\&quot;,\\\&quot;age\\\&quot;:222}\&quot;,\&quot;{\\\&quot;id\\\&quot;:10,\\\&quot;name\\\&quot;:\\\&quot;z\\\&quot;,\\\&quot;age\\\&quot;:123}\&quot;],\&quot;haveRows\&quot;:true,\&quot;rowNumber\&quot;:6}&quot;</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
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

    }

}
