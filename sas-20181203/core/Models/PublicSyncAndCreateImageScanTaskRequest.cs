// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PublicSyncAndCreateImageScanTaskRequest : TeaModel {
        /// <summary>
        /// <para>The information about the images. The value of this parameter is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RegistryType</b>: the type of the image repository. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>acr</description></item>
        /// <item><description>harbor</description></item>
        /// <item><description>quay</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>RepoId</b>: the ID of the image repository.</para>
        /// </description></item>
        /// <item><description><para><b>InstanceId</b>: the ID of the Container Registry instance to which the image repository belongs.</para>
        /// </description></item>
        /// <item><description><para><b>RepoNamespace</b>: the namespace to which the image repository belongs.</para>
        /// </description></item>
        /// <item><description><para><b>RegionId</b>: the region ID of the image.</para>
        /// </description></item>
        /// <item><description><para><b>RepoName</b>: the name of the image repository.</para>
        /// </description></item>
        /// <item><description><para><b>Digest</b>: the digest of the image.</para>
        /// </description></item>
        /// <item><description><para><b>Tag</b>: the tag that is added to the image.</para>
        /// </description></item>
        /// <item><description><para><b>CreateTime</b>: the timestamp when the image was created. Unit: milliseconds.</para>
        /// </description></item>
        /// <item><description><para><b>UpdateTime</b>: the timestamp when the image was updated. Unit: milliseconds.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;registryType&quot;:&quot;acr&quot;,&quot;repoId&quot;:&quot;crr-red9kgqqi0fh75d5&quot;,&quot;instanceId&quot;:&quot;cri-1x2qtjd75ofqvfa8&quot;,&quot;repoNamespace&quot;:&quot;1125&quot;,&quot;regionId&quot;:&quot;cn-hangzhou&quot;,&quot;repoName&quot;:&quot;script1&quot;,&quot;digest&quot;:&quot;b1064a5007786b6f82a50772858e8156bc1e5fbddb7dd20af6922761ad197fe4&quot;,&quot;tag&quot;:&quot;v0113-ver2&quot;,&quot;createTime&quot;:1641267666666,&quot;updateTime&quot;:1641267909090}]</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public string Images { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.X.X</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
