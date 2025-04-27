// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateAdminPasswordRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>es_password</para>
        /// </summary>
        [NameInMap("esAdminPassword")]
        [Validation(Required=false)]
        public string EsAdminPassword { get; set; }

        /// <summary>
        /// <para>Indicates whether the password was updated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
