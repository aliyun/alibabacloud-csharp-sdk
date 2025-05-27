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
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAccountAccessIdResponseBodyData> Data { get; set; }
        public class ListAccountAccessIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID of the cloud account that is added to the threat analysis feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ABCXXXXXXXX</para>
            /// </summary>
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            /// <summary>
            /// <para>The MD5 hash value of the AccessKey ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcXXXXXXXX</para>
            /// </summary>
            [NameInMap("AccessIdMd5")]
            [Validation(Required=false)]
            public string AccessIdMd5 { get; set; }

            /// <summary>
            /// <para>The ID of the cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xxxxxxx</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The information about the cloud account to which the AccessKey ID belongs. The value is in the following format: Alibaba Cloud account ID|Alibaba Cloud account username|AccessKey ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xxxxxx|xxxx|ABCXXXXX</para>
            /// </summary>
            [NameInMap("AccountStr")]
            [Validation(Required=false)]
            public string AccountStr { get; set; }

            /// <summary>
            /// <para>Indicates whether the cloud account to which the AccessKey ID belongs is added to the threat analysis feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: no</description></item>
            /// <item><description>1: yes</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Bound")]
            [Validation(Required=false)]
            public int? Bound { get; set; }

            /// <summary>
            /// <para>The code of the cloud service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hcloud</para>
            /// </summary>
            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that is used to add the third-party cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ABCXXXXXXXX</para>
            /// </summary>
            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
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
