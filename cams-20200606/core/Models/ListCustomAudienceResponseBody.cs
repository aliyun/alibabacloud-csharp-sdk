// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListCustomAudienceResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The request status code.</para>
        /// <list type="bullet">
        /// <item><description><para>A value of OK indicates that the request was successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCustomAudienceResponseBodyData> Data { get; set; }
        public class ListCustomAudienceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Meta ad account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>339**</para>
            /// </summary>
            [NameInMap("AdAccountId")]
            [Validation(Required=false)]
            public string AdAccountId { get; set; }

            /// <summary>
            /// <para>The time when the audience was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1720356898</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the custom audience.</para>
            /// 
            /// <b>Example:</b>
            /// <para>339**</para>
            /// </summary>
            [NameInMap("CustomAudienceId")]
            [Validation(Required=false)]
            public string CustomAudienceId { get; set; }

            /// <summary>
            /// <para>The name of the custom audience.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom audience name</para>
            /// </summary>
            [NameInMap("CustomAudienceName")]
            [Validation(Required=false)]
            public string CustomAudienceName { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The Page ID for Messenger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>239**</para>
            /// </summary>
            [NameInMap("PageId")]
            [Validation(Required=false)]
            public string PageId { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The number of tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("TokenTotal")]
            [Validation(Required=false)]
            public long? TokenTotal { get; set; }

            /// <summary>
            /// <para>The token type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("TokenType")]
            [Validation(Required=false)]
            public string TokenType { get; set; }

            /// <summary>
            /// <para>The time when the audience was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The upload type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>excel</para>
            /// </summary>
            [NameInMap("UploadType")]
            [Validation(Required=false)]
            public string UploadType { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39**</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
