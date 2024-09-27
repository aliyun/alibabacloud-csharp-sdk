// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class GetCloudDriveServiceMountTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DC27288A-F9E1-5092-9B5B-71C27D15****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public GetCloudDriveServiceMountTokenResponseBodyToken Token { get; set; }
        public class GetCloudDriveServiceMountTokenResponseBodyToken : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>h****</para>
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-10-10T04:41:35Z</para>
            /// </summary>
            [NameInMap("ExpiredAfter")]
            [Validation(Required=false)]
            public string ExpiredAfter { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7836fa6eced7dc8d54c775k34iu3h4i2kh534f****</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6050416754750</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>605089</para>
            /// </summary>
            [NameInMap("UsedSize")]
            [Validation(Required=false)]
            public long? UsedSize { get; set; }

        }

    }

}
