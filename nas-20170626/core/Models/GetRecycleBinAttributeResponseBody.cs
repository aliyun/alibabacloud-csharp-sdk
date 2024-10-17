// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class GetRecycleBinAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the recycle bin.</para>
        /// </summary>
        [NameInMap("RecycleBinAttribute")]
        [Validation(Required=false)]
        public GetRecycleBinAttributeResponseBodyRecycleBinAttribute RecycleBinAttribute { get; set; }
        public class GetRecycleBinAttributeResponseBodyRecycleBinAttribute : TeaModel {
            /// <summary>
            /// <para>The size of the archived data that is dumped to the recycle bin. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1611661312</para>
            /// </summary>
            [NameInMap("ArchiveSize")]
            [Validation(Required=false)]
            public long? ArchiveSize { get; set; }

            /// <summary>
            /// <para>The time at which the recycle bin was enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-30T10:08:08Z</para>
            /// </summary>
            [NameInMap("EnableTime")]
            [Validation(Required=false)]
            public string EnableTime { get; set; }

            /// <summary>
            /// <para>The retention period of the files in the recycle bin. Unit: days.</para>
            /// <para>If the recycle bin is disabled, 0 is returned for this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReservedDays")]
            [Validation(Required=false)]
            public long? ReservedDays { get; set; }

            /// <summary>
            /// <para>The size of the Infrequent Access (IA) data that is dumped to the recycle bin. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SecondarySize")]
            [Validation(Required=false)]
            public long? SecondarySize { get; set; }

            /// <summary>
            /// <para>The size of the files that are dumped to the recycle bin. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The status of the recycle bin.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enable: The recycle bin is enabled.</description></item>
            /// <item><description>Disable: The recycle bin is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disable</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E15E394-38A6-457A-A62A-D9797C9A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
