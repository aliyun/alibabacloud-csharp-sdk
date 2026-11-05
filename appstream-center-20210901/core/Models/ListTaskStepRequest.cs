// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListTaskStepRequest : TeaModel {
        /// <summary>
        /// <para>The task type to which the step belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ADAPTOR</b>: application adaptation steps</description></item>
        /// <item><description><b>IMAGE</b>: image creation steps</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
