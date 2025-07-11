// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ReadFlowVersionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Business tenant code, default is “ALICOM_OPAAS”.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALICOM_OPAAS</para>
        /// </summary>
        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>Business extension information, default is “{}”.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("BizExtend")]
        [Validation(Required=false)]
        public string BizExtendShrink { get; set; }

        /// <summary>
        /// <para>Flow code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f4912c16943b4dfba44bd6fedacf****</para>
        /// </summary>
        [NameInMap("FlowCode")]
        [Validation(Required=false)]
        public string FlowCode { get; set; }

        /// <summary>
        /// <para>Flow version</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FlowVersion")]
        [Validation(Required=false)]
        public string FlowVersion { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Flow version status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DRAFT</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
