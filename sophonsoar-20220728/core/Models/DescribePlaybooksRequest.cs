// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybooksRequest : TeaModel {
        /// <summary>
        /// <para>The status of the playbook. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: The playbook is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: The playbook is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Active")]
        [Validation(Required=false)]
        public int? Active { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. This value is a 13-digit timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683858064361</para>
        /// </summary>
        [NameInMap("EndMillis")]
        [Validation(Required=false)]
        public long? EndMillis { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
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
        /// <para>The sort order. Default value: <b>desc</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>desc</b>: descending.</para>
        /// </description></item>
        /// <item><description><para><b>asc</b>: ascending.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The type of the playbook. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>preset</b>: predefined playbook.</para>
        /// </description></item>
        /// <item><description><para><b>user</b>: custom playbook.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("OwnType")]
        [Validation(Required=false)]
        public string OwnType { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 10 entries are returned by default.</para>
        /// <remarks>
        /// <para>Specify a value for this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The trigger type of the playbook. If you do not specify this parameter, playbooks of all trigger types are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>template-incident</b>: security event.</para>
        /// </description></item>
        /// <item><description><para><b>template-ip</b>: IP entity.</para>
        /// </description></item>
        /// <item><description><para><b>template-file</b>: file entity.</para>
        /// </description></item>
        /// <item><description><para><b>template-process</b>: process entity.</para>
        /// </description></item>
        /// <item><description><para><b>template-alert</b>: security alert.</para>
        /// </description></item>
        /// <item><description><para><b>template-domain</b>: domain name entity.</para>
        /// </description></item>
        /// <item><description><para><b>template-container</b>: container entity.</para>
        /// </description></item>
        /// <item><description><para><b>template-host</b>: host entity.</para>
        /// </description></item>
        /// <item><description><para><b>template-custom</b>: custom.</para>
        /// </description></item>
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
        /// <para>Call the <a href="~~CreatePlaybook~~">CreatePlaybook</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8baa6cff-319e-4ede-97bc-1xxxxxx</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        /// <summary>
        /// <para>A comma-separated list of playbook UUIDs. You can specify up to 100 UUIDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8baa6cff-319e-4ede-97bc-1xxxxxx,8rrt6cff-319e-4ede-97bc-1xxxxxx</para>
        /// </summary>
        [NameInMap("PlaybookUuids")]
        [Validation(Required=false)]
        public string PlaybookUuids { get; set; }

        /// <summary>
        /// <para>The field to sort by. Default value: <b>1</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: last modification time.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: last running time.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public int? Sort { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. This value is a 13-digit timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683526277415</para>
        /// </summary>
        [NameInMap("StartMillis")]
        [Validation(Required=false)]
        public long? StartMillis { get; set; }

    }

}
