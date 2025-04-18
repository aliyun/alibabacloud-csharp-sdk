// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class ListNisInspectionResourceTypeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D5E98683-355B-5867-8D3D-A24755F6895B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceTypeList")]
        [Validation(Required=false)]
        public List<ListNisInspectionResourceTypeResponseBodyResourceTypeList> ResourceTypeList { get; set; }
        public class ListNisInspectionResourceTypeResponseBodyResourceTypeList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>EIP</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
