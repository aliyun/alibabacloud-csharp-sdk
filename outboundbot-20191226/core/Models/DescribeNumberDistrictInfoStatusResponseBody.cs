// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeNumberDistrictInfoStatusResponseBody : TeaModel {
        [NameInMap("AppliedVersion")]
        [Validation(Required=false)]
        public DescribeNumberDistrictInfoStatusResponseBodyAppliedVersion AppliedVersion { get; set; }
        public class DescribeNumberDistrictInfoStatusResponseBodyAppliedVersion : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3.mkv</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>93</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>402681645884289024</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ParsingVersion")]
        [Validation(Required=false)]
        public DescribeNumberDistrictInfoStatusResponseBodyParsingVersion ParsingVersion { get; set; }
        public class DescribeNumberDistrictInfoStatusResponseBodyParsingVersion : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>template (3).xlsx</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>659968</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ParseProgress")]
            [Validation(Required=false)]
            public long? ParseProgress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>64615</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>66165274-82CC-5E7D-96D7-89143BAEA138</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Empty</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
