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
        /// <item><description><b>1</b>: enabled</description></item>
        /// <item><description><b>0</b>: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Active")]
        [Validation(Required=false)]
        public int? Active { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is a 13-digit timestamp.</para>
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
        /// <item><description><b>zh</b>: Chinese</description></item>
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
        /// <para>The name of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_playbook</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sorting order. Default value: desc. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>desc: descending order</description></item>
        /// <item><description>asc: ascending order</description></item>
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
        /// <item><description><b>preset</b>: predefined playbook</description></item>
        /// <item><description><b>user</b>: custom playbook</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("OwnType")]
        [Validation(Required=false)]
        public string OwnType { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1. Pages start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. If you leave this parameter empty, 10 entries are returned on each page.</para>
        /// <remarks>
        /// <para> We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("ParamTypes")]
        [Validation(Required=false)]
        public string ParamTypes { get; set; }

        /// <summary>
        /// <para>The playbook UUID.</para>
        /// <remarks>
        /// <para> You can use the UUID to query the information about a specific playbook.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a> operation to query the playbook UUID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8baa6cff-319e-4ede-97bc-1xxxxxx</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        /// <summary>
        /// <para>The sorting basis. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: last modification time</description></item>
        /// <item><description>2: last execution time</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a 13-digit timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683526277415</para>
        /// </summary>
        [NameInMap("StartMillis")]
        [Validation(Required=false)]
        public long? StartMillis { get; set; }

    }

}
