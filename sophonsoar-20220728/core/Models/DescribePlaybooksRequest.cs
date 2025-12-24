// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybooksRequest : TeaModel {
        /// <summary>
        /// <para>Activation status of the playbook. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Indicates the playbook is activated.</description></item>
        /// <item><description><b>0</b>: Indicates the playbook is not activated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Active")]
        [Validation(Required=false)]
        public int? Active { get; set; }

        /// <summary>
        /// <para>End time for the query, in 13-digit timestamp format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683858064361</para>
        /// </summary>
        [NameInMap("EndMillis")]
        [Validation(Required=false)]
        public long? EndMillis { get; set; }

        /// <summary>
        /// <para>Specifies the language type for the request and response, default is <b>zh</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_playbook</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sorting logic, with a default value of <b>desc</b>. Values:</para>
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
        /// <para>Type of the playbook. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>preset</b>: Predefined playbook.</description></item>
        /// <item><description><b>user</b>: Custom playbook.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("OwnType")]
        [Validation(Required=false)]
        public string OwnType { get; set; }

        /// <summary>
        /// <para>Sets the page number from which to start displaying the query results. The default value is 1, indicating the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>Specifies the maximum number of items to display per page in a paginated query. The default number of items per page is 20. If the PageSize parameter is empty, it will return 10 items by default.</para>
        /// <remarks>
        /// <para>It is recommended that the PageSize value is not empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The trigger method for the playbook, with a default value of <b>query all</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>template-incident</b>: Security incident.</description></item>
        /// <item><description><b>template-ip</b>: IP entity.</description></item>
        /// <item><description><b>template-file</b>: File entity.</description></item>
        /// <item><description><b>template-process</b>: Process entity.</description></item>
        /// <item><description><b>template-alert</b>: Security alert.</description></item>
        /// <item><description><b>template-domain</b>: Domain entity.</description></item>
        /// <item><description><b>template-container</b>: Container entity.</description></item>
        /// <item><description><b>template-host</b>: Host entity.</description></item>
        /// <item><description><b>template-custom</b>: Custom.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>template-alert</para>
        /// </summary>
        [NameInMap("ParamTypes")]
        [Validation(Required=false)]
        public string ParamTypes { get; set; }

        /// <summary>
        /// <para>The UUID of the playbook.</para>
        /// <remarks>
        /// <para>You can use the UUID to query specific playbook information.</para>
        /// <list type="bullet">
        /// <item><description>Call the <a href="~~CreatePlaybook~~">CreatePlaybook</a> API to obtain this parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8baa6cff-319e-4ede-97bc-1xxxxxx</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        /// <summary>
        /// <para>UUID List of the playbook.</para>
        /// <para>Note You can use the UUID list to query specific playbook information.
        /// Call the DescribePlaybooks API to obtain this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8baa6cff-319e-4ede-97bc-1xxxxxx,7745e6cff-319e-4ede-97bc-1xxxxxx</para>
        /// </summary>
        [NameInMap("PlaybookUuids")]
        [Validation(Required=false)]
        public string PlaybookUuids { get; set; }

        /// <summary>
        /// <para>The sorting basis, with a default value of <b>1</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Last modified time.</description></item>
        /// <item><description><b>2</b>: Most recent execution time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public int? Sort { get; set; }

        /// <summary>
        /// <para>Start time for the query, in 13-digit timestamp format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683526277415</para>
        /// </summary>
        [NameInMap("StartMillis")]
        [Validation(Required=false)]
        public long? StartMillis { get; set; }

    }

}
