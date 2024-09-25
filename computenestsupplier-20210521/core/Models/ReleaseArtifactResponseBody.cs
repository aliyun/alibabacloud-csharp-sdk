// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ReleaseArtifactResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the artifact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>artifact-9feded91880e4c78xxxx</para>
        /// </summary>
        [NameInMap("ArtifactId")]
        [Validation(Required=false)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// <para>The content of the artifact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;Url\&quot;:\&quot;<a href="https://computenest-artifacts-draft-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/130920852836xxxx/cn-hangzhou/service-8072a04e5a134382xxxx/165095355xxxx/changes.txt%5C%5C%22,%5C%5C%22ConfigurationMetadata%5C%5C%22:%5C%5C%22%7B%5C%5C%5C%5C%5C%5C%22WorkDir%5C%5C%5C%5C%5C%5C%22:%5C%5C%5C%5C%5C%5C%22/root%5C%5C%5C%5C%5C%5C%22,%5C%5C%5C%5C%5C%5C%22Platform%5C%5C%5C%5C%5C%5C%22:%5C%5C%5C%5C%5C%5C%22Linux%5C%5C%5C%5C%5C%5C%22,%5C%5C%5C%5C%5C%5C%22CommandType%5C%5C%5C%5C%5C%5C%22:%5C%5C%5C%5C%5C%5C%22RunShellScript%5C%5C%5C%5C%5C%5C%22,%5C%5C%5C%5C%5C%5C%22UpgradeScript%5C%5C%5C%5C%5C%5C%22:%5C%5C%5C%5C%5C%5C%22cd">https://computenest-artifacts-draft-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/130920852836xxxx/cn-hangzhou/service-8072a04e5a134382xxxx/165095355xxxx/changes.txt\\&quot;,\\&quot;ConfigurationMetadata\\&quot;:\\&quot;{\\\\\\&quot;WorkDir\\\\\\&quot;:\\\\\\&quot;/root\\\\\\&quot;,\\\\\\&quot;Platform\\\\\\&quot;:\\\\\\&quot;Linux\\\\\\&quot;,\\\\\\&quot;CommandType\\\\\\&quot;:\\\\\\&quot;RunShellScript\\\\\\&quot;,\\\\\\&quot;UpgradeScript\\\\\\&quot;:\\\\\\&quot;cd</a> /root\\\\ncp changes.txt cpchanges.txt\\\\nmv changes.txt mvchangge.txt\\\&quot;}\&quot;}&quot;</para>
        /// </summary>
        [NameInMap("ArtifactProperty")]
        [Validation(Required=false)]
        public string ArtifactProperty { get; set; }

        /// <summary>
        /// <para>The type of the artifact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>File</para>
        /// </summary>
        [NameInMap("ArtifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// <para>The version of the artifact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>draft</para>
        /// </summary>
        [NameInMap("ArtifactVersion")]
        [Validation(Required=false)]
        public string ArtifactVersion { get; set; }

        /// <summary>
        /// <para>The description of the artifact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the artifact was modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1650954178000</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3818BA7D-3F50-1A44-9FF3-04A52A59XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The state of the artifact. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Created: The artifact is created.</description></item>
        /// <item><description>Scanning: The artifact is being scanned.</description></item>
        /// <item><description>ScanFailed: The artifact failed to be scanned.</description></item>
        /// <item><description>Delivering: The artifact is being distributed.</description></item>
        /// <item><description>Available: The artifact is available.</description></item>
        /// <item><description>Deleted: The artifact is deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Created</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The version name of the artifact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V1.0</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
