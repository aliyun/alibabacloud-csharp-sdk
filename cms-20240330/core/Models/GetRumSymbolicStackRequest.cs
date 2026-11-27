// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetRumSymbolicStackRequest : TeaModel {
        /// <summary>
        /// <para>The symbol file matching information, which varies based on stackType. For js, jvm, and android-native, it is a JSON string (js and jvm must contain both version and fileName, and optionally uuid/debugId; android-native supports a single module, a modules array, and il2cppMapping). For cocoa, it is a non-JSON format (module:objectKey;...) for historical compatibility only, and it is recommended to pass it through images in the new version. If matching information is missing, the symbol is not found, or parsing fails for js, an empty result is returned. If fileInfo is missing or the symbol is not found for jvm, an empty result is returned, and it falls back to the original stack only when downstream symbolication fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;version&quot;:&quot;1.0.0&quot;,&quot;fileName&quot;:&quot;mapping.txt&quot;}</para>
        /// </summary>
        [NameInMap("fileInfo")]
        [Validation(Required=false)]
        public string FileInfo { get; set; }

        /// <summary>
        /// <para>The binary image information associated with Native/Cocoa crashes. The format varies based on stackType (only electron-native uses a JSON array). For cocoa, it is a line-by-line string (each line is module:arch;uuid;loadAddress). For electron-native, it is a JSON array string (elements contain name, debug_id/debugId, or code_id/codeId, and optionally load_address/loadAddress and arch). For windows-native, it is a semicolon-separated string of debugId and debugFile (.pdb file name). For macos-native, it is a semicolon-separated string of uuid and name. If matching information is missing, the symbol file is not found, or symbolication fails, Native/Cocoa types fall back to returning the original stack lines. The following example applies only to scenarios where stackType is electron-native and cannot be directly combined with stackType=jvm in a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;Electron Framework&quot;,&quot;debug_id&quot;:&quot;ABCDEF01-2345-6789-ABCD-EF0123456789&quot;,&quot;code_id&quot;:&quot;CODE-1&quot;,&quot;load_address&quot;:&quot;0x0000000100000000&quot;,&quot;arch&quot;:&quot;arm64&quot;}]</para>
        /// </summary>
        [NameInMap("images")]
        [Validation(Required=false)]
        public string Images { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The application PID. <b>[Deprecated]</b> The server automatically resolves this value based on the workspace and serviceId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxojw@e3hd38hxxxx11</para>
        /// </summary>
        [NameInMap("pid")]
        [Validation(Required=false)]
        [Obsolete]
        public string Pid { get; set; }

        /// <summary>
        /// <para>The service ID of the RUM application. This parameter is required and cannot be an empty string. It must be used together with workspace to locate the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4e5@f67890</para>
        /// </summary>
        [NameInMap("serviceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The original exception stack content to be symbolicated. This parameter is required and cannot be an empty string. If stackType is js, the format is &quot;line,column,rows&quot;. For other types, pass the original stack text of the corresponding platform.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>java.lang.NullPointerException
        ///     at com.example.Main.main(Main.java:10)</para>
        /// </summary>
        [NameInMap("stack")]
        [Validation(Required=false)]
        public string Stack { get; set; }

        /// <summary>
        /// <para>The stack type. This parameter is required and cannot be an empty string. Valid values: js, jvm, android-native, cocoa, electron-native, windows-native, and macos-native.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jvm</para>
        /// </summary>
        [NameInMap("stackType")]
        [Validation(Required=false)]
        public string StackType { get; set; }

        /// <summary>
        /// <para>The ID of the exception thread.</para>
        /// 
        /// <b>Example:</b>
        /// <para>thread-1</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// <para>The name of the workspace to which the RUM application belongs. This parameter is required and cannot be an empty string. It must be used together with serviceId to locate the application.</para>
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
