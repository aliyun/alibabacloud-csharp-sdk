// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListCloudAppPatchesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("Patches")]
        [Validation(Required=false)]
        public List<ListCloudAppPatchesResponseBodyPatches> Patches { get; set; }
        public class ListCloudAppPatchesResponseBodyPatches : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>patch-03fa76e8e13a49b6a966b063d9d309b4</para>
            /// </summary>
            [NameInMap("PatchId")]
            [Validation(Required=false)]
            public string PatchId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>patch-1</para>
            /// </summary>
            [NameInMap("PatchName")]
            [Validation(Required=false)]
            public string PatchName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Doing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Uploading</para>
            /// </summary>
            [NameInMap("StatusDescription")]
            [Validation(Required=false)]
            public string StatusDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-09-23T02:12:28</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-07-24T14:45:36+08:00</para>
            /// </summary>
            [NameInMap("UploadTime")]
            [Validation(Required=false)]
            public string UploadTime { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
