// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListDatasetsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of datasets to return. Valid values: 0 to 200.</para>
        /// <para>If this parameter is left empty or set to 0, 100 datasets are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// <para>If the total number of datasets is greater than the value of MaxResults, you must specify this parameter. The list is returned in lexicographic order starting from the value of NextToken.</para>
        /// <remarks>
        /// <para> The first time you call this operation in a query, set this parameter to null.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12345678:immtest:dataset002</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The dataset prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset</para>
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>The name of the project. For more information, see <a href="https://help.aliyun.com/document_detail/478153.html">CreateProject</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
