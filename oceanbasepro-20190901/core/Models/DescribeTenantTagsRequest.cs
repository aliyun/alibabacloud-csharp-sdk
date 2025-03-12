// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantTagsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the OceanBase cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob317v4uif****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Key&quot;: &quot;xxx&quot;, &quot;Value&quot;, &quot;xxx&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The JSON string of the tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;t5r0x2f6q****&quot;, &quot;t33h8y08k****&quot;, &quot;t5r41rtl7****&quot;]</para>
        /// </summary>
        [NameInMap("TenantIds")]
        [Validation(Required=false)]
        public string TenantIds { get; set; }

    }

}
