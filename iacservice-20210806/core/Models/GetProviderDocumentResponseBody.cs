// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetProviderDocumentResponseBody : TeaModel {
        /// <summary>
        /// <para>The Terraform provider resource document.</para>
        /// </summary>
        [NameInMap("document")]
        [Validation(Required=false)]
        public string Document { get; set; }

        /// <summary>
        /// <para>The Terraform provider version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.206.0</para>
        /// </summary>
        [NameInMap("providerVersion")]
        [Validation(Required=false)]
        public string ProviderVersion { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD478792-6952-5A1C-9F57-78932BF0FAC6</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Terraform resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alicloud_route_table</para>
        /// </summary>
        [NameInMap("terraformResourceType")]
        [Validation(Required=false)]
        public string TerraformResourceType { get; set; }

    }

}
