// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListSyncMCPServerRequest : TeaModel {
        /// <summary>
        /// <para>The AI gateway ID. This parameter is required. If this parameter is not specified, the API returns InvalidParameter.IsEmpty(400).</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-xxxx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The Nacos namespace ID. This parameter is required. If this parameter is not specified, the API returns InvalidParameter.IsEmpty(400).</para>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The Nacos service source ID. In a single Nacos source scenario, this parameter can be omitted because the server automatically populates the unique source. In a multi-Nacos source scenario, this parameter is required. Otherwise, a parameter error indicating that sourceId is empty is returned. If the gateway has no Nacos source, the error ErrServiceSourceNotFound is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>src-xxxx</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

    }

}
