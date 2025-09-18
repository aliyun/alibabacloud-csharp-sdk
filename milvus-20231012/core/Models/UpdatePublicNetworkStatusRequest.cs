// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class UpdatePublicNetworkStatusRequest : TeaModel {
        /// <summary>
        /// <para>The CIDR blocks.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>192.168.**.**</c>/24,<c>172.1.**.**</c>/16</para>
        /// </summary>
        [NameInMap("Cidr")]
        [Validation(Required=false)]
        public string Cidr { get; set; }

        /// <summary>
        /// <para>The component type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Proxy</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Proxy</para>
        /// </summary>
        [NameInMap("ComponentType")]
        [Validation(Required=false)]
        public string ComponentType { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-123xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Enable /disable the Internet.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PublicNetworkEnabled")]
        [Validation(Required=false)]
        public bool? PublicNetworkEnabled { get; set; }

    }

}
