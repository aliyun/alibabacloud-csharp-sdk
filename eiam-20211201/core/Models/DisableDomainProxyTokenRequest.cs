// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class DisableDomainProxyTokenRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dm_examplexxxxx</para>
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <para>The ID of the proxy token of the domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pt_examplexxxx</para>
        /// </summary>
        [NameInMap("DomainProxyTokenId")]
        [Validation(Required=false)]
        public string DomainProxyTokenId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
