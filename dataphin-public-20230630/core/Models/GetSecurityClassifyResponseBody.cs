// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetSecurityClassifyResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the backend exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The data classification details.</para>
        /// </summary>
        [NameInMap("SecurityClassifyInfo")]
        [Validation(Required=false)]
        public GetSecurityClassifyResponseBodySecurityClassifyInfo SecurityClassifyInfo { get; set; }
        public class GetSecurityClassifyResponseBodySecurityClassifyInfo : TeaModel {
            /// <summary>
            /// <para>The classification abbreviation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Abbreviation")]
            [Validation(Required=false)]
            public string Abbreviation { get; set; }

            /// <summary>
            /// <para>The data classification ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The security level abbreviation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lv_test</para>
            /// </summary>
            [NameInMap("LevelAbbreviation")]
            [Validation(Required=false)]
            public string LevelAbbreviation { get; set; }

            /// <summary>
            /// <para>The security level index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LevelIndex")]
            [Validation(Required=false)]
            public long? LevelIndex { get; set; }

            /// <summary>
            /// <para>The security level name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lv_teat</para>
            /// </summary>
            [NameInMap("LevelName")]
            [Validation(Required=false)]
            public string LevelName { get; set; }

            /// <summary>
            /// <para>The classification name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The classification path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/a/b/c</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
