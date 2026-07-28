// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class CheckServiceLinkedRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the service-linked role has been created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("HasServiceLinkedRole")]
        [Validation(Required=false)]
        public bool? HasServiceLinkedRole { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1F455133-981E-5AD0-80EB-26EA1EF3C65F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
