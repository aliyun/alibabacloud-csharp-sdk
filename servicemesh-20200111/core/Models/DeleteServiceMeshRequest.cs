// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DeleteServiceMeshRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to forcibly delete the ASM instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: forcibly deletes the ASM instance.</description></item>
        /// <item><description><c>false</c>: does not forcibly delete the ASM instance.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>A JSON string that can be parsed into a string array. You can use this JSON string to specify the IDs of the resource instances that need to be retained when the ASM instance is deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot; lb-bp1fxvl3q8akbj6m*****&quot;, &quot;lb-bp1hoxkolggdw0y3*****&quot;]</para>
        /// </summary>
        [NameInMap("RetainResources")]
        [Validation(Required=false)]
        public string RetainResources { get; set; }

        /// <summary>
        /// <para>The ASM instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c08ba3fd1e6484b0f8cc1ad8fe10d****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
