// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20250903.Models
{
    public class ListPlaybooksRequest : TeaModel {
        /// <summary>
        /// <para>Language type for request and response messages.</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Maximum number of results returned in a single request. Range: 1~100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Token for the next query start.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7fbb1c****07c1f79a740f039a8dcfda</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Sorting logic, default is <b>desc</b>, with values as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>desc</b>: Descending order.</description></item>
        /// <item><description><b>asc</b>: Ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>Sorting field. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>UpdateTime</b>: Sort by update time.</description></item>
        /// <item><description><b>ExecutionTime</b>: Sort by the latest execution time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UpdateTime</para>
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// <para>Page number for pagination, default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of items per page for pagination. Range: 1~100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>End time of the latest execution of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1731379251000</para>
        /// </summary>
        [NameInMap("PlaybookExecutionEndTime")]
        [Validation(Required=false)]
        public long? PlaybookExecutionEndTime { get; set; }

        /// <summary>
        /// <para>Start time of the latest execution of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1731378251000</para>
        /// </summary>
        [NameInMap("PlaybookExecutionStartTime")]
        [Validation(Required=false)]
        public long? PlaybookExecutionStartTime { get; set; }

        /// <summary>
        /// <para>Name of the playbook, supports fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_test</para>
        /// </summary>
        [NameInMap("PlaybookName")]
        [Validation(Required=false)]
        public string PlaybookName { get; set; }

        /// <summary>
        /// <para>Collection of input parameter types for the playbook.</para>
        /// </summary>
        [NameInMap("PlaybookParamTypes")]
        [Validation(Required=false)]
        public List<string> PlaybookParamTypes { get; set; }

        /// <summary>
        /// <para>Publication status of the playbook, with values as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Unpublished.</description></item>
        /// <item><description><b>1</b>: Published.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PlaybookStatus")]
        [Validation(Required=false)]
        public int? PlaybookStatus { get; set; }

        /// <summary>
        /// <para>Type of the playbook, with values as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>preset</b>: Predefined playbook.</description></item>
        /// <item><description><b>user</b>: Custom playbook.</description></item>
        /// <item><description><b>component</b>: Security response component.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>preset</para>
        /// </summary>
        [NameInMap("PlaybookType")]
        [Validation(Required=false)]
        public string PlaybookType { get; set; }

        /// <summary>
        /// <para>Collection of UUIDs of playbooks.</para>
        /// </summary>
        [NameInMap("PlaybookUuids")]
        [Validation(Required=false)]
        public List<string> PlaybookUuids { get; set; }

        /// <summary>
        /// <para>User ID for the administrator to switch to another member\&quot;s perspective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13760*****718726</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
