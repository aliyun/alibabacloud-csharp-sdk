// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyUserDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Information displayed on the query result page.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribePropertyUserDetailResponseBodyPageInfo PageInfo { get; set; }
        public class DescribePropertyUserDetailResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of fingerprint information of account assets displayed on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page during pagination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The NextToken value returned using the NextToken method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B604532DEF982B875E8360A6EFA3B***</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The number of account asset fingerprint information items to display per page during pagination. The default value is <b>10</b>, indicating that 10 items of account asset fingerprint information are displayed per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of account asset fingerprint information items queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Details list of the queried account asset fingerprint information.</para>
        /// </summary>
        [NameInMap("Propertys")]
        [Validation(Required=false)]
        public List<DescribePropertyUserDetailResponseBodyPropertys> Propertys { get; set; }
        public class DescribePropertyUserDetailResponseBodyPropertys : TeaModel {
            /// <summary>
            /// <para>The expiration date of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>never</para>
            /// </summary>
            [NameInMap("AccountsExpirationDate")]
            [Validation(Required=false)]
            public string AccountsExpirationDate { get; set; }

            /// <summary>
            /// <para>The timestamp of the latest scan of the asset fingerprint. The unit is milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649149566000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>Detailed information about the user groups of the queried account.</para>
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
            /// <para>Whether it is an interactive login account. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No</description></item>
            /// <item><description><b>1</b>: Yes</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsCouldLogin")]
            [Validation(Required=false)]
            public int? IsCouldLogin { get; set; }

            /// <summary>
            /// <para>Whether the password has expired. The values are:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Expired</description></item>
            /// <item><description><b>1</b>: Not expired</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsPasswdExpired")]
            [Validation(Required=false)]
            public int? IsPasswdExpired { get; set; }

            /// <summary>
            /// <para>Whether the password is locked. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Locked </description></item>
            /// <item><description><b>1</b>: Not locked</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsPasswdLocked")]
            [Validation(Required=false)]
            public int? IsPasswdLocked { get; set; }

            /// <summary>
            /// <para>Whether the account has ROOT permissions. The values include:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No</description></item>
            /// <item><description><b>1</b>: Yes</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsRoot")]
            [Validation(Required=false)]
            public string IsRoot { get; set; }

            /// <summary>
            /// <para>Whether it is a sudo account. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No </description></item>
            /// <item><description><b>1</b>: Yes</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsSudoer")]
            [Validation(Required=false)]
            public int? IsSudoer { get; set; }

            /// <summary>
            /// <para>Whether the user has expired. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Expired</description></item>
            /// <item><description><b>1</b>: Not expired</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsUserExpired")]
            [Validation(Required=false)]
            public int? IsUserExpired { get; set; }

            /// <summary>
            /// <para>The source IP from which the account last logged in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("LastLoginIp")]
            [Validation(Required=false)]
            public string LastLoginIp { get; set; }

            /// <summary>
            /// <para>The last login time of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-04 18:07:06</para>
            /// </summary>
            [NameInMap("LastLoginTime")]
            [Validation(Required=false)]
            public string LastLoginTime { get; set; }

            /// <summary>
            /// <para>The timestamp of the last login of the account. The unit is milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649066826000</para>
            /// </summary>
            [NameInMap("LastLoginTimeDt")]
            [Validation(Required=false)]
            public long? LastLoginTimeDt { get; set; }

            /// <summary>
            /// <para>The timestamp of the last login of the account. The unit is milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649066826000</para>
            /// </summary>
            [NameInMap("LastLoginTimestamp")]
            [Validation(Required=false)]
            public long? LastLoginTimestamp { get; set; }

            /// <summary>
            /// <para>The expiration date of the account password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>never</para>
            /// </summary>
            [NameInMap("PasswordExpirationDate")]
            [Validation(Required=false)]
            public string PasswordExpirationDate { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated and should be ignored.</para>
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
        /// <para>The ID of the current request, which is a unique identifier generated by Alibaba Cloud for the request, and can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33A71BE3-2CC2-14CB-B460-33A1DD82953A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
