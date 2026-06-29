// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetFileStorageCredentialRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The project ID. This parameter is required when the temporary authorization is used to create resource files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1030131021</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The purpose of the authorization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RESOURCE: creates resource files.</description></item>
        /// <item><description>COMPUTE_SOURCE_SETTING: stores compute source configurations.</description></item>
        /// <item><description>NONE: no specific purpose.</description></item>
        /// </list>
        /// <para>Default value: NONE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RESOURCE</para>
        /// </summary>
        [NameInMap("Purpose")]
        [Validation(Required=false)]
        public string Purpose { get; set; }

        /// <summary>
        /// <para>Specifies whether to use an internal endpoint. Default value: false.</para>
        /// </summary>
        [NameInMap("UseVpcEndpoint")]
        [Validation(Required=false)]
        public bool? UseVpcEndpoint { get; set; }

    }

}
