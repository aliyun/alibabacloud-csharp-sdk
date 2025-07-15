// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListMessageGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-****-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListMessageGroupResponseBodyResult Result { get; set; }
        public class ListMessageGroupResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The list of message groups.</para>
            /// </summary>
            [NameInMap("GroupList")]
            [Validation(Required=false)]
            public List<ListMessageGroupResponseBodyResultGroupList> GroupList { get; set; }
            public class ListMessageGroupResponseBodyResultGroupList : TeaModel {
                /// <summary>
                /// <para>The ID of the interactive messaging application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VKL3***</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The time when the message group was created. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1502280113</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>as****hs</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The extended field.</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extension { get; set; }

                /// <summary>
                /// <para>The ID of the message group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AE35-****-T95F</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The status of the message group. The default value is <b>1</b>, which indicates that the status of the message group is normal.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the current page is followed by another page. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The current page is followed by another page.</description></item>
            /// <item><description>false: The current page is not followed by another page.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <para>The total number of message groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

    }

}
