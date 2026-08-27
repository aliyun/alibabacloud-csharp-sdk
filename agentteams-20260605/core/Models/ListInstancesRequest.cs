// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description><b>Description</b>: The instance name. Supports fuzzy match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AgentTeams</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><b>Description</b>: The page size.</description></item>
        /// <item><description><b>Default value</b>: 20</description></item>
        /// <item><description><b>Current implementation limit</b>: 1 to 100</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><b>Description</b>: The pagination token for the next page.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><b>Description</b>: The number of records to skip.</description></item>
        /// <item><description><b>Default value</b>: 0</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Skip")]
        [Validation(Required=false)]
        public int? Skip { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><b>Description</b>: The instance status.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
