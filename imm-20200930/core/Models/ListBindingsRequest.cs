// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListBindingsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the dataset.<a href="~~478160~~"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The maximum number of bindings to return. Valid values: 0 to 200.</description></item>
        /// <item><description>If you do not specify this parameter or set the parameter to 0, the default value of 100 is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The pagination token that is used in the next request to retrieve a new page of results if the total number of results exceeds the value of the MaxResults parameter.</description></item>
        /// <item><description>The next call to the operation returns results lexicographically after the NextToken parameter value.</description></item>
        /// <item><description>You do not need to specify this parameter in your initial request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>immtest:dataset001:examplebucket01</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The name of the project.<a href="~~478153~~"></a></para>
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
