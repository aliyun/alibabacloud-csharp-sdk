// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class GetDestinationCidrBlockResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Response content</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetDestinationCidrBlockResponseBodyContent Content { get; set; }
        public class GetDestinationCidrBlockResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>List of destination CIDR block information for the current network instance</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public List<string> DestinationCidrBlock { get; set; }

        }

        /// <summary>
        /// <para>Error message. (Indicates the reason for the anomaly when the instance status is abnormal.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>ID of this request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D349EE86-AF3F-5F6C-87E2-2A08D3618350</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
