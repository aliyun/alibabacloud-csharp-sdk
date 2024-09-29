// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetAgentDownloadUrlV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.\
        /// <b>Valid values:</b></para>
        /// <list type="bullet">
        /// <item><description>2xx: The request was successful.</description></item>
        /// <item><description>3xx: The request was redirected.</description></item>
        /// <item><description>4xx: The request was invalid.</description></item>
        /// <item><description>5xx: A server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The version number and download URL of the agent.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAgentDownloadUrlV2ResponseBodyData Data { get; set; }
        public class GetAgentDownloadUrlV2ResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The download URL of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://arms-apm-cn-hangzhou.oss-cn-hangzhou-internal.aliyuncs.com/3.2.9/ArmsAgent.zip">http://arms-apm-cn-hangzhou.oss-cn-hangzhou-internal.aliyuncs.com/3.2.9/ArmsAgent.zip</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>The version number of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.2.9</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78901766-3806-4E96-8E47-CFEF59E4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.\
        /// <b>Valid values:</b></para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
