// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateHybridProxyRequest : TeaModel {
        /// <summary>
        /// <para>The UUID of the Security Center agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inet-proxy-14bbbb37-c4b9-4e86-83bd-137a940a6ec4</para>
        /// </summary>
        [NameInMap("ProxyUuid")]
        [Validation(Required=false)]
        public string ProxyUuid { get; set; }

    }

}
