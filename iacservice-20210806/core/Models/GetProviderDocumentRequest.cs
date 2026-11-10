// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetProviderDocumentRequest : TeaModel {
        /// <summary>
        /// <para>The Terraform provider version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.248.0</para>
        /// </summary>
        [NameInMap("providerVersion")]
        [Validation(Required=false)]
        public string ProviderVersion { get; set; }

        /// <summary>
        /// <para>The Terraform resource type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alicloud_route_table</para>
        /// </summary>
        [NameInMap("terraformResourceType")]
        [Validation(Required=false)]
        public string TerraformResourceType { get; set; }

    }

}
