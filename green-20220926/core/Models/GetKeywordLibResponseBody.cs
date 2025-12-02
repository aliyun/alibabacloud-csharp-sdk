// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetKeywordLibResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Returned data content.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetKeywordLibResponseBodyData Data { get; set; }
        public class GetKeywordLibResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Last modified time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-29 10:26:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Number of keywords.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("KeywordCount")]
            [Validation(Required=false)]
            public string KeywordCount { get; set; }

            /// <summary>
            /// <para>Keyword library ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customxx_xxx</para>
            /// </summary>
            [NameInMap("LibId")]
            [Validation(Required=false)]
            public string LibId { get; set; }

            /// <summary>
            /// <para>Library name</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试词库</para>
            /// </summary>
            [NameInMap("LibName")]
            [Validation(Required=false)]
            public string LibName { get; set; }

            /// <summary>
            /// <para>Primary account ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1825457112123838</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <para>Further description of the error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>ID assigned by the backend, used to uniquely identify a request. Can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Success indicator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
