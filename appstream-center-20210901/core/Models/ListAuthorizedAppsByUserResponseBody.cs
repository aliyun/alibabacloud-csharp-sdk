// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAuthorizedAppsByUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of applications authorized to the user. Each record corresponds to one application within one delivery group.</para>
        /// </summary>
        [NameInMap("Apps")]
        [Validation(Required=false)]
        public List<ListAuthorizedAppsByUserResponseBodyApps> Apps { get; set; }
        public class ListAuthorizedAppsByUserResponseBodyApps : TeaModel {
            /// <summary>
            /// <para>The URL of the application icon. This value is empty if the deployment details of the application cannot be obtained.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://app-center-icon-****.png">https://app-center-icon-****.png</a></para>
            /// </summary>
            [NameInMap("AppIcon")]
            [Validation(Required=false)]
            public string AppIcon { get; set; }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca-i87mycyn419nu****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The ID of the delivery group to which the application belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-9ciijz60n4xsv****</para>
            /// </summary>
            [NameInMap("AppInstanceGroupId")]
            [Validation(Required=false)]
            public string AppInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The name of the delivery group to which the application belongs. If the delivery group information cannot be obtained, the value is the same as AppInstanceGroupId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OfficeApp</para>
            /// </summary>
            [NameInMap("AppInstanceGroupName")]
            [Validation(Required=false)]
            public string AppInstanceGroupName { get; set; }

            /// <summary>
            /// <para>The application name. If the deployment details of the application cannot be obtained, the value is the same as AppId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OfficeApp</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The application version. This value is empty if the deployment details of the application cannot be obtained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <para>The application version name. This value is empty if the deployment details of the application cannot be obtained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InitialVersion</para>
            /// </summary>
            [NameInMap("AppVersionName")]
            [Validation(Required=false)]
            public string AppVersionName { get; set; }

            /// <summary>
            /// <para>The number of authorized users for the application within its delivery group. This value is empty if the deployment details of the application cannot be obtained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AuthorizedUserCount")]
            [Validation(Required=false)]
            public int? AuthorizedUserCount { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
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
        /// <para>The total number of authorization records that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
