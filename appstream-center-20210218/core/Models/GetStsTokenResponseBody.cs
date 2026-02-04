// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210218.Models
{
    public class GetStsTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>CCF92035-6231-5ABB-930E-1E003C32****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StsTokenModel")]
        [Validation(Required=false)]
        public GetStsTokenResponseBodyStsTokenModel StsTokenModel { get; set; }
        public class GetStsTokenResponseBodyStsTokenModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>105552640689****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>be4be09e-cd00-4b4c-add7-11b4d8****</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sts****</para>
            /// </summary>
            [NameInMap("StsToken")]
            [Validation(Required=false)]
            public string StsToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>105552640689****</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

        }

    }

}
