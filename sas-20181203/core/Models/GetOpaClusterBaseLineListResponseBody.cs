// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOpaClusterBaseLineListResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The status code <b>200</b> indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about baselines.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOpaClusterBaseLineListResponseBodyData> Data { get; set; }
        public class GetOpaClusterBaseLineListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The alias of the baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Make sure there are no duplicate usernames or UIDs</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The key of the baseline type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>identification</para>
            /// </summary>
            [NameInMap("ClassKey")]
            [Validation(Required=false)]
            public string ClassKey { get; set; }

            /// <summary>
            /// <para>The key of the name for the baseline check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>duplicate_uid</para>
            /// </summary>
            [NameInMap("ItemKey")]
            [Validation(Required=false)]
            public string ItemKey { get; set; }

            /// <summary>
            /// <para>The key of the name for the baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>identification</para>
            /// </summary>
            [NameInMap("NameKey")]
            [Validation(Required=false)]
            public string NameKey { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C2F2A020-1CAB-5F52-8CAF-B2ACDDFAC247</para>
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
