// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListSyncMCPServerRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AI gateway. Note: This parameter is required. If it is not provided, the API returns InvalidParameter.IsEmpty(400).</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-xxxx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The Nacos namespace ID. Note: This parameter is required. If it is not provided, the API returns InvalidParameter.IsEmpty(400).</para>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The Nacos service source ID. This parameter can be omitted in single Nacos source scenarios because the server automatically populates the unique source. It is required in multiple Nacos source scenarios. Otherwise, a parameter error indicating that sourceId is empty is returned. If the gateway has no Nacos source, ErrServiceSourceNotFound is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>src-xxxx</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

    }

}
