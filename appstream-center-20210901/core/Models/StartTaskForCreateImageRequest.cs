// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class StartTaskForCreateImageRequest : TeaModel {
        /// <summary>
        /// <para>The image creation mode. Use the following mode:</para>
        /// <list type="bullet">
        /// <item><description><b>BUILDER_MANUAL</b>: Manually enter the creation environment to install applications and configure the image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BUILDER_MANUAL</para>
        /// </summary>
        [NameInMap("ImageCreateMode")]
        [Validation(Required=false)]
        public string ImageCreateMode { get; set; }

        /// <summary>
        /// <para>The ID of the image. This parameter is not exposed by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>img-bp13mu****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The WUYING instance ID. The instance can be a cloud desktop instance or a workstation instance. To ensure data consistency in the image, stop the instance before starting the image creation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-5u87dainamz54yk10</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The step to jump to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE_VALIDATE_ENV</para>
        /// </summary>
        [NameInMap("JumpStep")]
        [Validation(Required=false)]
        public string JumpStep { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CPU</para>
        /// </summary>
        [NameInMap("PerformanceType")]
        [Validation(Required=false)]
        public string PerformanceType { get; set; }

        /// <summary>
        /// <para>The product type. Set this parameter to the following value when you call this operation:</para>
        /// <list type="bullet">
        /// <item><description><c>CloudApp</c>: WUYING Cloud App.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The list of resources required for image creation, such as the download URLs of applications to be installed. You can specify up to 100 items. The ResourceType and Resource of each item must correspond to each other.</para>
        /// 
        /// <b>Example:</b>
        /// <para>List of Object</para>
        /// </summary>
        [NameInMap("ResourceList")]
        [Validation(Required=false)]
        public List<StartTaskForCreateImageRequestResourceList> ResourceList { get; set; }
        public class StartTaskForCreateImageRequestResourceList : TeaModel {
            /// <summary>
            /// <para>The resource information.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/apps/business/setup.exe">https://example.com/apps/business/setup.exe</a></para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>URL</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The retry type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RETRY</para>
        /// </summary>
        [NameInMap("RetryType")]
        [Validation(Required=false)]
        public string RetryType { get; set; }

        /// <summary>
        /// <para>The running mode of the image creation environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL</b>: Normal running mode.</description></item>
        /// <item><description><b>COMPATIBLE</b>: Compatible running mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

        /// <summary>
        /// <para>The source region where the image is created. If you do not specify this parameter, a region is randomly selected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("SourceRegion")]
        [Validation(Required=false)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// <para>The sub-instance ID. This parameter is not applicable to cloud desktop scenarios. In workstation scenarios, you must specify the persistent session ID to locate a specific instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-0cc7s3n1l*****</para>
        /// </summary>
        [NameInMap("SubInstanceId")]
        [Validation(Required=false)]
        public string SubInstanceId { get; set; }

        /// <summary>
        /// <para>The size of the system cloud disk. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>The ID of the image version. This parameter is not exposed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iv-bp1example****</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
