// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRoutineCodeVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Edge Routine code versions.</para>
        /// </summary>
        [NameInMap("CodeVersions")]
        [Validation(Required=false)]
        public List<ListRoutineCodeVersionsResponseBodyCodeVersions> CodeVersions { get; set; }
        public class ListRoutineCodeVersionsResponseBodyCodeVersions : TeaModel {
            /// <summary>
            /// <para>The build ID of the code version.</para>
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
            /// <para>The code version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723599747213377175</para>
            /// </summary>
            [NameInMap("CodeVersion")]
            [Validation(Required=false)]
            public string CodeVersion { get; set; }

            /// <summary>
            /// <para>The configuration items of the code version.</para>
            /// </summary>
            [NameInMap("ConfOptions")]
            [Validation(Required=false)]
            public ListRoutineCodeVersionsResponseBodyCodeVersionsConfOptions ConfOptions { get; set; }
            public class ListRoutineCodeVersionsResponseBodyCodeVersionsConfOptions : TeaModel {
                /// <summary>
                /// <para>The NotFoundStrategy configuration item of the code version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SinglePageApplication</para>
                /// </summary>
                [NameInMap("NotFoundStrategy")]
                [Validation(Required=false)]
                public string NotFoundStrategy { get; set; }

            }

            /// <summary>
            /// <para>The time when the code version was created, in RFC 3339 format in the UTC time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-16T09:42:47Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The deployment environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>staging</b>: staging environment.</description></item>
            /// <item><description><b>production</b>: production environment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>staging</para>
            /// </summary>
            [NameInMap("DeployEnv")]
            [Validation(Required=false)]
            public string DeployEnv { get; set; }

            /// <summary>
            /// <para>The additional information about the code version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;approver\&quot;:[\&quot;348678\&quot;,\&quot;111133\&quot;,\&quot;411544\&quot;]}</para>
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            /// <summary>
            /// <para>Indicates whether environment variables exist.</para>
            /// </summary>
            [NameInMap("HasEnvVars")]
            [Validation(Required=false)]
            public bool? HasEnvVars { get; set; }

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
        /// <para>The current page number.</para>
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
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
