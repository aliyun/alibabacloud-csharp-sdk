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
            /// <para>The attached AccessKey ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ABCXXXXXXXX</para>
            /// </summary>
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            /// <summary>
            /// <para>The MD5 value of the multicloud AccessKey ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcXXXXXXXX</para>
            /// </summary>
            [NameInMap("AccessIdMd5")]
            [Validation(Required=false)]
            public string AccessIdMd5 { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xxxxxxx</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The information of the account to which the multicloud AccessKey ID belongs. The format is: Alibaba Cloud account ID|Alibaba Cloud account name|Multicloud AccessKey ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xxxxxx|xxxx|ABCXXXXX</para>
            /// </summary>
            [NameInMap("AccountStr")]
            [Validation(Required=false)]
            public string AccountStr { get; set; }

            /// <summary>
            /// <para>Indicates whether the AccessKey ID is attached to threat analysis. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: Not attached.</para>
            /// </description></item>
            /// <item><description><para>1: Attached.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Bound")]
            [Validation(Required=false)]
            public int? Bound { get; set; }

            /// <summary>
            /// <para>The code for the multicloud environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hcloud</para>
            /// </summary>
            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that corresponds to the multicloud AccessKey ID.</para>
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
        /// <para>The ID of the request.</para>
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
        /// <item><description><para>true: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
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
