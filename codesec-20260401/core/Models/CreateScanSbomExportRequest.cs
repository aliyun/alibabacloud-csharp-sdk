// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class CreateScanSbomExportRequest : TeaModel {
        /// <summary>
        /// <para>选填。指定下载落盘的文件名（含扩展名），会签进下载地址的 Content-Disposition。
        /// 留空时后端按 <c>项目名-sbom-&lt;format&gt;.&lt;扩展名&gt;</c> 生成默认值。
        /// 不得含控制字符或路径分隔符（<c>/</c>、<c>\</c>）、长度不超过 255，否则 → 400 <b><c>InvalidFileName</c></b>。</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-sbom-cyclonedx.cdx.json</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>闭合枚举，须是该次扫描 <b><c>artifacts</c></b> 里 <b><c>status=success</c></b> 的 <b><c>artifact_kind</c></b>。
        /// 未知值 → 400 <b><c>InvalidArtifactFormat</c></b>，且绝不参与 OSS key 构造。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cyclonedx-json</para>
        /// </summary>
        [NameInMap("format")]
        [Validation(Required=false)]
        public string Format { get; set; }

    }

}
