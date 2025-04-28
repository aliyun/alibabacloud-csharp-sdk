// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class CheckServiceLinkedRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether an SLR is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasServiceLinkedRole")]
        [Validation(Required=false)]
        public bool? HasServiceLinkedRole { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BA0F6761-7A8C-59F8-9624-FB56788C0EDF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
