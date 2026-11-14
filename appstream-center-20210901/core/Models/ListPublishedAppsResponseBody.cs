// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListPublishedAppsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of application records on the current page. Each record corresponds to a deployed application in a published delivery group, sorted in descending order of the creation time of the associated delivery group. If no matching results are found or the requested page exceeds the result range, an empty list is returned.</para>
        /// </summary>
        [NameInMap("Apps")]
        [Validation(Required=false)]
        public List<ListPublishedAppsResponseBodyApps> Apps { get; set; }
        public class ListPublishedAppsResponseBodyApps : TeaModel {
            /// <summary>
            /// <para>The access URL of the application icon.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://app-center-icon-****.png">https://app-center-icon-****.png</a></para>
            /// </summary>
            [NameInMap("AppIcon")]
            [Validation(Required=false)]
            public string AppIcon { get; set; }

            /// <summary>
            /// <para>The application ID. When you invoke the <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> operation to grant authorization to a user for this application, pass this value together with <c>AppInstanceGroupId</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca-i87mycyn419nu****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The ID of the published delivery group to which the application belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The name of the published delivery group to which the application belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Office applications</para>
            /// </summary>
            [NameInMap("AppInstanceGroupName")]
            [Validation(Required=false)]
            public string AppInstanceGroupName { get; set; }

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
            /// <para>The application version name, which is the name set for this version when the application is published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Initial version</para>
            /// </summary>
            [NameInMap("AppVersionName")]
            [Validation(Required=false)]
            public string AppVersionName { get; set; }

            /// <summary>
            /// <para>The number of users currently authorized for this application on a per-application basis within the associated delivery group. Only users authorized on a per-application basis through <a href="~~AuthorizeUsersForApp~~">AuthorizeUsersForApp</a> are counted. If no users are authorized on a per-application basis, <c>0</c> is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("AuthorizedUserCount")]
            [Validation(Required=false)]
            public int? AuthorizedUserCount { get; set; }

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
        /// <para>The number of records per page specified in the current request. This value does not represent the actual number of records returned on the current page. The actual number on the current page may be less than this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier of the current request, which can be used to troubleshoot request issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records that meet all filter conditions. The count is based on the &quot;delivery group + application&quot; combination. If the same application appears in multiple published delivery groups, it is counted separately. This value is not the number of records returned on the current page. If no matching results are found, the value is <c>0</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
