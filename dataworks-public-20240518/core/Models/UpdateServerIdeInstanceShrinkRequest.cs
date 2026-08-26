// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateServerIdeInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The credential injection configuration for the instance. After this feature is enabled, you can use the default RAM role chain or specify a custom RAM role.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public string CredentialConfigShrink { get; set; }

        /// <summary>
        /// <para>The number of CUs used by the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Cu")]
        [Validation(Required=false)]
        public int? Cu { get; set; }

        /// <summary>
        /// <para>The list of datasets mounted to the instance.</para>
        /// </summary>
        [NameInMap("Datasets")]
        [Validation(Required=false)]
        public string DatasetsShrink { get; set; }

        /// <summary>
        /// <para>The image ID. You can call ListServerIdeImages to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>System_serveride_notebook_20240822</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The image URL. This parameter is required when you use a non-DataWorks official image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/example/serveride:latest</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The personal development environment instance ID. You can call ListServerIdeInstances to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>699573</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the personal development environment instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>notebook_dev</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The VPC configuration used by the instance.</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public string UserVpcShrink { get; set; }

    }

}
