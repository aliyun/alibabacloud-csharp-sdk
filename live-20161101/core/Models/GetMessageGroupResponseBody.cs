// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class GetMessageGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-****-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetMessageGroupResponseBodyResult Result { get; set; }
        public class GetMessageGroupResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>UTC timestamp when the message group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1502280113</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Creator ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>as****hs</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <para>Extension field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public Dictionary<string, object> Extension { get; set; }

            /// <summary>
            /// <para>Message group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AE35-****-T95F</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>Indicates whether all members in this message group are muted.</para>
            /// <list type="bullet">
            /// <item><description>true: All members are muted.</description></item>
            /// <item><description>false: All members are not muted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsMuteAll")]
            [Validation(Required=false)]
            public bool? IsMuteAll { get; set; }

            /// <summary>
            /// <para>Message group status. The default value is <b>1</b>, which indicates that the message group status is normal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
