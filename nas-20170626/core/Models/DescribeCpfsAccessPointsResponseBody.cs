// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeCpfsAccessPointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The access point information.</para>
        /// </summary>
        [NameInMap("AccessPoints")]
        [Validation(Required=false)]
        public List<DescribeCpfsAccessPointsResponseBodyAccessPoints> AccessPoints { get; set; }
        public class DescribeCpfsAccessPointsResponseBodyAccessPoints : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:nas:cn-hangzhou:178321033379****:accesspoint/ap-ie15yd****</para>
            /// </summary>
            [NameInMap("ARN")]
            [Validation(Required=false)]
            public string ARN { get; set; }

            /// <summary>
            /// <para>The access point ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-ie15y*****</para>
            /// </summary>
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            /// <summary>
            /// <para>The time when the access point was created. The time follows the ISO 8601 standard in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-28T06:32:14Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The file system ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bmcpfs-290r9c75fnb0il8d8v1</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The time when the access point was last modified. The time follows the ISO 8601 standard in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-28T06:32:14Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

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
            /// <para>The root directory information.</para>
            /// </summary>
            [NameInMap("RootDirectory")]
            [Validation(Required=false)]
            public DescribeCpfsAccessPointsResponseBodyAccessPointsRootDirectory RootDirectory { get; set; }
            public class DescribeCpfsAccessPointsResponseBodyAccessPointsRootDirectory : TeaModel {
                /// <summary>
                /// <para>The root directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/path</para>
                /// </summary>
                [NameInMap("RootPath")]
                [Validation(Required=false)]
                public string RootPath { get; set; }

                /// <summary>
                /// <para>The current status of the root directory.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Unknown: The root path status is unknown.</description></item>
                /// <item><description>NotExist: The root path does not exist. It may have been deleted by the user.</description></item>
                /// <item><description>Ready: The root path status is normal.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Ready</para>
                /// </summary>
                [NameInMap("RootPathStatus")]
                [Validation(Required=false)]
                public string RootPathStatus { get; set; }

            }

            /// <summary>
            /// <para>The current status of the access point.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Active: available</description></item>
            /// <item><description>Inactive: unavailable</description></item>
            /// <item><description>Pending: being created</description></item>
            /// <item><description>Deleting: being deleted</description></item>
            /// </list>
            /// <remarks>
            /// <para>The file system can be mounted only when the status is Active.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The page number of the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of results per page.
        /// Valid values: 1 to 100.<br>Default value: 10.</para>
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
        /// <para>A323836B-5BC6-45A6-8048-60675C23****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of access points.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
