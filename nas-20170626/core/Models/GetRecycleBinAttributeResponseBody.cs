// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class GetRecycleBinAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The recycle bin description.</para>
        /// </summary>
        [NameInMap("RecycleBinAttribute")]
        [Validation(Required=false)]
        public GetRecycleBinAttributeResponseBodyRecycleBinAttribute RecycleBinAttribute { get; set; }
        public class GetRecycleBinAttributeResponseBodyRecycleBinAttribute : TeaModel {
            /// <summary>
            /// <para>The storage usage of archived data in the recycle bin. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1611661312</para>
            /// </summary>
            [NameInMap("ArchiveSize")]
            [Validation(Required=false)]
            public long? ArchiveSize { get; set; }

            /// <summary>
            /// <para>The time when the recycle bin was enabled. The time follows the ISO 8601 standard in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-30T10:08:08Z</para>
            /// </summary>
            [NameInMap("EnableTime")]
            [Validation(Required=false)]
            public string EnableTime { get; set; }

            /// <summary>
            /// <para>The retention period of files in the recycle bin. Unit: days.</para>
            /// <para>If the recycle bin is disabled, this parameter returns 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReservedDays")]
            [Validation(Required=false)]
            public long? ReservedDays { get; set; }

            /// <summary>
            /// <para>The storage usage of Infrequent Access (IA) data in the recycle bin. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SecondarySize")]
            [Validation(Required=false)]
            public long? SecondarySize { get; set; }

            /// <summary>
            /// <para>The storage usage of files in the recycle bin. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The recycle bin status.</para>
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
