// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyUserDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information of the query result.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribePropertyUserDetailResponseBodyPageInfo PageInfo { get; set; }
        public class DescribePropertyUserDetailResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of account asset fingerprint entries on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

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
            /// <para>The NextToken value returned when the NextToken method is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B604532DEF982B875E8360A6EFA3B***</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The number of account asset fingerprint entries per page in a paging query. Default value: <b>10</b>, which indicates 10 account asset fingerprint entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of account asset fingerprint entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The details of the account asset fingerprint entries returned.</para>
        /// </summary>
        [NameInMap("Propertys")]
        [Validation(Required=false)]
        public List<DescribePropertyUserDetailResponseBodyPropertys> Propertys { get; set; }
        public class DescribePropertyUserDetailResponseBodyPropertys : TeaModel {
            /// <summary>
            /// <para>The expiration time of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>never</para>
            /// </summary>
            [NameInMap("AccountsExpirationDate")]
            [Validation(Required=false)]
            public string AccountsExpirationDate { get; set; }

            /// <summary>
            /// <para>The timestamp of the latest Asset Fingerprints scan. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649149566000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The details of the user groups to which the account belongs.</para>
            /// </summary>
            [NameInMap("GroupNames")]
            [Validation(Required=false)]
            public List<string> GroupNames { get; set; }

            /// <summary>
            /// <para>The instance ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-hp35tftuh52wbp1g****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the server instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hc-host-****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.104.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The list of IP addresses of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>Indicates whether the account is an interactive logon account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No.</description></item>
            /// <item><description><b>1</b>: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsCouldLogin")]
            [Validation(Required=false)]
            public int? IsCouldLogin { get; set; }

            /// <summary>
            /// <para>Indicates whether the password has expired. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Expired.</description></item>
            /// <item><description><b>1</b>: Not expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsPasswdExpired")]
            [Validation(Required=false)]
            public int? IsPasswdExpired { get; set; }

            /// <summary>
            /// <para>Indicates whether the password is locked. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Locked.</description></item>
            /// <item><description><b>1</b>: Not locked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsPasswdLocked")]
            [Validation(Required=false)]
            public int? IsPasswdLocked { get; set; }

            /// <summary>
            /// <para>Indicates whether the account has ROOT permissions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No.</description></item>
            /// <item><description><b>1</b>: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsRoot")]
            [Validation(Required=false)]
            public string IsRoot { get; set; }

            /// <summary>
            /// <para>Indicates whether the account is a sudo account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No.</description></item>
            /// <item><description><b>1</b>: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsSudoer")]
            [Validation(Required=false)]
            public int? IsSudoer { get; set; }

            /// <summary>
            /// <para>Indicates whether the user has expired. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Expired.</description></item>
            /// <item><description><b>1</b>: Not expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsUserExpired")]
            [Validation(Required=false)]
            public int? IsUserExpired { get; set; }

            /// <summary>
            /// <para>The source IP address of the last logon of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("LastLoginIp")]
            [Validation(Required=false)]
            public string LastLoginIp { get; set; }

            /// <summary>
            /// <para>The time of the last logon of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-04 18:07:06</para>
            /// </summary>
            [NameInMap("LastLoginTime")]
            [Validation(Required=false)]
            public string LastLoginTime { get; set; }

            /// <summary>
            /// <para>The timestamp of the last logon of the account. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649066826000</para>
            /// </summary>
            [NameInMap("LastLoginTimeDt")]
            [Validation(Required=false)]
            public long? LastLoginTimeDt { get; set; }

            /// <summary>
            /// <para>The timestamp of the last logon of the account. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649066826000</para>
            /// </summary>
            [NameInMap("LastLoginTimestamp")]
            [Validation(Required=false)]
            public long? LastLoginTimestamp { get; set; }

            /// <summary>
            /// <para>The expiration time of the account password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>never</para>
            /// </summary>
            [NameInMap("PasswordExpirationDate")]
            [Validation(Required=false)]
            public string PasswordExpirationDate { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated and can be ignored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>**</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The name of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bin</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>162eb349-c2d9-4f8b-805c-75b43d4c****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33A71BE3-2CC2-14CB-B460-33A1DD82953A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
