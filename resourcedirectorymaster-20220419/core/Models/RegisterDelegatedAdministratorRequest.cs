// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class RegisterDelegatedAdministratorRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member in the resource directory.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>181761095690****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The identifier of the trusted service.</para>
        /// <para>For more information, see the <c>Trusted service identifier</c> column in <a href="https://help.aliyun.com/document_detail/208133.html">Supported trusted services</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudfw.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ServicePrincipal")]
        [Validation(Required=false)]
        public string ServicePrincipal { get; set; }

    }

}
