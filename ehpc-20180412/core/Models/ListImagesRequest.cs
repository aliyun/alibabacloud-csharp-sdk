// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListImagesRequest : TeaModel {
        /// <summary>
        /// <para>The image tag of the operating system. The tag is used only for management nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CentOS_7.2_64</para>
        /// </summary>
        [NameInMap("BaseOsTag")]
        [Validation(Required=false)]
        public string BaseOsTag { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// <list type="bullet">
        /// <item><description>If a value is passed to the parameter, the list of images that are supported by the specified instance type is queried.</description></item>
        /// <item><description>If no value is passed to the parameter, the list of images that are supported by all instance types is queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.n1.medium</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

    }

}
