// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeCpfsAccessPointsResponseBody : TeaModel {
        [NameInMap("AccessPoints")]
        [Validation(Required=false)]
        public List<DescribeCpfsAccessPointsResponseBodyAccessPoints> AccessPoints { get; set; }
        public class DescribeCpfsAccessPointsResponseBodyAccessPoints : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:nas:cn-hangzhou:178321033379****:accesspoint/ap-ie15yd****</para>
            /// </summary>
            [NameInMap("ARN")]
            [Validation(Required=false)]
            public string ARN { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ap-ie15y*****</para>
            /// </summary>
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-03-28T06:32:14Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bmcpfs-290r9c75fnb0il8d8v1</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-03-28T06:32:14Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RootDirectory")]
            [Validation(Required=false)]
            public DescribeCpfsAccessPointsResponseBodyAccessPointsRootDirectory RootDirectory { get; set; }
            public class DescribeCpfsAccessPointsResponseBodyAccessPointsRootDirectory : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>/path</para>
                /// </summary>
                [NameInMap("RootPath")]
                [Validation(Required=false)]
                public string RootPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Ready</para>
                /// </summary>
                [NameInMap("RootPathStatus")]
                [Validation(Required=false)]
                public string RootPathStatus { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A323836B-5BC6-45A6-8048-60675C23****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
