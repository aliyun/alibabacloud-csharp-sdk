// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListCiphersRequest : TeaModel {
        /// <summary>
        /// <para>The name of the cipher suite group, which can be: all, strict, custom.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>strict</para>
        /// </summary>
        [NameInMap("CiphersGroup")]
        [Validation(Required=false)]
        public string CiphersGroup { get; set; }

    }

}
