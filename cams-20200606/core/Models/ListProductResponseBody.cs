// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListProductResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>Other values indicate that the request failed. For more information, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
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
            /// <para>The pagination details.</para>
            /// </summary>
            [NameInMap("Paging")]
            [Validation(Required=false)]
            public ListProductResponseBodyModelPaging Paging { get; set; }
            public class ListProductResponseBodyModelPaging : TeaModel {
                /// <summary>
                /// <para>The cursors for pagination.</para>
                /// </summary>
                [NameInMap("Cursors")]
                [Validation(Required=false)]
                public ListProductResponseBodyModelPagingCursors Cursors { get; set; }
                public class ListProductResponseBodyModelPagingCursors : TeaModel {
                    /// <summary>
                    /// <para>The cursor that points to the end of the page of the returned data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sjsuueu83838</para>
                    /// </summary>
                    [NameInMap("After")]
                    [Validation(Required=false)]
                    public string After { get; set; }

                    /// <summary>
                    /// <para>The cursor that points to the beginning of the page of the returned data.</para>
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
