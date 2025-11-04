// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListRecognitionLibsResponseBody : TeaModel {
        /// <summary>
        /// <para>The recognition libraries.</para>
        /// </summary>
        [NameInMap("Libs")]
        [Validation(Required=false)]
        public ListRecognitionLibsResponseBodyLibs Libs { get; set; }
        public class ListRecognitionLibsResponseBodyLibs : TeaModel {
            [NameInMap("Lib")]
            [Validation(Required=false)]
            public List<ListRecognitionLibsResponseBodyLibsLib> Lib { get; set; }
            public class ListRecognitionLibsResponseBodyLibsLib : TeaModel {
                /// <summary>
                /// <para>The description of the recognition library.</para>
                /// </summary>
                [NameInMap("LibDescription")]
                [Validation(Required=false)]
                public string LibDescription { get; set; }

                /// <summary>
                /// <para>The ID of the recognition library.</para>
                /// 
                /// <b>Example:</b>
                /// <para><em><b><b><b><b><b><b>24b47865c6</b></b></b></b></b></b></em>*</para>
                /// </summary>
                [NameInMap("LibId")]
                [Validation(Required=false)]
                public string LibId { get; set; }

                /// <summary>
                /// <para>The name of the recognition library.</para>
                /// </summary>
                [NameInMap("LibName")]
                [Validation(Required=false)]
                public string LibName { get; set; }

            }

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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
