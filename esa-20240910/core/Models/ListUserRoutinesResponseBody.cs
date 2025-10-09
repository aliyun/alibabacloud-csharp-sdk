// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListUserRoutinesResponseBody : TeaModel {
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
        /// <para>The maximum number of functions supported by the billing plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("QuotaRoutineNumber")]
        [Validation(Required=false)]
        public long? QuotaRoutineNumber { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890ABCDEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The functions.</para>
        /// </summary>
        [NameInMap("Routines")]
        [Validation(Required=false)]
        public List<ListUserRoutinesResponseBodyRoutines> Routines { get; set; }
        public class ListUserRoutinesResponseBodyRoutines : TeaModel {
            /// <summary>
            /// <para>The time when the function was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-11T01:23:02.883361712Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The default record name to access.</para>
            /// 
            /// <b>Example:</b>
            /// <para>serverless-test-2.154edaf6.er.aliyun-esa.net</para>
            /// </summary>
            [NameInMap("DefaultRelatedRecord")]
            [Validation(Required=false)]
            public string DefaultRelatedRecord { get; set; }

            /// <summary>
            /// <para>The function description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZWRpdCByb3V0aW5lIGNvbmZpZyBkZXNjcmlwdGlvbg==</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Specifies whether to include the Assets file tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasAssets")]
            [Validation(Required=false)]
            public bool? HasAssets { get; set; }

            /// <summary>
            /// <para>The function name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("RoutineName")]
            [Validation(Required=false)]
            public string RoutineName { get; set; }

        }

        /// <summary>
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The number of functions that were already created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("UsedRoutineNumber")]
        [Validation(Required=false)]
        public long? UsedRoutineNumber { get; set; }

    }

}
