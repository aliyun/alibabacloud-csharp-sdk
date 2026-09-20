// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DeleteInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the instance to be released.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hb-bp16o0pd52e3y****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately release the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instance is immediately released.</description></item>
        /// <item><description><b>false</b>: The instance is not immediately released and is stored in the recycle bin. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ImmediateDeleteFlag")]
        [Validation(Required=false)]
        public bool? ImmediateDeleteFlag { get; set; }

    }

}
