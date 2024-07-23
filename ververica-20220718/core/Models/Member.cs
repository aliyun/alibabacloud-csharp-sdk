// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Member : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user: 181319557522****</para>
        /// </summary>
        [NameInMap("member")]
        [Validation(Required=false)]
        public string Member_ { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>VIEWER</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

    }

}
