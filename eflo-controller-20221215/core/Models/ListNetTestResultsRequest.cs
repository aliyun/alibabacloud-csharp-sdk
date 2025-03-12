// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListNetTestResultsRequest : TeaModel {
        /// <summary>
        /// <para>Number of items per page in a paginated query. The maximum value is 100.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description><para>If no value is set or the set value is less than 20, the default is 20.</para>
        /// </description></item>
        /// <item><description><para>If the set value is greater than 100, the default is 100.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>Type of network test.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DelayTest</para>
        /// </summary>
        [NameInMap("NetTestType")]
        [Validation(Required=false)]
        public string NetTestType { get; set; }

        /// <summary>
        /// <para>Query token (Token), which should be the value of the NextToken parameter returned from the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3a6b93229825ac667104463b56790c91</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Resource group ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxno4vh5muoq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
