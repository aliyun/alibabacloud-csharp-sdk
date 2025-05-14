// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeDisplayConfigResponseBody : TeaModel {
        [NameInMap("DisplayConfigModel")]
        [Validation(Required=false)]
        public List<DescribeDisplayConfigResponseBodyDisplayConfigModel> DisplayConfigModel { get; set; }
        public class DescribeDisplayConfigResponseBodyDisplayConfigModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cpn-jewjt8xryuituz4qn-****</para>
            /// </summary>
            [NameInMap("AndroidInstanceId")]
            [Validation(Required=false)]
            public string AndroidInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>240</para>
            /// </summary>
            [NameInMap("Dpi")]
            [Validation(Required=false)]
            public int? Dpi { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Fps")]
            [Validation(Required=false)]
            public int? Fps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("LockResolution")]
            [Validation(Required=false)]
            public string LockResolution { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1280</para>
            /// </summary>
            [NameInMap("ResolutionHeight")]
            [Validation(Required=false)]
            public int? ResolutionHeight { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>720</para>
            /// </summary>
            [NameInMap("ResolutionWidth")]
            [Validation(Required=false)]
            public int? ResolutionWidth { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FFEF7EFE-1E36-56D1-B5BF-5BACE43B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
