// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListMusicResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code returned by the alarm service</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>音乐类型名称为空</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>43<em><b>28C-A810-5</b></em>-8747-EC226A086881</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>collection of ringtone query results</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListMusicResponseBodyResult Result { get; set; }
        public class ListMusicResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Current page</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>List of ringtones</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public List<ListMusicResponseBodyResultModel> Model { get; set; }
            public class ListMusicResponseBodyResultModel : TeaModel {
                /// <summary>
                /// <para>Ringtone ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MusicId")]
                [Validation(Required=false)]
                public long? MusicId { get; set; }

                /// <summary>
                /// <para>Ringtone name</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("MusicName")]
                [Validation(Required=false)]
                public string MusicName { get; set; }

                /// <summary>
                /// <para>Ringtone category ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MusicType")]
                [Validation(Required=false)]
                public long? MusicType { get; set; }

                /// <summary>
                /// <para>Ringtone category name</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("MusicTypeName")]
                [Validation(Required=false)]
                public string MusicTypeName { get; set; }

                /// <summary>
                /// <para>Ringtone URL</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xx">http://xx</a></para>
                /// </summary>
                [NameInMap("MusicUrl")]
                [Validation(Required=false)]
                public string MusicUrl { get; set; }

            }

            /// <summary>
            /// <para>Total number of pages</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }

            /// <summary>
            /// <para>Number of entries per page: maximum value is 100; values exceeding 100 are treated as 100</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of entries</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
