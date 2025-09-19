// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInstanceCatalogResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0D42A83F-CE33-5F54-A5AE-05DA39F59E1B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The asset types by service provider.</para>
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<ListInstanceCatalogResponseBodyVendors> Vendors { get; set; }
        public class ListInstanceCatalogResponseBodyVendors : TeaModel {
            /// <summary>
            /// <para>The asset types.</para>
            /// </summary>
            [NameInMap("InstanceTypes")]
            [Validation(Required=false)]
            public List<ListInstanceCatalogResponseBodyVendorsInstanceTypes> InstanceTypes { get; set; }
            public class ListInstanceCatalogResponseBodyVendorsInstanceTypes : TeaModel {
                /// <summary>
                /// <para>The asset subtypes.</para>
                /// </summary>
                [NameInMap("InstanceSubTypes")]
                [Validation(Required=false)]
                public List<ListInstanceCatalogResponseBodyVendorsInstanceTypesInstanceSubTypes> InstanceSubTypes { get; set; }
                public class ListInstanceCatalogResponseBodyVendorsInstanceTypesInstanceSubTypes : TeaModel {
                    /// <summary>
                    /// <para>The name of the asset subtype.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SECURITY_GROUP</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The ID of the asset subtype.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public int? Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the asset type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the asset type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Elastic Compute Service (ECS)</description></item>
                /// <item><description><b>1</b>: Server Load Balancer (SLB)</description></item>
                /// <item><description><b>3</b>: ApsaraDB RDS</description></item>
                /// <item><description><b>4</b>: ApsaraDB for MongoDB (MongoDB)</description></item>
                /// <item><description><b>5</b>: Tair (Redis OSS-compatible)</description></item>
                /// <item><description><b>6</b>: Container Registry</description></item>
                /// <item><description><b>8</b>: Container Service for Kubernetes (ACK)</description></item>
                /// <item><description><b>9</b>: Virtual Private Cloud (VPC)</description></item>
                /// <item><description><b>11</b>: ActionTrail</description></item>
                /// <item><description><b>12</b>: Alibaba Cloud CDN (CDN)</description></item>
                /// <item><description><b>13</b>: Certificate Management Service (formerly SSL Certificates Service)</description></item>
                /// <item><description><b>14</b>: Alibaba Cloud DevOps</description></item>
                /// <item><description><b>15</b>: Resource Access Management (RAM)</description></item>
                /// <item><description><b>16</b>: Anti-DDoS</description></item>
                /// <item><description><b>17</b>: Web Application Firewall (WAF)</description></item>
                /// <item><description><b>18</b>: Object Storage Service (OSS)</description></item>
                /// <item><description><b>19</b>: PolarDB</description></item>
                /// <item><description><b>20</b>: ApsaraDB RDS for PostgreSQL</description></item>
                /// <item><description><b>21</b>: Microservices Engine (MSE)</description></item>
                /// <item><description><b>22</b>: Apsara File Storage NAS (NAS)</description></item>
                /// <item><description><b>23</b>: Data Security Center (DSC)</description></item>
                /// <item><description><b>24</b>: Elastic IP Address (EIP)</description></item>
                /// <item><description><b>25</b>: Identity as a Service (IDaaS) - Enterprise Identity Access Management (EIAM)</description></item>
                /// <item><description><b>26</b>: PolarDB for Xscale (PolarDB-X)</description></item>
                /// <item><description><b>27</b>: Elasticsearch</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public int? Value { get; set; }

            }

            /// <summary>
            /// <para>The name of the service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the service provider type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: an asset provided by Alibaba Cloud</description></item>
            /// <item><description><b>1</b>: an asset outside Alibaba Cloud</description></item>
            /// <item><description><b>2</b>: an asset in a data center</description></item>
            /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: an asset from a third-party cloud service provider</description></item>
            /// <item><description><b>8</b>: a lightweight cloud asset</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public int? Value { get; set; }

        }

    }

}
