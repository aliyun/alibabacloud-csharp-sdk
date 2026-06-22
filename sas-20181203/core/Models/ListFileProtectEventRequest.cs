// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListFileProtectEventRequest : TeaModel {
        /// <summary>
        /// <para>The list of alert notification levels.</para>
        /// </summary>
        [NameInMap("AlertLevels")]
        [Validation(Required=false)]
        public List<int?> AlertLevels { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The timestamp of the end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683257937775</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the asset instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1g6wxdwps7s9dz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the server to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca_cpm_****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The public IP address of the asset to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120.27.XX.XX</para>
        /// </summary>
        [NameInMap("InternetIp")]
        [Validation(Required=false)]
        public string InternetIp { get; set; }

        /// <summary>
        /// <para>The private IP address of the asset to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.26.XX.XX</para>
        /// </summary>
        [NameInMap("IntranetIp")]
        [Validation(Required=false)]
        public string IntranetIp { get; set; }

        /// <summary>
        /// <para>The type of operation performed on the file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DELETE</b>: deletes the file.</description></item>
        /// <item><description><b>WRITE</b>: writes to the file.</description></item>
        /// <item><description><b>READ</b>: reads the file.</description></item>
        /// <item><description><b>RENAME</b>: renames the file.</description></item>
        /// <item><description><b>CHOWN</b>: changes the file owner and associated group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>READ</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-rule-1</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The timestamp of the start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656038740435</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The event status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Unhandled. </description></item>
        /// <item><description>1: Manually handled.</description></item>
        /// <item><description>2: Whitelisted.</description></item>
        /// <item><description>3: Ignored.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The UUID of the server to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4fe8e1cd-3c37-4851-b9de-124da32c****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
