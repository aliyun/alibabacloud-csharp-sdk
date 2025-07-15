// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class GetMessageAppResponseBody : TeaModel {
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
        public GetMessageAppResponseBodyResult Result { get; set; }
        public class GetMessageAppResponseBodyResult : TeaModel {
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
            /// <para>testApp</para>
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
            /// <para>The status of the interactive message application. A value of 1 indicates that the application is normal.</para>
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
