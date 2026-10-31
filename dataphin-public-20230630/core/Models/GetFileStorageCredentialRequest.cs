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
        /// <para>The ID of the user who performs the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

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
        /// <para>The purpose of the authorization. Valid values: RESOURCE (creating resource files), COMPUTE_SOURCE_SETTING (configuring storage and compute sources), and NONE (no specific purpose). Default value: NONE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RESOURCE</para>
        /// </summary>
        [NameInMap("Purpose")]
        [Validation(Required=false)]
        public string Purpose { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the internal endpoint. Default value: false.</para>
        /// </summary>
        [NameInMap("UseVpcEndpoint")]
        [Validation(Required=false)]
        public bool? UseVpcEndpoint { get; set; }

    }

}
