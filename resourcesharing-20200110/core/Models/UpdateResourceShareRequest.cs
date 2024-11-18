// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class UpdateResourceShareRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether resources in the resource share can be shared with accounts outside the resource directory. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: Resources in the resource share can be shared only with accounts in the resource directory.</description></item>
        /// <item><description>true: Resources in the resource share can be shared with both accounts in the resource directory and accounts outside the resource directory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowExternalTargets")]
        [Validation(Required=false)]
        public bool? AllowExternalTargets { get; set; }

        /// <summary>
        /// <para>The ID of the resource share.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rs-qSkW1HBY****</para>
        /// </summary>
        [NameInMap("ResourceShareId")]
        [Validation(Required=false)]
        public string ResourceShareId { get; set; }

        /// <summary>
        /// <para>The new name of the resource share.</para>
        /// <para>The name must be 1 to 50 characters in length.</para>
        /// <para>The name can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new</para>
        /// </summary>
        [NameInMap("ResourceShareName")]
        [Validation(Required=false)]
        public string ResourceShareName { get; set; }

    }

}
