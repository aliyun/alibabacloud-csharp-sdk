// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateClientUserRequest : TeaModel {
        /// <summary>
        /// <para>Department ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10701</para>
        /// </summary>
        [NameInMap("DepartmentId")]
        [Validation(Required=false)]
        public string DepartmentId { get; set; }

        /// <summary>
        /// <para>User description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例用户</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Email address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:johndoe@example.com">johndoe@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>User ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20644</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Mobile phone number without country code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13641966835</para>
        /// </summary>
        [NameInMap("MobileNumber")]
        [Validation(Required=false)]
        public string MobileNumber { get; set; }

    }

}
