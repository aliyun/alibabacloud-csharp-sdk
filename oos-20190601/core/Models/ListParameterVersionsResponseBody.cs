// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListParameterVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The user who created the common parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root(130900000)</para>
        /// </summary>
        [NameInMap("CreatedBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// <para>The time when the common parameter was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-09-07T11:37:29Z</para>
        /// </summary>
        [NameInMap("CreatedDate")]
        [Validation(Required=false)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// <para>The description of the common parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>parameter-description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the common parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-a483b520e0axxxxxxxxx</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The name of the common parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyParameter</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The pagination token that was used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTRBMDc0NjAtRUJFNy00N0NBLTk3NTctMTJDQzQ3NjFENDdB</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The information about the version of the common parameter.</para>
        /// </summary>
        [NameInMap("ParameterVersions")]
        [Validation(Required=false)]
        public List<ListParameterVersionsResponseBodyParameterVersions> ParameterVersions { get; set; }
        public class ListParameterVersionsResponseBodyParameterVersions : TeaModel {
            /// <summary>
            /// <para>The version number of the common parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ParameterVersion")]
            [Validation(Required=false)]
            public int? ParameterVersion { get; set; }

            /// <summary>
            /// <para>The user who updated the common parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root(130900000)</para>
            /// </summary>
            [NameInMap("UpdatedBy")]
            [Validation(Required=false)]
            public string UpdatedBy { get; set; }

            /// <summary>
            /// <para>The time when the common parameter was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-07T11:37:29Z</para>
            /// </summary>
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

            /// <summary>
            /// <para>The value of the common parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyParameter</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FD08D89D-B6C8-4AA2-A2B4-521D3F4A39FA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The data type of the common parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>String</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
