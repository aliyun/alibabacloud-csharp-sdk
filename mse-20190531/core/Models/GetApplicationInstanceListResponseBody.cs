// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetApplicationInstanceListResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetApplicationInstanceListResponseBodyData Data { get; set; }
        public class GetApplicationInstanceListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number. Pages start from page 1.</para>
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
            /// <para>The queried nodes.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GetApplicationInstanceListResponseBodyDataResult> Result { get; set; }
            public class GetApplicationInstanceListResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The node IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.1.2.3</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The application port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The node tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<GetApplicationInstanceListResponseBodyDataResultTags> Tags { get; set; }
                public class GetApplicationInstanceListResponseBodyDataResultTags : TeaModel {
                    /// <summary>
                    /// <para>标签值。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>gray</para>
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                }

            }

            /// <summary>
            /// <para>The total number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

    }

}
