// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListMergeRequestPatchSetsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SYSTEM_UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F7B85D1B-D1C2-140F-A039-341859F130B9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListMergeRequestPatchSetsResponseBodyResult> Result { get; set; }
        public class ListMergeRequestPatchSetsResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1a072f5367c21f9de3464b8c0ee8546e47764d2d</para>
            /// </summary>
            [NameInMap("commitId")]
            [Validation(Required=false)]
            public string CommitId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-03-18 14:24:54</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>513fcfd81a9142d2bb0db4f72c0aa15b</para>
            /// </summary>
            [NameInMap("patchSetBizId")]
            [Validation(Required=false)]
            public string PatchSetBizId { get; set; }

            [NameInMap("patchSetName")]
            [Validation(Required=false)]
            public string PatchSetName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("patchSetNo")]
            [Validation(Required=false)]
            public long? PatchSetNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MERGE_SOURCE</para>
            /// </summary>
            [NameInMap("relatedMergeItemType")]
            [Validation(Required=false)]
            public string RelatedMergeItemType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1a072f53</para>
            /// </summary>
            [NameInMap("shortCommitId")]
            [Validation(Required=false)]
            public string ShortCommitId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
