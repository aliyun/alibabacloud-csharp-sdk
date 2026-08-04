// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class AddressGroup : TeaModel {
        /// <summary>
        /// <para>Address list.</para>
        /// </summary>
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<string> Addresses { get; set; }

        /// <summary>
        /// <para>Port list.</para>
        /// </summary>
        [NameInMap("Ports")]
        [Validation(Required=false)]
        public List<AddressGroupPorts> Ports { get; set; }
        public class AddressGroupPorts : TeaModel {
            /// <summary>
            /// <para>Start port. Must be less than or equal to the end port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Begin")]
            [Validation(Required=false)]
            public int? Begin { get; set; }

            /// <summary>
            /// <para>End port. Must be greater than or equal to the start port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public int? End { get; set; }

        }

    }

}
