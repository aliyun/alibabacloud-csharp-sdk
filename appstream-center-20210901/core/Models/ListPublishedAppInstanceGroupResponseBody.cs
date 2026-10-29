// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListPublishedAppInstanceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of published delivery groups on the current page, sorted in descending order of creation time. An empty list is returned if no results match or if the requested page exceeds the result range.</para>
        /// </summary>
        [NameInMap("AppInstanceGroupModels")]
        [Validation(Required=false)]
        public List<ListPublishedAppInstanceGroupResponseBodyAppInstanceGroupModels> AppInstanceGroupModels { get; set; }
        public class ListPublishedAppInstanceGroupResponseBodyAppInstanceGroupModels : TeaModel {
            /// <summary>
            /// <para>The ID of the application image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>img-8z4nztpaqvay4****</para>
            /// </summary>
            [NameInMap("AppCenterImageId")]
            [Validation(Required=false)]
            public string AppCenterImageId { get; set; }

            /// <summary>
            /// <para>The ID of the delivery group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The name of the delivery group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Office applications</para>
            /// </summary>
            [NameInMap("AppInstanceGroupName")]
            [Validation(Required=false)]
            public string AppInstanceGroupName { get; set; }

            /// <summary>
            /// <para>The specification type of the delivery group.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b>dynamic</b></para>
            /// </summary>
            [NameInMap("AppInstanceType")]
            [Validation(Required=false)]
            public string AppInstanceType { get; set; }

            /// <summary>
            /// <para>The list of deployed applications in the image of the delivery group. The <c>AppId</c> and <c>AppName</c> parameters in the request only determine whether the delivery group is selected, and do not restrict this list to the matched applications.</para>
            /// </summary>
            [NameInMap("Apps")]
            [Validation(Required=false)]
            public List<ListPublishedAppInstanceGroupResponseBodyAppInstanceGroupModelsApps> Apps { get; set; }
            public class ListPublishedAppInstanceGroupResponseBodyAppInstanceGroupModelsApps : TeaModel {
                /// <summary>
                /// <para>The icon of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://app-center-icon-****.png">https://app-center-icon-****.png</a></para>
                /// </summary>
                [NameInMap("AppIcon")]
                [Validation(Required=false)]
                public string AppIcon { get; set; }

                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ca-i87mycyn419nu****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Office applications</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The version of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                /// <summary>
                /// <para>The version name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Initial version</para>
                /// </summary>
                [NameInMap("AppVersionName")]
                [Validation(Required=false)]
                public string AppVersionName { get; set; }

            }

            /// <summary>
            /// <para>The expiration time of the delivery group. For delivery groups purchased as resources, the expiration time of their resources is returned. For other delivery groups, the expiration time of the delivery group itself is returned. The time is in ISO 8601 date and time format, including milliseconds and time zone offset. The returned time zone offset is +00:00. Format: yyyy-MM-ddTHH:mm:ss.SSS+HH:mm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-27T16:00:00.000+00:00</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The creation time of the delivery group. The time is in ISO 8601 date and time format, including milliseconds and time zone offset. The returned time zone offset is +00:00. Format: yyyy-MM-ddTHH:mm:ss.SSS+HH:mm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-26T15:06:16.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The ID of the region to which the delivery group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The status of the delivery group. This operation only returns delivery groups in the following states:</para>
            /// <list type="bullet">
            /// <item><description><c>PUBLISHED</c>: The delivery group is published and listed, and can be included in the query results of this operation. This status does not indicate that a specified user has obtained access permissions.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLISHED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Indicates whether mixed authorization for users and user groups is supported.</para>
            /// </summary>
            [NameInMap("SupportUserGroupMixedAuth")]
            [Validation(Required=false)]
            public bool? SupportUserGroupMixedAuth { get; set; }

            /// <summary>
            /// <para>The authorization mode for users and user groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Mixed</para>
            /// </summary>
            [NameInMap("UserGroupAuthMode")]
            [Validation(Required=false)]
            public string UserGroupAuthMode { get; set; }

        }

        /// <summary>
        /// <para>The page number specified in the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of delivery groups per page specified in the request. This value does not represent the actual number of entries returned on the current page. The actual number on the current page may be less than this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used to troubleshoot request issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of delivery groups that meet all filter conditions. This value is not the number of entries returned on the current page. Each delivery group is counted only once. If no results match, the value is <c>0</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
