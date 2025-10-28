// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateAccountInfoRequest : TeaModel {
        /// <summary>
        /// <para>The email address of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1321234****@alibaba-inc.com</para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The name of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edas-test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The contact information of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1321234****</para>
        /// </summary>
        [NameInMap("Telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

    }

}
