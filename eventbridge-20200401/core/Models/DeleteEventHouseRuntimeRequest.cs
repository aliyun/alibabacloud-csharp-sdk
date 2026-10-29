// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class DeleteEventHouseRuntimeRequest : TeaModel {
        /// <summary>
        /// <para>The name of the EventHouse runtime. If you do not specify this parameter, the default runtime is used. Typically, you do not need to specify this parameter in the initial phase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
