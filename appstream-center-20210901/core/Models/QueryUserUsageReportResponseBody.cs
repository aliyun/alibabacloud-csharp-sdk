// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryUserUsageReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The business processing status code. <b>A successful response may not contain this field. Do not use <c>Code=200</c> as a necessary condition for success.</b> This field is not equivalent to the HTTP status code. If the request fails, handle it based on the HTTP status code, error code, and error message.</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total number of records that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The description of the business processing result. <b>A successful response may not contain this field. Do not rely on the fixed <c>success</c> text.</b> If the request fails, read the specific error message based on the error code.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number corresponding to the current response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page in the request. If this parameter is not specified, the default value <c>200</c> is returned. If the requested value exceeds <c>1500</c>, this field still returns the echo request value, but the actual query uses a maximum of <c>1500</c>. Refer to the length of the data list for the actual number of returned records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used to troubleshoot the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of user usage data, sorted in descending order of cumulative usage duration.</para>
        /// </summary>
        [NameInMap("UserUsageReportDataModel")]
        [Validation(Required=false)]
        public List<QueryUserUsageReportResponseBodyUserUsageReportDataModel> UserUsageReportDataModel { get; set; }
        public class QueryUserUsageReportResponseBodyUserUsageReportDataModel : TeaModel {
            /// <summary>
            /// <para>The ID of the app instance group to which the user usage record belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The name of the app instance group to which the user usage record belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R&amp;D workstation group</para>
            /// </summary>
            [NameInMap("AppInstanceGroupName")]
            [Validation(Required=false)]
            public string AppInstanceGroupName { get; set; }

            /// <summary>
            /// <para>The current connection status of the user.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>Connected</c>: At least one currently connected session exists.</description></item>
            /// <item><description><c>Disconnected</c>: The session binding is retained, but no currently connected session exists.</description></item>
            /// <item><description><c>Unbound</c>: No session binding exists.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Connected</para>
            /// </summary>
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// <para>The last connection time. Format: <c>yyyy-MM-dd HH:mm:ss</c>. If a current session binding record exists, the connection time of this record is used. Otherwise, the historical connection record is used. If no available connection time exists, <c>-</c> is returned. This time is not limited by the statistical date range in the request.</para>
            /// <para>The time is in Beijing time (UTC+8). The returned string does not carry <c>Z</c> or a time zone offset. For example, <c>2026-09-01 10:00:00</c> indicates 10:00:00 on September 1, 2026, Beijing time. Do not parse it as UTC time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-01 10:00:00</para>
            /// </summary>
            [NameInMap("LastConnectedTime")]
            [Validation(Required=false)]
            public string LastConnectedTime { get; set; }

            /// <summary>
            /// <para>The current version does not return a valid region ID. Callers should not rely on this field. To filter by business region, use the <c>BizRegionId</c> request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The cumulative session persistence duration within the query range, which is the duration that the user occupies the session from attach to session release. Multiple sessions under the same app instance group are accumulated. Unit: hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.5</para>
            /// </summary>
            [NameInMap("SessionsHoldDuration")]
            [Validation(Required=false)]
            public double? SessionsHoldDuration { get; set; }

            /// <summary>
            /// <para>The cumulative user usage duration within the query range. The usage duration of the same user under the same app instance group is aggregated by day. Unit: hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("UsageDuration")]
            [Validation(Required=false)]
            public double? UsageDuration { get; set; }

            /// <summary>
            /// <para>The ID of the end user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user01</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
