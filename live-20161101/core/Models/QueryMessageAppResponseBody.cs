// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class QueryMessageAppResponseBody : TeaModel {
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
        public List<QueryMessageAppResponseBodyResult> Result { get; set; }
        public class QueryMessageAppResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Details about the interactive messaging applications.</para>
            /// </summary>
            [NameInMap("AppList")]
            [Validation(Required=false)]
            public List<QueryMessageAppResponseBodyResultAppList> AppList { get; set; }
            public class QueryMessageAppResponseBodyResultAppList : TeaModel {
                /// <summary>
                /// <para>The configurations of the application.</para>
                /// </summary>
                [NameInMap("AppConfig")]
                [Validation(Required=false)]
                public Dictionary<string, string> AppConfig { get; set; }

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
                /// <para>The name of the interactive messaging application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The time when the interactive messaging application was created. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>502280113</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The extended field.</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extension { get; set; }

                /// <summary>
                /// <para>The status of the interactive message application. A value of <b>1</b> indicates that the application is normal.</para>
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
            /// <para>The total number of applications returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
