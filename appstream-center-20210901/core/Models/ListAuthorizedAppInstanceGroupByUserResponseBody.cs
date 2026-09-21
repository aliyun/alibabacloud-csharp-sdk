// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAuthorizedAppInstanceGroupByUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of authorized delivery groups on the current page. This is an empty list if the user has no authorized delivery groups that match the conditions.</para>
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
            /// <para>The delivery group ID. You can pass this value to the <a href="~~GetConnectionTicket~~">GetConnectionTicket</a> operation to specify the delivery group to connect to.</para>
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
            /// <para>Office App</para>
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
            /// <para>The list of applications deployed in the delivery group. This list includes all deployed applications in the delivery group image and is not affected by the AppId or AppName request parameters.</para>
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
                /// <para>The application ID. Pass this value to the <a href="~~GetConnectionTicket~~">GetConnectionTicket</a> operation to obtain a connection ticket for the application.</para>
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
                /// <para>Office App</para>
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
            /// <para>The expiration time of the delivery group. The value is in the ISO 8601 datetime format with milliseconds and a time zone offset. The returned time zone offset is +00:00. Format: yyyy-MM-ddTHH:mm:ss.SSS+HH:mm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-27T16:00:00.000+00:00</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The creation time of the delivery group. The value is in the ISO 8601 datetime format with milliseconds and a time zone offset. The returned time zone offset is +00:00. Format: yyyy-MM-ddTHH:mm:ss.SSS+HH:mm.</para>
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
            /// <para>The delivery group status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DEPLOYING: The delivery group is being created or starting resources and is not yet connectable.</description></item>
            /// <item><description>DEPLOYED: The delivery group is deployed. Resources are ready but the delivery group has not been listed for service.</description></item>
            /// <item><description>PUBLISHED: The delivery group is published and listed. Users can connect to and use the delivery group.</description></item>
            /// <item><description>STOPPING: The delivery group is being delisted and is stopping service.</description></item>
            /// <item><description>STOPPED: The delivery group is delisted and has stopped service. Users cannot connect.</description></item>
            /// <item><description>MAINTAINING: The delivery group is being maintained or updated.</description></item>
            /// <item><description>FAILED: The delivery group failed to publish. Resource initialization failed.</description></item>
            /// <item><description>MAINTAIN_FAILED: The update failed. Maintenance or changes were not successful.</description></item>
            /// <item><description>DELETING: The delivery group is being deleted.</description></item>
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

        }

        /// <summary>
        /// <para>The current page number. This value is the same as the PageNumber request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of delivery groups returned per page. This value is the same as the PageSize request parameter.</para>
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
        /// <para>The total number of authorized delivery groups that match the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
