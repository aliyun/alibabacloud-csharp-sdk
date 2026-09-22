// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListPublishedAppsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of application records on the current page. Each record corresponds to a deployed application in a published delivery group. The list is sorted by the creation time of the delivery group in descending order. An empty list is returned if no results match or the requested page exceeds the result range.</para>
        /// </summary>
        [NameInMap("Apps")]
        [Validation(Required=false)]
        public List<ListPublishedAppsResponseBodyApps> Apps { get; set; }
        public class ListPublishedAppsResponseBodyApps : TeaModel {
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
            /// <para>The application ID. Pass this value together with <c>AppInstanceGroupId</c> when you invoke the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation to authorize users for this application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca-i87mycyn419nu****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The ID of the published delivery group to which this application belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The name of the published delivery group to which this application belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OfficeApps</para>
            /// </summary>
            [NameInMap("AppInstanceGroupName")]
            [Validation(Required=false)]
            public string AppInstanceGroupName { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OfficeApps</para>
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
            /// <para>The application version name, which is the name assigned to this version when the application was published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Initial version</para>
            /// </summary>
            [NameInMap("AppVersionName")]
            [Validation(Required=false)]
            public string AppVersionName { get; set; }

            /// <summary>
            /// <para>The number of users authorized by application for this application within its delivery group. Only users authorized through <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> by application are counted. The value is <c>0</c> if no users have been authorized by application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("AuthorizedUserCount")]
            [Validation(Required=false)]
            public int? AuthorizedUserCount { get; set; }

        }

        /// <summary>
        /// <para>The page number specified in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page specified in this request. This value does not represent the actual number of records returned on the current page. The actual number may be less than this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID. You can use this ID to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records that match all filter conditions. Records are counted on a per-delivery-group-plus-application basis. If the same application appears in multiple published delivery groups, each combination is counted separately. This value does not represent the number of records returned on the current page. The value is <c>0</c> if no results match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
