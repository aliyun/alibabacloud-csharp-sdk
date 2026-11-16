// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class PrecheckVideoCharacterReplaceJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of items that fail the validation. This is an empty array if the validation passes.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<PrecheckVideoCharacterReplaceJobResponseBodyResult> Result { get; set; }
        public class PrecheckVideoCharacterReplaceJobResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The validation error code of the input item. For example, ImageCheckFailed indicates that the image validation fails, and AudioCheckFailed indicates that the audio validation fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ImageCheckFailed</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The name of the input parameter that fails the validation. This name is consistent with the corresponding field name in AppParams.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LoadImage.1.TargetImage</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

        }

        /// <summary>
        /// <para>The pre-validation status. A value of Success indicates that the validation passes. A value of Failed indicates that one or more items fail the validation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
