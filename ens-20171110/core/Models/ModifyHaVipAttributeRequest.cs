// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyHaVipAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the HAVIP that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>havip-52y28****</para>
        /// </summary>
        [NameInMap("HaVipId")]
        [Validation(Required=false)]
        public string HaVipId { get; set; }

        /// <summary>
        /// <para>The name of the HAVIP. The name must be 1 to 128 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
