// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PublicCreateImageScanTaskRequest : TeaModel {
        /// <summary>
        /// <para>The SHA-256 value of the image digest. Separate multiple SHA-256 values with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>6a5e103187b31a94592a47a5858617f7a6c</para>
        /// </summary>
        [NameInMap("Digests")]
        [Validation(Required=false)]
        public string Digests { get; set; }

        /// <summary>
        /// <para>The ID of the Container Registry instance in which the image repository is created. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-uf6j8vq9l4r5ntht****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The region ID of the image. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public string RegionIds { get; set; }

        /// <summary>
        /// <para>The type of the image repository. Separate multiple types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>acr</b></description></item>
        /// <item><description><b>harbor</b></description></item>
        /// <item><description><b>quay</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acr</para>
        /// </summary>
        [NameInMap("RegistryTypes")]
        [Validation(Required=false)]
        public string RegistryTypes { get; set; }

        /// <summary>
        /// <para>The ID of the image repository. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-vridcl4****</para>
        /// </summary>
        [NameInMap("RepoIds")]
        [Validation(Required=false)]
        public string RepoIds { get; set; }

        /// <summary>
        /// <para>The name of the image repository. Separate multiple names with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>centos</para>
        /// </summary>
        [NameInMap("RepoNames")]
        [Validation(Required=false)]
        public string RepoNames { get; set; }

        /// <summary>
        /// <para>The namespace to which the image repository belongs. Separate multiple namespaces with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>hanghai-namespace</para>
        /// </summary>
        [NameInMap("RepoNamespaces")]
        [Validation(Required=false)]
        public string RepoNamespaces { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168..XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The tag that is added to the image. Separate multiple tags with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.2</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
