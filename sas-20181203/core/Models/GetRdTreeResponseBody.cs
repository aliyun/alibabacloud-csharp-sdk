// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetRdTreeResponseBody : TeaModel {
        /// <summary>
        /// <para>The processing result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRdTreeResponseBodyData Data { get; set; }
        public class GetRdTreeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The subfolder.</para>
            /// </summary>
            [NameInMap("Children")]
            [Validation(Required=false)]
            public List<object> Children { get; set; }

            /// <summary>
            /// <para>The ID of the folder in the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd-CGA73I****</para>
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// <para>The name of the folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Root</para>
            /// </summary>
            [NameInMap("FolderName")]
            [Validation(Required=false)]
            public string FolderName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30CBF632-109F-596F-97F2-451C8B2A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
