// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateIdentityToBenefitPkgMappingRequest : TeaModel {
        /// <summary>
        /// <para>The number of benefit packages.</para>
        /// <para>This parameter specifies the number of benefit packages of the resource type. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        /// <summary>
        /// <para>The unique identifier of the benefit package.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40cb7794c9294</para>
        /// </summary>
        [NameInMap("benefit_pkg_id")]
        [Validation(Required=false)]
        public string BenefitPkgId { get; set; }

        /// <summary>
        /// <para>The expiration time of the benefit package. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <para>By default, the benefit package never expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1633167071000</para>
        /// </summary>
        [NameInMap("expire_time")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>The unique identifier of the entity.</para>
        /// <para>If you call this operation to manage the benefits of a user, set this parameter to the ID of the user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user123</para>
        /// </summary>
        [NameInMap("identity_id")]
        [Validation(Required=false)]
        public string IdentityId { get; set; }

        /// <summary>
        /// <para>The type of the entity. If you call this operation to manage the benefits of a user, set this parameter to user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("identity_type")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

    }

}
