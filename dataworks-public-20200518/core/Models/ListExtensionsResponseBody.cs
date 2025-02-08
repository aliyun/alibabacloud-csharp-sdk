// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListExtensionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListExtensionsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListExtensionsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The list of extensions.</para>
            /// </summary>
            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public List<ListExtensionsResponseBodyPagingInfoExtensions> Extensions { get; set; }
            public class ListExtensionsResponseBodyPagingInfoExtensions : TeaModel {
                /// <summary>
                /// <para>The list of extension point events.</para>
                /// </summary>
                [NameInMap("BindEventList")]
                [Validation(Required=false)]
                public List<ListExtensionsResponseBodyPagingInfoExtensionsBindEventList> BindEventList { get; set; }
                public class ListExtensionsResponseBodyPagingInfoExtensionsBindEventList : TeaModel {
                    /// <summary>
                    /// <para>The code of the event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>commit-file</para>
                    /// </summary>
                    [NameInMap("EventCode")]
                    [Validation(Required=false)]
                    public string EventCode { get; set; }

                    /// <summary>
                    /// <para>The name of the event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>File submission pre-event</para>
                    /// </summary>
                    [NameInMap("EventName")]
                    [Validation(Required=false)]
                    public string EventName { get; set; }

                }

                /// <summary>
                /// <para>The unique code of the extension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Extension Code</para>
                /// </summary>
                [NameInMap("ExtensionCode")]
                [Validation(Required=false)]
                public string ExtensionCode { get; set; }

                /// <summary>
                /// <para>The description of the extension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is a description</para>
                /// </summary>
                [NameInMap("ExtensionDesc")]
                [Validation(Required=false)]
                public string ExtensionDesc { get; set; }

                /// <summary>
                /// <para>The name of the extension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Extension name</para>
                /// </summary>
                [NameInMap("ExtensionName")]
                [Validation(Required=false)]
                public string ExtensionName { get; set; }

                /// <summary>
                /// <para>The ID of the RAM user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2003****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The state of the extension. Valid values: 0: Testing 1: Publishing 3: Disabled 4: Processing 5: Approved 6: Approve Failed</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
