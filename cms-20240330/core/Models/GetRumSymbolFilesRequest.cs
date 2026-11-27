// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetRumSymbolFilesRequest : TeaModel {
        /// <summary>
        /// <para>The filter for the symbol file type. Valid values: map, dsym, txt, so, sym, pdb, and json. This parameter is used for query filtering and differs from the fileKind dimension in the upload API GetRumSymbolFileParams: uploading dsym (.dSYM.zip) corresponds to artifactType=dsym; standard symbol-zip (.zip) is not currently supported for filtering by artifactType.</para>
        /// 
        /// <b>Example:</b>
        /// <para>txt</para>
        /// </summary>
        [NameInMap("artifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// <para>The list of search keywords. You can specify up to 50 keywords to match file names, UUIDs, version numbers, and more.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;new-app&quot;]</para>
        /// </summary>
        [NameInMap("keywords")]
        [Validation(Required=false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// <para>The paging token. To query the next page, specify the nextToken value returned in the previous response. The example is for illustration purposes only and cannot be used for actual queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The filter for the platform type. Valid values: web, miniapp, minigame, uniapp, android, ios, harmonyos, windows, macos, and linux.</para>
        /// 
        /// <b>Example:</b>
        /// <para>android</para>
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The service ID of the RUM application. This parameter is required, cannot be an empty string, and must be used together with workspace to locate the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4e5@f67890</para>
        /// </summary>
        [NameInMap("serviceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The filter for the application version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The name of the workspace to which the RUM application belongs. This parameter is required, cannot be an empty string, and must be used together with serviceId to locate the application.</para>
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
