// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListDatasetsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of datasets to return. Valid values: 0 to 200. If you do not specify this parameter or set it to 0, the default value 100 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// <para>If the total number of datasets exceeds the value of MaxResults, this token is used for pagination. The list of dataset information is returned in lexicographical order starting from NextToken.</para>
        /// <remarks>
        /// <para>When you call this operation for the first time in a query, leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12345678:immtest:dataset002</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The prefix of the dataset name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset</para>
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>The name of the project. For more information about how to obtain the project name, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
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
