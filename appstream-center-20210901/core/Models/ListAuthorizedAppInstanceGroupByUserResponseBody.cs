// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAuthorizedAppInstanceGroupByUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of authorized delivery groups on the current page. If the user does not have any authorized delivery groups that meet the conditions, an empty list is returned.</para>
        /// </summary>
        [NameInMap("AppInstanceGroupModels")]
        [Validation(Required=false)]
        public List<ListAuthorizedAppInstanceGroupByUserResponseBodyAppInstanceGroupModels> AppInstanceGroupModels { get; set; }
        public class ListAuthorizedAppInstanceGroupByUserResponseBodyAppInstanceGroupModels : TeaModel {
            /// <summary>
            /// <para>The ID of the application image used by the delivery group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>img-8z4nztpaqvay4****</para>
            /// </summary>
            [NameInMap("AppCenterImageId")]
            [Validation(Required=false)]
            public string AppCenterImageId { get; set; }

            /// <summary>
            /// <para>The delivery group ID. When you call the <a href="~~GetConnectionTicket~~">GetConnectionTicket</a> operation, you can specify this value to indicate the delivery group to connect to.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The delivery group name.</para>
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
            /// <para>The list of applications deployed in the delivery group. This list includes all applications deployed in the delivery group image and is not affected by the AppId and AppName request parameters.</para>
            /// </summary>
            [NameInMap("Apps")]
            [Validation(Required=false)]
            public List<ListAuthorizedAppInstanceGroupByUserResponseBodyAppInstanceGroupModelsApps> Apps { get; set; }
            public class ListAuthorizedAppInstanceGroupByUserResponseBodyAppInstanceGroupModelsApps : TeaModel {
                /// <summary>
                /// <para>The URL of the application icon.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://app-center-icon-****.png">https://app-center-icon-****.png</a></para>
                /// </summary>
                [NameInMap("AppIcon")]
                [Validation(Required=false)]
                public string AppIcon { get; set; }

                /// <summary>
                /// <para>The application ID. When you call the <a href="~~GetConnectionTicket~~">GetConnectionTicket</a> operation to obtain the connection ticket for the application, specify this value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ca-i87mycyn419nu****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Office applications</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The application version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                /// <summary>
                /// <para>The application version name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Initial version</para>
                /// </summary>
                [NameInMap("AppVersionName")]
                [Validation(Required=false)]
                public string AppVersionName { get; set; }

            }

            /// <summary>
            /// <para>The expiration time of the delivery group. The time is in ISO 8601 format with milliseconds and a time zone offset of +00:00. Format: yyyy-MM-ddTHH:mm:ss.SSS+HH:mm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-27T16:00:00.000+00:00</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The creation time of the delivery group. The time is in ISO 8601 format with milliseconds and a time zone offset of +00:00. Format: yyyy-MM-ddTHH:mm:ss.SSS+HH:mm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-26T15:06:16.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The region ID of the delivery group. For more information about supported regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Limits</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The status of the delivery group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DEPLOYING: Deploying. The delivery group is creating or starting resources and cannot be connected to.</description></item>
            /// <item><description>DEPLOYED: Deployed. Resources are ready but the delivery group is not published for external services.</description></item>
            /// <item><description>PUBLISHED: Published. The delivery group is published and users can connect to it.</description></item>
            /// <item><description>STOPPING: Unpublishing. The delivery group is stopping services.</description></item>
            /// <item><description>STOPPED: Unpublished. The delivery group has stopped services and users cannot connect to it.</description></item>
            /// <item><description>MAINTAINING: Updating. The delivery group is undergoing maintenance or changes.</description></item>
            /// <item><description>FAILED: Publishing failed. Resource initialization failed.</description></item>
            /// <item><description>MAINTAIN_FAILED: Update failed. Maintenance or changes were not successful.</description></item>
            /// <item><description>DELETING: Deleting. The delivery group is being deleted.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Deleted delivery groups are not returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLISHED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Specifies whether mixed authorization of users and user groups is supported.</para>
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
        /// <para>The current page number. The value is the same as the PageNumber request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of delivery groups returned per page. The value is the same as the PageSize request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of authorized delivery groups that meet the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
