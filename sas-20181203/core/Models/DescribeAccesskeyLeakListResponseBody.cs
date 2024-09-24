// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAccesskeyLeakListResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the details about AccessKey pair leaks.</para>
        /// </summary>
        [NameInMap("AccessKeyLeakList")]
        [Validation(Required=false)]
        public List<DescribeAccesskeyLeakListResponseBodyAccessKeyLeakList> AccessKeyLeakList { get; set; }
        public class DescribeAccesskeyLeakListResponseBodyAccessKeyLeakList : TeaModel {
            /// <summary>
            /// <para>The ID of the AccessKey pair that is leaked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LTAI4Fytv7ALKzkNVBV6****</para>
            /// </summary>
            [NameInMap("AccesskeyId")]
            [Validation(Required=false)]
            public string AccesskeyId { get; set; }

            /// <summary>
            /// <para>The name of the Alibaba Cloud account that is affected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testAccountName</para>
            /// </summary>
            [NameInMap("AliUserName")]
            [Validation(Required=false)]
            public string AliUserName { get; set; }

            /// <summary>
            /// <para>The platform to which the asset belongs. The value is fixed as <b>Cloud platform</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Cloud platform</para>
            /// </summary>
            [NameInMap("Asset")]
            [Validation(Required=false)]
            public string Asset { get; set; }

            /// <summary>
            /// <para>The time when the AccessKey pair leak is handled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-03 21:23:38</para>
            /// </summary>
            [NameInMap("DealTime")]
            [Validation(Required=false)]
            public string DealTime { get; set; }

            /// <summary>
            /// <para>The method to handle the AccessKey pair leak. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pending</b>: The AccessKey pair leak is unhandled.</description></item>
            /// <item><description><b>manual</b>: The AccessKey pair leak is manually handled.</description></item>
            /// <item><description><b>disable</b>: The AccessKey pair leak is disabled.</description></item>
            /// <item><description><b>add-whitelist</b>: The AccessKey pair leak is added to the whitelist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("DealType")]
            [Validation(Required=false)]
            public string DealType { get; set; }

            /// <summary>
            /// <para>The time when the AccessKey pair leak is first detected. The value of this parameter is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1612357897000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The primary key ID of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>389357</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the AccessKey pair leak is handled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pending</b>: unhandled</description></item>
            /// <item><description><b>dealed</b>: handled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the leak. The value is fixed as <b>AccessKey</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AccessKey</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The URL of the platform on which the AccessKey pair leak is detected.</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>The type of the account to which the leaked AccessKey pair belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>master</b>: Alibaba Cloud account</description></item>
            /// <item><description><b>ram</b>: RAM user</description></item>
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
        /// <para>The number of AccessKey pair leaks that are unhandled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AkLeakCount")]
        [Validation(Required=false)]
        public int? AkLeakCount { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1612357897000</para>
        /// </summary>
        [NameInMap("GmtLast")]
        [Validation(Required=false)]
        public long? GmtLast { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B37C9052-A73E-4707-A024-9247702852BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of AccessKey pair leaks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
