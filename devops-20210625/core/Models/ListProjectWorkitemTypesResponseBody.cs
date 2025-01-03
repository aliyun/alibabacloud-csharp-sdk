// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListProjectWorkitemTypesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>例：Openapi.RequestError</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>errormessage</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true或者false</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("workitemTypes")]
        [Validation(Required=false)]
        public List<ListProjectWorkitemTypesResponseBodyWorkitemTypes> WorkitemTypes { get; set; }
        public class ListProjectWorkitemTypesResponseBodyWorkitemTypes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>用户阿里云pk，例如19xxxx31947xxxx</para>
            /// </summary>
            [NameInMap("addUser")]
            [Validation(Required=false)]
            public string AddUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Req</para>
            /// </summary>
            [NameInMap("categoryIdentifier")]
            [Validation(Required=false)]
            public string CategoryIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>用户阿里云pk，例如19xxxx31947xxxx</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true或者false</para>
            /// </summary>
            [NameInMap("defaultType")]
            [Validation(Required=false)]
            public bool? DefaultType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>该类型的具体信息</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true或者false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1641870287000</para>
            /// </summary>
            [NameInMap("gmtAdd")]
            [Validation(Required=false)]
            public long? GmtAdd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1620455467000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dfexxxxxf4fee18xxxxx36</para>
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>例：业务类需求</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>例：Business Requirement</para>
            /// </summary>
            [NameInMap("nameEn")]
            [Validation(Required=false)]
            public string NameEn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("systemDefault")]
            [Validation(Required=false)]
            public bool? SystemDefault { get; set; }

        }

    }

}
