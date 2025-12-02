// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ListKeywordLibsResponseBody : TeaModel {
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
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListKeywordLibsResponseBodyData> Data { get; set; }
        public class ListKeywordLibsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-30 16:30:29</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Number of keywords.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("KeywordCount")]
            [Validation(Required=false)]
            public string KeywordCount { get; set; }

            /// <summary>
            /// <para>Library ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom_xxxxx</para>
            /// </summary>
            [NameInMap("LibId")]
            [Validation(Required=false)]
            public string LibId { get; set; }

            /// <summary>
            /// <para>Library name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("LibName")]
            [Validation(Required=false)]
            public string LibName { get; set; }

            /// <summary>
            /// <para>Service codes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service1,service2</para>
            /// </summary>
            [NameInMap("ServiceCodes")]
            [Validation(Required=false)]
            public string ServiceCodes { get; set; }

            /// <summary>
            /// <para>UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19964*****086772</para>
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
        /// <para>ID assigned by the backend to uniquely identify a request. Can be used for troubleshooting.</para>
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
