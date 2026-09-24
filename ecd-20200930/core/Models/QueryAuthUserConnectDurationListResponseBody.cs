// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class QueryAuthUserConnectDurationListResponseBody : TeaModel {
        /// <summary>
        /// <para>The connection duration list of authorized users.</para>
        /// </summary>
        [NameInMap("AuthUserConnectDurationList")]
        [Validation(Required=false)]
        public List<QueryAuthUserConnectDurationListResponseBodyAuthUserConnectDurationList> AuthUserConnectDurationList { get; set; }
        public class QueryAuthUserConnectDurationListResponseBodyAuthUserConnectDurationList : TeaModel {
            /// <summary>
            /// <para>The connection duration of the user, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("ConnectDuration")]
            [Validation(Required=false)]
            public long? ConnectDuration { get; set; }

            /// <summary>
            /// <para>The end time of the connection, as a UNIX timestamp in milliseconds. This parameter is returned only when statistics are collected by individual session details (StatisticType=SingleSession).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719208800000</para>
            /// </summary>
            [NameInMap("ConnectEndTime")]
            [Validation(Required=false)]
            public string ConnectEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the connection, as a UNIX timestamp in milliseconds. This parameter is returned only when statistics are collected by individual session details (StatisticType=SingleSession).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719205200000</para>
            /// </summary>
            [NameInMap("ConnectStartTime")]
            [Validation(Required=false)]
            public string ConnectStartTime { get; set; }

            /// <summary>
            /// <para>The remarks of the user. This parameter is returned only for convenience users when WithDetail is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R&amp;D department employee</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The cloud desktop ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-gx2x1dhsmusr2****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The cloud desktop name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-desktop</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The type of the directory to which the user belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: convenience account.</description></item>
            /// <item><description>2: RAM account.</description></item>
            /// <item><description>3: AD account.</description></item>
            /// <item><description>4: personal edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public int? DirectoryType { get; set; }

            /// <summary>
            /// <para>The display name of the user. This parameter is returned only for AD users when WithDetail is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhang San</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The new display name of the user. This parameter is returned only for AD users when WithDetail is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhang San</para>
            /// </summary>
            [NameInMap("DisplayNameNew")]
            [Validation(Required=false)]
            public string DisplayNameNew { get; set; }

            /// <summary>
            /// <para>The AD domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The end user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The nickname of the user. This parameter is returned only for convenience users when WithDetail is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Xiao Zhang</para>
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The user principal name (UPN). This parameter is returned only for AD users when WithDetail is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:alice@example.com">alice@example.com</a></para>
            /// </summary>
            [NameInMap("UserPrincipalName")]
            [Validation(Required=false)]
            public string UserPrincipalName { get; set; }

        }

        /// <summary>
        /// <para>The pagination token for the next page. This parameter is returned when the results span multiple pages. Pass this value as the NextToken in the next request to retrieve the next page. This parameter is returned only when statistics are collected by individual session details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d129c6c0e8c04c8a9f0e2b7c1a3f5e6d</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F0F0F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records that match the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
