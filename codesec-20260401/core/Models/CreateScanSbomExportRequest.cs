// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class CreateScanSbomExportRequest : TeaModel {
        /// <summary>
        /// <para>The file name (including the extension) for the downloaded file. The file name is signed into the Content-Disposition header of the URL. If you leave this parameter empty, the backend generates a file name in the format of project name-sbom-<format>.<extension>. If the file name contains control characters or path separators (/ or \), or if the length exceeds 255 characters, a 400 InvalidFileName error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-sbom-cyclonedx.cdx.json</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cyclonedx-json</description></item>
        /// <item><description>spdx-json</description></item>
        /// </list>
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
