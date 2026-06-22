// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListProductResponseBody : TeaModel {
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
        /// <para>The message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public ListProductResponseBodyModel Model { get; set; }
        public class ListProductResponseBodyModel : TeaModel {
            /// <summary>
            /// <para>The returned data.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Data { get; set; }

            /// <summary>
            /// <para>Paging details.</para>
            /// </summary>
            [NameInMap("Paging")]
            [Validation(Required=false)]
            public ListProductResponseBodyModelPaging Paging { get; set; }
            public class ListProductResponseBodyModelPaging : TeaModel {
                /// <summary>
                /// <para>The cursors for paging.</para>
                /// </summary>
                [NameInMap("Cursors")]
                [Validation(Required=false)]
                public ListProductResponseBodyModelPagingCursors Cursors { get; set; }
                public class ListProductResponseBodyModelPagingCursors : TeaModel {
                    /// <summary>
                    /// <para>The cursor that points to the next page.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sjsuueu83838</para>
                    /// </summary>
                    [NameInMap("After")]
                    [Validation(Required=false)]
                    public string After { get; set; }

                    /// <summary>
                    /// <para>The cursor that points to the previous page.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sjjsjdjjdjd83883</para>
                    /// </summary>
                    [NameInMap("Before")]
                    [Validation(Required=false)]
                    public string Before { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A94866411B2O</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
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

    }

}
