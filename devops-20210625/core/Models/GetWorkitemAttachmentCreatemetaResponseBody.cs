// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetWorkitemAttachmentCreatemetaResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Invalid.IdNotFound</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Forbidden.UserNotInCurrentOrganization</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("uploadInfo")]
        [Validation(Required=false)]
        public GetWorkitemAttachmentCreatemetaResponseBodyUploadInfo UploadInfo { get; set; }
        public class GetWorkitemAttachmentCreatemetaResponseBodyUploadInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxxx</para>
            /// </summary>
            [NameInMap("accessid")]
            [Validation(Required=false)]
            public string Accessid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ddd/dddd</para>
            /// </summary>
            [NameInMap("dir")]
            [Validation(Required=false)]
            public string Dir { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxx</para>
            /// </summary>
            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxxx</para>
            /// </summary>
            [NameInMap("policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xdWcrl/yTmIUA0kE7a3B0Ox4Vu8=</para>
            /// </summary>
            [NameInMap("signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

        }

    }

}
