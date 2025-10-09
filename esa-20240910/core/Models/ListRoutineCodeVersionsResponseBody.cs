// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRoutineCodeVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The code versions of the routine.</para>
        /// </summary>
        [NameInMap("CodeVersions")]
        [Validation(Required=false)]
        public List<ListRoutineCodeVersionsResponseBodyCodeVersions> CodeVersions { get; set; }
        public class ListRoutineCodeVersionsResponseBodyCodeVersions : TeaModel {
            /// <summary>
            /// <para>The ID of the code version build.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25801233</para>
            /// </summary>
            [NameInMap("BuildId")]
            [Validation(Required=false)]
            public long? BuildId { get; set; }

            /// <summary>
            /// <para>The description of the code version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test desc</para>
            /// </summary>
            [NameInMap("CodeDescription")]
            [Validation(Required=false)]
            public string CodeDescription { get; set; }

            /// <summary>
            /// <para>The version of the code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723599747213377175</para>
            /// </summary>
            [NameInMap("CodeVersion")]
            [Validation(Required=false)]
            public string CodeVersion { get; set; }

            /// <summary>
            /// <para>Code version configuration items.</para>
            /// </summary>
            [NameInMap("ConfOptions")]
            [Validation(Required=false)]
            public ListRoutineCodeVersionsResponseBodyCodeVersionsConfOptions ConfOptions { get; set; }
            public class ListRoutineCodeVersionsResponseBodyCodeVersionsConfOptions : TeaModel {
                /// <summary>
                /// <para>Code version configuration items NotFoundStrategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SinglePageApplication</para>
                /// </summary>
                [NameInMap("NotFoundStrategy")]
                [Validation(Required=false)]
                public string NotFoundStrategy { get; set; }

            }

            /// <summary>
            /// <para>The time when the code version was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-16T09:42:47Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Additional information about the code version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;approver\&quot;:[\&quot;348678\&quot;,\&quot;111133\&quot;,\&quot;411544\&quot;]}</para>
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            /// <summary>
            /// <para>The status of the code version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of code versions returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
