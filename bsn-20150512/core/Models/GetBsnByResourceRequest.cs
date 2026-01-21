// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bsn20150512.Models
{
    public class GetBsnByResourceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("aliuid")]
        [Validation(Required=false)]
        public long? Aliuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3097938</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alicloud_edas_application_scale</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

    }

}
