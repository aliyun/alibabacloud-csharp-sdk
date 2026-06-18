// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class AddInboundNumberShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The code of the large model application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DLWERWLD</para>
        /// </summary>
        [NameInMap("ApplicationCode")]
        [Validation(Required=false)]
        public string ApplicationCode { get; set; }

        /// <summary>
        /// <para>A list of inbound numbers.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InboundNumbers")]
        [Validation(Required=false)]
        public string InboundNumbersShrink { get; set; }

        /// <summary>
        /// <para>The line type. Valid values: <c>1</c> (cloud communication resource) and <c>2</c> (customer-owned line).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("InboundType")]
        [Validation(Required=false)]
        public long? InboundType { get; set; }

        /// <summary>
        /// <para>The code for the custom line.</para>
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
