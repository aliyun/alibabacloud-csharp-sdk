// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ListKeywordLibsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListKeywordLibsResponseBodyData> Data { get; set; }
        public class ListKeywordLibsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-30 16:30:29</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The number of keywords.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("KeywordCount")]
            [Validation(Required=false)]
            public string KeywordCount { get; set; }

            /// <summary>
            /// <para>The ID of the library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom_xxxxx</para>
            /// </summary>
            [NameInMap("LibId")]
            [Validation(Required=false)]
            public string LibId { get; set; }

            /// <summary>
            /// <para>The name of the library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("LibName")]
            [Validation(Required=false)]
            public string LibName { get; set; }

            /// <summary>
            /// <para>The preprocessing list of the library. If ServiceCode is not specified or not configured, an empty array is returned.</para>
            /// </summary>
            [NameInMap("PreprocessList")]
            [Validation(Required=false)]
            public List<string> PreprocessList { get; set; }

            /// <summary>
            /// <para>The associated services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service1,service2</para>
            /// </summary>
            [NameInMap("ServiceCodes")]
            [Validation(Required=false)]
            public string ServiceCodes { get; set; }

            /// <summary>
            /// <para>The UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19964*****086772</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <para>The detailed description of the error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
