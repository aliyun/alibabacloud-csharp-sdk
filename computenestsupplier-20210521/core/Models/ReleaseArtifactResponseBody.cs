// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ReleaseArtifactResponseBody : TeaModel {
        /// <summary>
        /// <para>The artifact ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>artifact-9feded91880e4c78****</para>
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
        /// <para>The artifact type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>File</para>
        /// </summary>
        [NameInMap("ArtifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// <para>The artifact version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>draft</para>
        /// </summary>
        [NameInMap("ArtifactVersion")]
        [Validation(Required=false)]
        public string ArtifactVersion { get; set; }

        /// <summary>
        /// <para>The artifact description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Redhat8_0 image</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the artifact was last modified.</para>
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
        /// <para>86CAC31E-3527-562C-869F-347E931C9B25</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the artifact.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Created: The artifact is created.</para>
        /// </description></item>
        /// <item><description><para>Scanning: The artifact is being scanned.</para>
        /// </description></item>
        /// <item><description><para>ScanFailed: The artifact failed to be scanned.</para>
        /// </description></item>
        /// <item><description><para>Delivering: The artifact is being distributed.</para>
        /// </description></item>
        /// <item><description><para>Available: The artifact is available.</para>
        /// </description></item>
        /// <item><description><para>Deleted: The artifact is deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Created</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The name of the artifact version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS association upgrade test</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
