// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class MTRSOCRServiceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ONEX8C7E7FA161089</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xydasf==ac</para>
        /// </summary>
        [NameInMap("ImageRaw")]
        [Validation(Required=false)]
        public string ImageRaw { get; set; }

        [NameInMap("Mask")]
        [Validation(Required=false)]
        public bool? Mask { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tabcaa</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_CARD_OCR</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
