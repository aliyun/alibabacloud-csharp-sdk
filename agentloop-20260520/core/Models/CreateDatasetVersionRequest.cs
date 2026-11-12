// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class CreateDatasetVersionRequest : TeaModel {
        /// <summary>
        /// <para>The description of the version. This parameter is optional. If this parameter is not specified, an empty string is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dataset version used for the first evaluation</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the version to be created, which is used to identify the version within the current dataset. The name cannot be empty after leading and trailing whitespaces are removed. The length of the UTF-8 encoded name cannot exceed 128 bytes, and the name cannot contain forward slashes (/).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The optional client token that is generated and passed by the client. Do not use this token to determine whether the version is created. You can call ListDatasetVersions to query the version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-1234-5678-90ab-cdef12345678</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
