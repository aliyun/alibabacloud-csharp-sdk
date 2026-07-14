// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListProductCatalogResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The request status code.</para>
        /// <list type="bullet">
        /// <item><description><para>OK indicates that the request was successful.</para>
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
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public ListProductCatalogResponseBodyModel Model { get; set; }
        public class ListProductCatalogResponseBodyModel : TeaModel {
            /// <summary>
            /// <para>The returned data object.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Data { get; set; }

            /// <summary>
            /// <para>The pagination details.</para>
            /// </summary>
            [NameInMap("Paging")]
            [Validation(Required=false)]
            public ListProductCatalogResponseBodyModelPaging Paging { get; set; }
            public class ListProductCatalogResponseBodyModelPaging : TeaModel {
                /// <summary>
                /// <para>The cursor position for pagination.</para>
                /// </summary>
                [NameInMap("Cursors")]
                [Validation(Required=false)]
                public ListProductCatalogResponseBodyModelPagingCursors Cursors { get; set; }
                public class ListProductCatalogResponseBodyModelPagingCursors : TeaModel {
                    /// <summary>
                    /// <para>The position of the next record.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sjsuueu83838</para>
                    /// </summary>
                    [NameInMap("After")]
                    [Validation(Required=false)]
                    public string After { get; set; }

                    /// <summary>
                    /// <para>The position of the previous record.</para>
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
        /// <para>90E63D28-E31D-1EB2-8939-A9486641****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
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
