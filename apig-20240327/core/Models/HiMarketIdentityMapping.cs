// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketIdentityMapping : TeaModel {
        /// <summary>
        /// <para>The identity field name that corresponds to the mailbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>email</para>
        /// </summary>
        [NameInMap("emailField")]
        [Validation(Required=false)]
        public string EmailField { get; set; }

        /// <summary>
        /// <para>The identity field name that corresponds to the user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sub</para>
        /// </summary>
        [NameInMap("userIdField")]
        [Validation(Required=false)]
        public string UserIdField { get; set; }

        /// <summary>
        /// <para>The identity field name that corresponds to the username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("userNameField")]
        [Validation(Required=false)]
        public string UserNameField { get; set; }

    }

}
