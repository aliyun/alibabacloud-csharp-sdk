// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class GetServiceIdentityRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>The internal error code. This parameter is returned only when an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EntityNotExist</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is returned only when an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Serivce role does not exit.</para>
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
        [NameInMap("RoleDetail")]
        [Validation(Required=false)]
        public string RoleDetail { get; set; }

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
