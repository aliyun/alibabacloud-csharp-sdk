// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListClientUsersRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10785</para>
        /// </summary>
        [NameInMap("DepartmentId")]
        [Validation(Required=false)]
        public string DepartmentId { get; set; }

        /// <summary>
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
        /// <para>1071</para>
        /// </summary>
        [NameInMap("IdpConfigId")]
        [Validation(Required=false)]
        public string IdpConfigId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18980976559</para>
        /// </summary>
        [NameInMap("MobileNumber")]
        [Validation(Required=false)]
        public string MobileNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
