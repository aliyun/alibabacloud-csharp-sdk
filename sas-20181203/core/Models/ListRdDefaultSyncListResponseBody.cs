// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListRdDefaultSyncListResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned if the call is successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRdDefaultSyncListResponseBodyData Data { get; set; }
        public class ListRdDefaultSyncListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The IDs of the folders in the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd-BwoXuf****,fd-CFamY7****</para>
            /// </summary>
            [NameInMap("FolderIds")]
            [Validation(Required=false)]
            public string FolderIds { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447DDCAE1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
