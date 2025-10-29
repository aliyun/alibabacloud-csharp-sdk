// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GrantSwitchAgreementRequest : TeaModel {
        /// <summary>
        /// <para>Indicates whether to agree to migrate the client connections from overseas servers to the Singapore center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAgree")]
        [Validation(Required=false)]
        public bool? IsAgree { get; set; }

        [NameInMap("IsConfirmed")]
        [Validation(Required=false)]
        public bool? IsConfirmed { get; set; }

        [NameInMap("IsImmediate")]
        [Validation(Required=false)]
        public bool? IsImmediate { get; set; }

        /// <summary>
        /// <para>The language type for requests and responses. The default value is <b>zh</b>. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Switching type. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><b>sg_switch</b>: Migrate client connections from overseas servers to Singapore</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sg_switch</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
