// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListBatchesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of results to return. Valid values: 0 to 100.</para>
        /// <para>If you do not specify this parameter or set the parameter to 0, the default value of 100 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// <para>The pagination token is used in the next request to retrieve a new page of results if the total number of results exceeds the value of the MaxResults parameter. The next call to the operation returns results lexicographically after the NextToken parameter value.</para>
        /// <para>You do not need to specify this parameter in your initial request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg6aW1tdGVzdDpleGFtcGxlYnVja2V0OmRhdGFzZXQwMDE6b3NzOi8vZXhhbXBsZWJ1Y2tldC9zYW1wbGVvYmplY3QxLmpwZw==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: sorts the results in ascending order. This is the default sort order.</description></item>
        /// <item><description>DES: sorts the results in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

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

        /// <summary>
        /// <para>The sort field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateTime</description></item>
        /// <item><description>UpdateTime</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-11T06:51:17.5Z</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// <list type="bullet">
        /// <item><description>Ready: The task is newly created and ready.</description></item>
        /// <item><description>Running: The task is running.</description></item>
        /// <item><description>Failed: The task failed and cannot be automatically recovered.</description></item>
        /// <item><description>Suspended: The task is suspended.</description></item>
        /// <item><description>Succeeded: The task is successful.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeed</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The custom tag. You can use this parameter to query tasks that have the specified tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test=val1</para>
        /// </summary>
        [NameInMap("TagSelector")]
        [Validation(Required=false)]
        public string TagSelector { get; set; }

    }

}
