// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class InitializeServiceLinkRoleRequest : TeaModel {
        /// <summary>
        /// <para>The language in which the returned results are displayed. Valid values: zh (default): Chinese. en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The name of the server-linked role. Set this parameter to AliyunServiceRoleForMSE</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunServiceRoleForMSE</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// <para>This parameter is reserved and not in use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
