// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryUserUsageReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates that the request is successful. Other values indicate that the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
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
        /// <para>The description of the request processing result. Typically, success is returned when the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
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
        /// <para>The number of entries per page used in the current response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. You can use this ID to troubleshoot request issues.</para>
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
            /// <para>The last connection time. Format: <c>yyyy-MM-dd HH:mm:ss</c>. If no current or historical connection record exists, - is returned. The string itself does not carry a time zone and is interpreted as Asia/Shanghai (UTC+8).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-01 10:00:00</para>
            /// </summary>
            [NameInMap("LastConnectedTime")]
            [Validation(Required=false)]
            public string LastConnectedTime { get; set; }

            /// <summary>
            /// <para>The current version does not return a valid region ID. Callers should not rely on this field. To filter by business region, use the BizRegionId request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The cumulative session persistence duration within the query range. This is the duration during which the user occupies the session from session attach to session release. Multiple sessions under the same app instance group are accumulated. Unit: hours.</para>
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
