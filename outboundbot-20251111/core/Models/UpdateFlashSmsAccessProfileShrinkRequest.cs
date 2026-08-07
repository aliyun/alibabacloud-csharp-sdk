// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class UpdateFlashSmsAccessProfileShrinkRequest : TeaModel {
        /// <summary>
        /// <para>接入配置</para>
        /// </summary>
        [NameInMap("AccessProfile")]
        [Validation(Required=false)]
        public string AccessProfileShrink { get; set; }

        /// <summary>
        /// <para>接入配置ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("AccessProfileId")]
        [Validation(Required=false)]
        public string AccessProfileId { get; set; }

        /// <summary>
        /// <para>实例ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>供应商ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>Uincall</para>
        /// </summary>
        [NameInMap("ProviderId")]
        [Validation(Required=false)]
        public string ProviderId { get; set; }

    }

}
