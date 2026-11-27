// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DeleteRumSymbolFilesRequest : TeaModel {
        /// <summary>
        /// <para>The list of object paths of the symbol files to delete. This parameter is required and cannot be an empty array. Set the value to the artifactPath returned by GetRumSymbolFiles. Up to 1,000 paths are supported per call. Only user-uploaded symbol files under the current application can be deleted. System symbol files cannot be deleted.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;user/workspace/service-id/3.0.0/build-1/new-app.map&quot;]</para>
        /// </summary>
        [NameInMap("filePaths")]
        [Validation(Required=false)]
        public List<string> FilePaths { get; set; }

        /// <summary>
        /// <para>The ID of the RUM application service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4e5@f67890</para>
        /// </summary>
        [NameInMap("serviceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The name of the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-cms-1234567890-cn-hangzhou</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
