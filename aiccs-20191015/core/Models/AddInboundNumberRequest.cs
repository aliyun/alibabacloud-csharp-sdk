// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class AddInboundNumberRequest : TeaModel {
        /// <summary>
        /// <para>The code of the large language model application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DLWERWLD</para>
        /// </summary>
        [NameInMap("ApplicationCode")]
        [Validation(Required=false)]
        public string ApplicationCode { get; set; }

        /// <summary>
        /// <para>The list of inbound numbers.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InboundNumbers")]
        [Validation(Required=false)]
        public List<string> InboundNumbers { get; set; }

        /// <summary>
        /// <para>The line type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Cloud communication resource.</description></item>
        /// <item><description>2: Customer-provided line.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("InboundType")]
        [Validation(Required=false)]
        public long? InboundType { get; set; }

        /// <summary>
        /// <para>The custom line code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JILIANG_*****_TEST_NET</para>
        /// </summary>
        [NameInMap("LineCode")]
        [Validation(Required=false)]
        public string LineCode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
