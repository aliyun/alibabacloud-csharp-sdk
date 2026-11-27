// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetRumSymbolFileParamsRequest : TeaModel {
        /// <summary>
        /// <para>The debug identifier of the symbol file, such as a UUID or Debug ID. This parameter is required for all file types except dsym.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426614174000</para>
        /// </summary>
        [NameInMap("debugId")]
        [Validation(Required=false)]
        public string DebugId { get; set; }

        /// <summary>
        /// <para>The type of the file to upload. Valid values: sourcemap (.map), dsym (.dSYM.zip), proguard (.txt), native-symbol (.so), name-cache (.json/.txt), pdb (.pdb), sym (.sym), and symbol-zip (.zip). This parameter is used to apply for upload signature parameters. The value dimension differs from the artifactType filter parameter in the GetRumSymbolFiles query operation. Specifically, dsym (.dSYM.zip) is classified as artifactType=dsym during queries. symbol-zip (.zip) files are directly uploaded and archived with their original file names, and the current query operation does not support filtering by zip for artifactType.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>proguard</para>
        /// </summary>
        [NameInMap("fileKind")]
        [Validation(Required=false)]
        public string FileKind { get; set; }

        /// <summary>
        /// <para>The name of the symbol file to upload. The file extension must match the fileKind.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mapping.txt</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

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
        /// <para>The version number of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

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
