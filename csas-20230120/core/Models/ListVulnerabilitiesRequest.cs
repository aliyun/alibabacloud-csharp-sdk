// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListVulnerabilitiesRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in a paged query with paging. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The department name. Matches any level of department in the organizational structure to which the user belongs. Specify the department name itself without the full path of the organizational structure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>R&amp;D Department</para>
        /// </summary>
        [NameInMap("Department")]
        [Validation(Required=false)]
        public string Department { get; set; }

        /// <summary>
        /// <para>The unique identifier of the user endpoint device. Exact match. The value can be up to 64 characters in length. Valid values are obtained from:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListUserDevices~~">ListUserDevices</a>: lists user endpoint devices.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
        /// </summary>
        [NameInMap("DevTag")]
        [Validation(Required=false)]
        public string DevTag { get; set; }

        /// <summary>
        /// <para>The operating system type of the user endpoint device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>windows</b>: Windows. Currently, vulnerability scanning supports only Windows.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>windows</para>
        /// </summary>
        [NameInMap("DevType")]
        [Validation(Required=false)]
        public string DevType { get; set; }

        /// <summary>
        /// <para>The hostname of the user endpoint device. Fuzzy match is supported. The value can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DESKTOP-8A3F</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Settings for paged query with paging. Valid values: 1 to 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The user ID. Exact match. Valid values are obtained from:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListUserDevices~~">ListUserDevices</a>: lists user endpoint devices.</description></item>
        /// <item><description><a href="~~GetUserDevice~~">GetUserDevice</a>: queries the details of a user endpoint device.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
        /// </summary>
        [NameInMap("SaseUserId")]
        [Validation(Required=false)]
        public string SaseUserId { get; set; }

        /// <summary>
        /// <para>The ID of the vulnerability scanning node that detected the vulnerability. Used to filter detection results of a specified node. Valid values are obtained from:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListVulScanTasks~~">ListVulScanTasks</a>: lists vulnerability scanning nodes.</description></item>
        /// <item><description><a href="~~CreateVulScanTask~~">CreateVulScanTask</a>: creates a vulnerability scanning node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vul-scan-task-4d7b1e9a6c38****</para>
        /// </summary>
        [NameInMap("ScanTaskId")]
        [Validation(Required=false)]
        public string ScanTaskId { get; set; }

        /// <summary>
        /// <para>The vulnerability title. Fuzzy match is supported. Matches both Chinese and English titles.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cumulative Update</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The patch IDs used for filtering. A maximum of 100 IDs can be specified. Duplicate values are not allowed.</para>
        /// </summary>
        [NameInMap("UpdateIds")]
        [Validation(Required=false)]
        public List<string> UpdateIds { get; set; }

        /// <summary>
        /// <para>The username. Fuzzy match is supported. The value can be up to 128 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), asterisks (*), hyphens (-), at signs (@), spaces, middle dots (·), and parentheses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>John Smith</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The vulnerability risk level used for filtering. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>High</b>: high risk.</description></item>
        /// <item><description><b>Mid</b>: medium risk.</description></item>
        /// <item><description><b>Low</b>: low risk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>High</para>
        /// </summary>
        [NameInMap("VulLevel")]
        [Validation(Required=false)]
        public string VulLevel { get; set; }

        /// <summary>
        /// <para>The vulnerability type used for filtering. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>windows</b>: Windows system vulnerability.</description></item>
        /// <item><description><b>ai_agent</b>: AI Agent vulnerability.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>windows</para>
        /// </summary>
        [NameInMap("VulType")]
        [Validation(Required=false)]
        public string VulType { get; set; }

    }

}
