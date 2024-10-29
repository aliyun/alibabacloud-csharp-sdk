// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateClientUserRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10797</para>
        /// </summary>
        [NameInMap("DepartmentId")]
        [Validation(Required=false)]
        public string DepartmentId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:johndoe@example.com">johndoe@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>727</para>
        /// </summary>
        [NameInMap("IdpConfigId")]
        [Validation(Required=false)]
        public string IdpConfigId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13641966835</para>
        /// </summary>
        [NameInMap("MobileNumber")]
        [Validation(Required=false)]
        public string MobileNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>kehudiyi</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
