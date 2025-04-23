// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class CreateServiceIdentityRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidInputParams</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User don\&quot;t have permission to create SLR.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A87228C-969A-1381-98CF-AE07AE630FA5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The role details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunServiceRoleForPaiLLMTrace</para>
        /// </summary>
        [NameInMap("RoleDetails")]
        [Validation(Required=false)]
        public string RoleDetails { get; set; }

        /// <summary>
        /// <para>The name of the service-linked role. Default value: AliyunServiceRoleForPaiLLMTrace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunServiceRoleForPaiLLMTrace</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}
