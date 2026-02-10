// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ForeignInstanceCredInfo : TeaModel {
        /// <summary>
        /// <para>The information about the credential.</para>
        /// </summary>
        [NameInMap("CredInfo")]
        [Validation(Required=false)]
        public Dictionary<string, string> CredInfo { get; set; }

        /// <summary>
        /// <para>The type of the credential. Set the value to DEFAULT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("CredType")]
        [Validation(Required=false)]
        public string CredType { get; set; }

    }

}
