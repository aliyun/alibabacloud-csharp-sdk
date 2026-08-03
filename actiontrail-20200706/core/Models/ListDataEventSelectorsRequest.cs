// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class ListDataEventSelectorsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of results to return.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values: 1 to 100.</para>
        /// </description></item>
        /// <item><description><para>Default value: 20.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// <list type="bullet">
        /// <item><description><para>You do not need to specify this parameter for the first request.</para>
        /// </description></item>
        /// <item><description><para>You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VjE6dLbnNpVmbz06****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
