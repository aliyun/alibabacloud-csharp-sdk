// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListAccountAccessIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAccountAccessIdResponseBodyData> Data { get; set; }
        public class ListAccountAccessIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The bound AccessKeyId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ABCXXXXXXXX</para>
            /// </summary>
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            /// <summary>
            /// <para>The MD5 value of the multi-cloud AccessKeyId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcXXXXXXXX</para>
            /// </summary>
            [NameInMap("AccessIdMd5")]
            [Validation(Required=false)]
            public string AccessIdMd5 { get; set; }

            /// <summary>
            /// <para>The cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xxxxxxx</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The account information of the multi-cloud AccessKeyId. The format is Alibaba Cloud account ID|Alibaba Cloud account name|multi-cloud AccessKeyId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xxxxxx|xxxx|ABCXXXXX</para>
            /// </summary>
            [NameInMap("AccountStr")]
            [Validation(Required=false)]
            public string AccountStr { get; set; }

            /// <summary>
            /// <para>Indicates whether the AccessKeyId is bound to threat detection and response. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Not bound.</description></item>
            /// <item><description>1: Bound.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Bound")]
            [Validation(Required=false)]
            public int? Bound { get; set; }

            /// <summary>
            /// <para>The code of the multi-cloud provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hcloud</para>
            /// </summary>
            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID that corresponds to the multi-cloud AccessKeyId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ABCXXXXXXXX</para>
            /// </summary>
            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

        }

        /// <summary>
        /// <para>The returned message description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
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
