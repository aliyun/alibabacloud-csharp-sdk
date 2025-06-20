// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListMachineTypesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>efg1.nvga1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
