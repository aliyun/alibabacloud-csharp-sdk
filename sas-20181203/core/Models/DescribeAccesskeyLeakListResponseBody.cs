// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAccesskeyLeakListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of detailed information about leaked AccessKey pairs.</para>
        /// </summary>
        [NameInMap("AccessKeyLeakList")]
        [Validation(Required=false)]
        public List<DescribeAccesskeyLeakListResponseBodyAccessKeyLeakList> AccessKeyLeakList { get; set; }
        public class DescribeAccesskeyLeakListResponseBodyAccessKeyLeakList : TeaModel {
            /// <summary>
            /// <para>The leaked AccessKey ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourAccessKeyID</para>
            /// </summary>
            [NameInMap("AccesskeyId")]
            [Validation(Required=false)]
            public string AccesskeyId { get; set; }

            /// <summary>
            /// <para>The name of the affected Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testAccountName</para>
            /// </summary>
            [NameInMap("AliUserName")]
            [Validation(Required=false)]
            public string AliUserName { get; set; }

            /// <summary>
            /// <para>The platform where the asset resides. The value is fixed as <b>Cloud Platform</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>云平台</para>
            /// </summary>
            [NameInMap("Asset")]
            [Validation(Required=false)]
            public string Asset { get; set; }

            /// <summary>
            /// <para>The time when the AccessKey leak information was processed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-03 21:23:38</para>
            /// </summary>
            [NameInMap("DealTime")]
            [Validation(Required=false)]
            public string DealTime { get; set; }

            /// <summary>
            /// <para>The method used to handle the AccessKey leak information. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pending</b>: unprocessed</description></item>
            /// <item><description><b>manual</b>: manually processed</description></item>
            /// <item><description><b>disable</b>: disabled</description></item>
            /// <item><description><b>add-whitelist</b>: added to the whitelist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("DealType")]
            [Validation(Required=false)]
            public string DealType { get; set; }

            /// <summary>
            /// <para>The time when the AccessKey leak was first discovered. This parameter is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1612357897000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The primary key ID in the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>389357</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The processing status of the leaked AccessKey information. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pending</b>: unprocessed</description></item>
            /// <item><description><b>dealed</b>: processed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the leak information. The value is fixed as <b>AccessKey</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AccessKey</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The URL of the external platform where the AccessKey leak was discovered.</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>The type of the account to which the leaked AccessKey pair belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>master</b>: Alibaba Cloud account</description></item>
            /// <item><description><b>ram</b>: Resource Access Management (RAM) user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

        /// <summary>
        /// <para>The number of unprocessed AccessKey leak entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AkLeakCount")]
        [Validation(Required=false)]
        public int? AkLeakCount { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated and can be ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1612357897000</para>
        /// </summary>
        [NameInMap("GmtLast")]
        [Validation(Required=false)]
        public long? GmtLast { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique ID generated by Alibaba Cloud for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B37C9052-A73E-4707-A024-9247702852BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of AccessKey leak entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
