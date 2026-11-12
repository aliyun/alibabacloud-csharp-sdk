// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListCustomImagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The custom images.</para>
        /// </summary>
        [NameInMap("CustomImages")]
        [Validation(Required=false)]
        public List<ListCustomImagesResponseBodyCustomImages> CustomImages { get; set; }
        public class ListCustomImagesResponseBodyCustomImages : TeaModel {
            /// <summary>
            /// <para>The information about instances created from the image.</para>
            /// </summary>
            [NameInMap("CreateInstances")]
            [Validation(Required=false)]
            public List<string> CreateInstances { get; set; }

            /// <summary>
            /// <para>The time when the snapshot was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-09T02:28:06Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The data cloud disk snapshot ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-bp19rn9u8eqzlfb***</para>
            /// </summary>
            [NameInMap("DataSnapshotId")]
            [Validation(Required=false)]
            public string DataSnapshotId { get; set; }

            /// <summary>
            /// <para>The name of the data cloud disk snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataDiskSnapshot</para>
            /// </summary>
            [NameInMap("DataSnapshotName")]
            [Validation(Required=false)]
            public string DataSnapshotName { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CustomImage-1</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The custom image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-bp1e79zktg26n2b***</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>Indicates whether the custom image is shared to ECS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("InShare")]
            [Validation(Required=false)]
            public bool? InShare { get; set; }

            /// <summary>
            /// <para>Indicates whether the custom image is shared across accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("InShareUser")]
            [Validation(Required=false)]
            public bool? InShareUser { get; set; }

            /// <summary>
            /// <para>The instance ID of the simple application server from which the image was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2d06ee0520b44de1ae88d4be****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the simple application server instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>swas-asdf23***</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The name of the custom image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The operating system type of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

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
            /// <para>The data cloud disk size of the image. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("RequiredDataDiskSize")]
            [Validation(Required=false)]
            public int? RequiredDataDiskSize { get; set; }

            /// <summary>
            /// <para>The system cloud disk size of the image. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("RequiredSystemDiskSize")]
            [Validation(Required=false)]
            public int? RequiredSystemDiskSize { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm2h2lvp3ublq</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The name of the source image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CentOS</para>
            /// </summary>
            [NameInMap("SourceImageName")]
            [Validation(Required=false)]
            public string SourceImageName { get; set; }

            /// <summary>
            /// <para>The image version of the source image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.0</para>
            /// </summary>
            [NameInMap("SourceImageVersion")]
            [Validation(Required=false)]
            public string SourceImageVersion { get; set; }

            /// <summary>
            /// <para>The status of the custom image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: copying.</para>
            /// </description></item>
            /// <item><description><para>1: active.</para>
            /// </description></item>
            /// <item><description><para>2: unavailable.</para>
            /// </description></item>
            /// <item><description><para>3: creation failed.</para>
            /// </description></item>
            /// <item><description><para>4: creating.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The system cloud disk snapshot ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-bp1h173hj21puxb***</para>
            /// </summary>
            [NameInMap("SystemSnapshotId")]
            [Validation(Required=false)]
            public string SystemSnapshotId { get; set; }

            /// <summary>
            /// <para>The name of the system cloud disk snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SystemDiskSnapshot</para>
            /// </summary>
            [NameInMap("SystemSnapshotName")]
            [Validation(Required=false)]
            public string SystemSnapshotName { get; set; }

            /// <summary>
            /// <para>The tags of the custom images.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListCustomImagesResponseBodyCustomImagesTags> Tags { get; set; }
            public class ListCustomImagesResponseBodyCustomImagesTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the custom image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the custom image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the image owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180185828710****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in Settings for the paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20758A-585D-4A41-A9B2-28DA8F4F534F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
