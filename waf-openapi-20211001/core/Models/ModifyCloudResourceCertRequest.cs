// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyCloudResourceCertRequest : TeaModel {
        /// <summary>
        /// <para>The list of certificates.</para>
        /// <remarks>
        /// <para>Enter all certificate IDs. This includes the default certificate and all additional certificates. After you submit the request, WAF compares the submitted IDs with the existing ones. WAF adds new certificates and deletes certificates that are not in your list. Deleting a certificate may affect related services.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<ModifyCloudResourceCertRequestCertificates> Certificates { get; set; }
        public class ModifyCloudResourceCertRequestCertificates : TeaModel {
            /// <summary>
            /// <para>The type of the certificate for the HTTPS protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>default</b>: the default certificate.</para>
            /// </description></item>
            /// <item><description><para><b>extension</b>: the additional certificate.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("AppliedType")]
            [Validation(Required=false)]
            public string AppliedType { get; set; }

            /// <summary>
            /// <para>The ID of the certificate.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>232***-cn-hangzhou</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the resource that is added to WAF. WAF automatically generates this ID when you add the resource in cloud native mode.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2839876.html">CreateCloudResource</a> operation to add a resource. Then, view the resource ID in the response.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp*********k5uj2p-443-clb7</para>
        /// </summary>
        [NameInMap("CloudResourceId")]
        [Validation(Required=false)]
        public string CloudResourceId { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v2_public_cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The port of the cloud product that is added to WAF.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        [Obsolete]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the cloud product instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1*****jqnnqk5uj2p</para>
        /// </summary>
        [NameInMap("ResourceInstanceId")]
        [Validation(Required=false)]
        [Obsolete]
        public string ResourceInstanceId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The type of the cloud product. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ecs</b>: Elastic Compute Service (ECS).</para>
        /// </description></item>
        /// <item><description><para><b>clb4</b>: Layer 4 Classic Load Balancer (CLB).</para>
        /// </description></item>
        /// <item><description><para><b>nlb</b>: Network Load Balancer (NLB).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>clb4</para>
        /// </summary>
        [NameInMap("ResourceProduct")]
        [Validation(Required=false)]
        [Obsolete]
        public string ResourceProduct { get; set; }

    }

}
