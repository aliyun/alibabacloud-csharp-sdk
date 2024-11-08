// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListSecretParameterVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The user who created the encryption parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root(130900000)</para>
        /// </summary>
        [NameInMap("CreatedBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// <para>The time when the encryption parameter was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-09-01T08:01:43Z</para>
        /// </summary>
        [NameInMap("CreatedDate")]
        [Validation(Required=false)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// <para>The description of the encryption parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SecretParameter</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the encryption parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-4c4b401cab6747xxxxxx</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The name of the encryption parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySecretParameter</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTRBMDc0NjAtRUJFNy00N0NBLTk3NTctMTJDQzQ3NjFENDdB</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The information about the version of the encryption parameter.</para>
        /// </summary>
        [NameInMap("ParameterVersions")]
        [Validation(Required=false)]
        public List<ListSecretParameterVersionsResponseBodyParameterVersions> ParameterVersions { get; set; }
        public class ListSecretParameterVersionsResponseBodyParameterVersions : TeaModel {
            /// <summary>
            /// <para>The version number of the encryption parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ParameterVersion")]
            [Validation(Required=false)]
            public int? ParameterVersion { get; set; }

            /// <summary>
            /// <para>The user who updated the encryption parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root(130900000)</para>
            /// </summary>
            [NameInMap("UpdatedBy")]
            [Validation(Required=false)]
            public string UpdatedBy { get; set; }

            /// <summary>
            /// <para>The time when the encryption parameter was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-01T08:01:43Z</para>
            /// </summary>
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

            /// <summary>
            /// <para>The value of the encryption parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SecretParameter</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DBA6E6C8-F75D-41DE-AFF5-1FA03F551CA3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The type of the encryption parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Secret</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
