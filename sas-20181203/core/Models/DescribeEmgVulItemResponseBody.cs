// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeEmgVulItemResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page. The value starts from <b>1</b>. Default value: <b>1</b>, which indicates that the first page is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The information about the emergency vulnerabilities.</para>
        /// </summary>
        [NameInMap("GroupedVulItems")]
        [Validation(Required=false)]
        public List<DescribeEmgVulItemResponseBodyGroupedVulItems> GroupedVulItems { get; set; }
        public class DescribeEmgVulItemResponseBodyGroupedVulItems : TeaModel {
            /// <summary>
            /// <para>The name of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Changjietong T + SetupAccount/Upload.aspx file Upload vulnerability (CNVD-2022-60632)</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The check type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            /// <summary>
            /// <para>The description of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Chanjet T-Plus is an Internet business management software. There is an unauthorized access vulnerability in one of its interfaces disclosed on the Internet. Attackers can construct malicious requests to upload malicious files to execute arbitrary code and control the server.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The timestamp of the most recent vulnerability detection. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1619286031000</para>
            /// </summary>
            [NameInMap("GmtLastCheck")]
            [Validation(Required=false)]
            public long? GmtLastCheck { get; set; }

            /// <summary>
            /// <para>The timestamp when the vulnerability was published. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1618887687000</para>
            /// </summary>
            [NameInMap("GmtPublish")]
            [Validation(Required=false)]
            public long? GmtPublish { get; set; }

            /// <summary>
            /// <para>The name of the scan rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>scan:AVD-2021-179344</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of unfixed vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PendingCount")]
            [Validation(Required=false)]
            public int? PendingCount { get; set; }

            /// <summary>
            /// <para>The detection progress of the vulnerability. Value range: 0 to 100.</para>
            /// <remarks>
            /// <para>This parameter is displayed only for emergency vulnerabilities that are in the detecting state.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>Indicates whether Runtime Application Self-Protection (RASP) real-time protection is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Not supported.</description></item>
            /// <item><description><b>1</b>: Supported.<remarks>
            /// <para>If this property is not present, RASP real-time protection is not supported.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RaspDefend")]
            [Validation(Required=false)]
            public int? RaspDefend { get; set; }

            /// <summary>
            /// <para>The detection status of the vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>10</b>: not detected</description></item>
            /// <item><description><b>20</b>: detecting</description></item>
            /// <item><description><b>30</b>: detection completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The detection method of the vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>python</b>: version detection (server software version detection). Detects whether your server has disclosed software vulnerabilities.</description></item>
            /// <item><description><b>scan</b>: network scanning (network traffic detection). Detects whether your public assets (Internet-accessible servers) have vulnerabilities.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>scan</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The number of emergency vulnerability entries per page in a paged query. Default value: <b>10</b>, which indicates that 10 emergency vulnerability entries are displayed per page. Paging is used to display the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC1868ED-A0E1-4D1C-BF7E-10DC0C34B3C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of emergency vulnerabilities returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
