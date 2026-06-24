// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateImageByInstanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is applicable only when the instance type is cloud desktop. Specifies whether to clear user personal data. If you set this parameter to true, the created image clears data in all directories under C:\Users except the Administrator and Public directories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoCleanUserdata")]
        [Validation(Required=false)]
        public bool? AutoCleanUserdata { get; set; }

        /// <summary>
        /// <para>This parameter is not publicly available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The image description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my test image v1.0</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The type of disk data included in the image. By default, the image includes both the system cloud disk and data cloud disk of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The image name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The WUYING instance ID. The instance can be a cloud desktop instance or a workstation instance. To ensure data consistency in the image, stop the instance before creating the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-0buj1s9gm******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WuyingServer</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>This parameter is not publicly available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WuyingServer</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The sub-instance ID. This parameter is not applicable to cloud desktop scenarios. In workstation scenarios, specify the persistent session ID to identify a specific instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-0cc7s3n1l*****</para>
        /// </summary>
        [NameInMap("SubInstanceId")]
        [Validation(Required=false)]
        public string SubInstanceId { get; set; }

        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<CreateImageByInstanceRequestTagList> TagList { get; set; }
        public class CreateImageByInstanceRequestTagList : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
