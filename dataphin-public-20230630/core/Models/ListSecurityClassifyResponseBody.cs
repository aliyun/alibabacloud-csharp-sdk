// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListSecurityClassifyResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the data classification list.</para>
        /// </summary>
        [NameInMap("ClassifyListResult")]
        [Validation(Required=false)]
        public ListSecurityClassifyResponseBodyClassifyListResult ClassifyListResult { get; set; }
        public class ListSecurityClassifyResponseBodyClassifyListResult : TeaModel {
            /// <summary>
            /// <para>The list of data classifications.</para>
            /// </summary>
            [NameInMap("ClassifyList")]
            [Validation(Required=false)]
            public List<ListSecurityClassifyResponseBodyClassifyListResultClassifyList> ClassifyList { get; set; }
            public class ListSecurityClassifyResponseBodyClassifyListResultClassifyList : TeaModel {
                /// <summary>
                /// <para>The catalog path of the classification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/Root/Personal Information</para>
                /// </summary>
                [NameInMap("CatalogPath")]
                [Validation(Required=false)]
                public string CatalogPath { get; set; }

                /// <summary>
                /// <para>The classification description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Personal sensitive information classification</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The number of effective fields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("EffectiveFieldCount")]
                [Validation(Required=false)]
                public int? EffectiveFieldCount { get; set; }

                /// <summary>
                /// <para>The classification ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Indicates whether a masking rule is bound.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsBindDesensitizeRule")]
                [Validation(Required=false)]
                public bool? IsBindDesensitizeRule { get; set; }

                /// <summary>
                /// <para>The level ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LevelId")]
                [Validation(Required=false)]
                public long? LevelId { get; set; }

                /// <summary>
                /// <para>The level name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>L3</para>
                /// </summary>
                [NameInMap("LevelName")]
                [Validation(Required=false)]
                public string LevelName { get; set; }

                /// <summary>
                /// <para>The classification name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Personal Information</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The short name of the classification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PI</para>
                /// </summary>
                [NameInMap("ShortName")]
                [Validation(Required=false)]
                public string ShortName { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENABLE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

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
        /// <para>The details of the backend error.</para>
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
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
