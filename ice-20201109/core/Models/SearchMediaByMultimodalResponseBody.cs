// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchMediaByMultimodalResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("MediaList")]
        [Validation(Required=false)]
        public List<SearchMediaByMultimodalResponseBodyMediaList> MediaList { get; set; }
        public class SearchMediaByMultimodalResponseBodyMediaList : TeaModel {
            [NameInMap("ClipInfo")]
            [Validation(Required=false)]
            public List<SearchMediaByMultimodalResponseBodyMediaListClipInfo> ClipInfo { get; set; }
            public class SearchMediaByMultimodalResponseBodyMediaListClipInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("From")]
                [Validation(Required=false)]
                public double? From { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.2</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("To")]
                [Validation(Required=false)]
                public double? To { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a18936e0e28771edb59ae6f6f47a****</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
