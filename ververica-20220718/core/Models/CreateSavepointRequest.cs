// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class CreateSavepointRequest : TeaModel {
        /// <summary>
        /// <para>The deployment ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58718c99-3b29-4c5e-93bb-c9fc4ec6****</para>
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// <para>The description of the savepoint.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the native format mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The native format mode is used.</description></item>
        /// <item><description>false: The native format mode is not used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("nativeFormat")]
        [Validation(Required=false)]
        public bool? NativeFormat { get; set; }

    }

}
