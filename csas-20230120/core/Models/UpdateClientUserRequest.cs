// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateClientUserRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10701</para>
        /// </summary>
        [NameInMap("DepartmentId")]
        [Validation(Required=false)]
        public string DepartmentId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        /// <para>20644</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13641966835</para>
        /// </summary>
        [NameInMap("MobileNumber")]
        [Validation(Required=false)]
        public string MobileNumber { get; set; }

    }

}
