// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListVirusFileStatusesRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in paging. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The department name. Matches any level of the organizational structure to which the user belongs. Specify the department name itself without the full path of the organizational structure. The value can contain Chinese characters, uppercase and lowercase letters, digits, spaces, periods (.), commas (,), forward slashes (/), at signs (@), hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>R&amp;D Department</para>
        /// </summary>
        [NameInMap("Department")]
        [Validation(Required=false)]
        public string Department { get; set; }

        /// <summary>
        /// <para>The unique identifier of the user terminal device. Exact match. The value can be up to 64 characters in length. You can obtain the value from the following operation:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListUserDevices~~">ListUserDevices</a>: Lists user terminal devices.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
        /// </summary>
        [NameInMap("DevTag")]
        [Validation(Required=false)]
        public string DevTag { get; set; }

        /// <summary>
        /// <para>The operating system type of the user terminal device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>windows</b>: Windows.</description></item>
        /// <item><description><b>macOS</b>: macOS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>windows</para>
        /// </summary>
        [NameInMap("DevType")]
        [Validation(Required=false)]
        public string DevType { get; set; }

        /// <summary>
        /// <para>The end time for filtering by virus file discovery time. The value is a UNIX timestamp in seconds. This parameter must be specified together with StartTime and must be later than StartTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1786377600</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The MD5 value of the virus file. Fuzzy match is supported. The value can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d41d8cd98f00b204e9800998ecf8427e</para>
        /// </summary>
        [NameInMap("FileMd5")]
        [Validation(Required=false)]
        public string FileMd5 { get; set; }

        /// <summary>
        /// <para>Filters by disposition status. If this parameter is not specified, no filtering by disposition status is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Pending</b>: Pending disposition.</description></item>
        /// <item><description><b>Processed</b>: Disposed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Pending</para>
        /// </summary>
        [NameInMap("FileProcessStatus")]
        [Validation(Required=false)]
        public string FileProcessStatus { get; set; }

        /// <summary>
        /// <para>The hostname of the user terminal device. Fuzzy match is supported. The value can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DESKTOP-8A3F</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>Filters by disposition action. Duplicate values are not allowed. If this parameter is not specified, no filtering by disposition action is applied.</para>
        /// </summary>
        [NameInMap("Operations")]
        [Validation(Required=false)]
        public List<string> Operations { get; set; }

        /// <summary>
        /// <para>The number of entries per page in paging. Valid values: 1 to 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Filters by risk level. Duplicate values are not allowed. If this parameter is not specified, no filtering by risk level is applied.</para>
        /// </summary>
        [NameInMap("RiskLevels")]
        [Validation(Required=false)]
        public List<string> RiskLevels { get; set; }

        /// <summary>
        /// <para>The user ID. Exact match. The value can be up to 128 characters in length. You can obtain the value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListUserDevices~~">ListUserDevices</a>: Lists user terminal devices.</description></item>
        /// <item><description><a href="~~GetUserDevice~~">GetUserDevice</a>: Queries user terminal device details.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
        /// </summary>
        [NameInMap("SaseUserId")]
        [Validation(Required=false)]
        public string SaseUserId { get; set; }

        /// <summary>
        /// <para>The ID of the virus scan task that detected the virus file. This parameter is used to filter detection results of a specified task. You can obtain the value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListVirusScanTasks~~">ListVirusScanTasks</a>: Lists virus scan tasks.</description></item>
        /// <item><description><a href="~~CreateVirusScanTask~~">CreateVirusScanTask</a>: Creates a virus scan task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>v1:1024772</para>
        /// </summary>
        [NameInMap("ScanTaskId")]
        [Validation(Required=false)]
        public string ScanTaskId { get; set; }

        /// <summary>
        /// <para>The start time for filtering by virus file discovery time. The value is a UNIX timestamp in seconds. This parameter must be specified together with EndTime and must be earlier than EndTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1786291200</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

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
        /// <para>Filters by virus type. Duplicate values are not allowed. If this parameter is not specified, no filtering by virus type is applied.</para>
        /// </summary>
        [NameInMap("VirusTypes")]
        [Validation(Required=false)]
        public List<string> VirusTypes { get; set; }

    }

}
