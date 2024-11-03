// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the accelerated domain name.</para>
        /// </summary>
        [NameInMap("GetDomainDetailModel")]
        [Validation(Required=false)]
        public DescribeCdnDomainDetailResponseBodyGetDomainDetailModel GetDomainDetailModel { get; set; }
        public class DescribeCdnDomainDetailResponseBodyGetDomainDetailModel : TeaModel {
            /// <summary>
            /// <para>The workload type of the accelerated domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>web</b>: images and small files</description></item>
            /// <item><description><b>download</b>: large files</description></item>
            /// <item><description><b>video</b>: on-demand video and audio streaming</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>web</para>
            /// </summary>
            [NameInMap("CdnType")]
            [Validation(Required=false)]
            public string CdnType { get; set; }

            /// <summary>
            /// <para>The CNAME that is assigned to the accelerated domain name. You must add the CNAME record in the system of your DNS service provider to map the accelerated domain name to the CNAME.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com.w.kunlunle.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>The description of the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Streaming domain</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The accelerated domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The status of the accelerated domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>online</b></description></item>
            /// <item><description><b>offline</b></description></item>
            /// <item><description><b>configuring</b></description></item>
            /// <item><description><b>configure_failed</b></description></item>
            /// <item><description><b>checking</b></description></item>
            /// <item><description><b>check_failed</b></description></item>
            /// <item><description><b>stopping</b></description></item>
            /// <item><description><b>deleting</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("DomainStatus")]
            [Validation(Required=false)]
            public string DomainStatus { get; set; }

            /// <summary>
            /// <para>The time when the domain name was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-06-25T03:30:50Z</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The time when the domain name was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-06-25T03:30:50Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The CNAME for which HTTPS is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com.w.kunlunle.com</para>
            /// </summary>
            [NameInMap("HttpsCname")]
            [Validation(Required=false)]
            public string HttpsCname { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcd1234abcd1234</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The acceleration region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>domestic</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>Indicates whether the SSL certificate is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b></description></item>
            /// <item><description><b>off</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("ServerCertificateStatus")]
            [Validation(Required=false)]
            public string ServerCertificateStatus { get; set; }

            /// <summary>
            /// <para>The information about the origin server.</para>
            /// </summary>
            [NameInMap("SourceModels")]
            [Validation(Required=false)]
            public DescribeCdnDomainDetailResponseBodyGetDomainDetailModelSourceModels SourceModels { get; set; }
            public class DescribeCdnDomainDetailResponseBodyGetDomainDetailModelSourceModels : TeaModel {
                [NameInMap("SourceModel")]
                [Validation(Required=false)]
                public List<DescribeCdnDomainDetailResponseBodyGetDomainDetailModelSourceModelsSourceModel> SourceModel { get; set; }
                public class DescribeCdnDomainDetailResponseBodyGetDomainDetailModelSourceModelsSourceModel : TeaModel {
                    /// <summary>
                    /// <para>The address of the origin server.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example.com</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>online</para>
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public string Enabled { get; set; }

                    /// <summary>
                    /// <para>The port over which requests are redirected to the origin server. Ports 443 and 80 are supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The priority.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public string Priority { get; set; }

                    /// <summary>
                    /// <para>The type of the origin server. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>ipaddr</b>: an origin IP address</description></item>
                    /// <item><description><b>domain</b>: an origin domain name</description></item>
                    /// <item><description><b>oss</b>: the domain name of an Object Storage Service (OSS) bucket</description></item>
                    /// <item><description><b>fc_domain:</b> a Function Compute domain name</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>domain</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The weight of the origin server if multiple origin servers have been specified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public string Weight { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18CF38AA-1275-451D-A12B-4EC0BF1C5E30</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
