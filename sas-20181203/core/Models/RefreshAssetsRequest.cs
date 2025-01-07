// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class RefreshAssetsRequest : TeaModel {
        /// <summary>
        /// <para>The type of the asset that you want to synchronize. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_product</b>: Alibaba Cloud service</description></item>
        /// <item><description><b>ecs</b>: Elastic Compute Service (ECS) instance</description></item>
        /// <item><description><b>container_image</b>: container image</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_product</para>
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// <para>The subtype of the cloud service.</para>
        /// <remarks>
        /// <para> The following list describes the subtypes of cloud services.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CloudAssetSubType")]
        [Validation(Required=false)]
        public int? CloudAssetSubType { get; set; }

        /// <summary>
        /// <para>The type of the cloud service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: ECS</description></item>
        /// <item><description><b>1</b>: Server Load Balancer (SLB)</description></item>
        /// <item><description><b>3</b>: ApsaraDB RDS</description></item>
        /// <item><description><b>4</b>: ApsaraDB for MongoDB (MongoDB)</description></item>
        /// <item><description><b>5</b>: ApsaraDB for Redis (Redis)</description></item>
        /// <item><description><b>6</b>: Container Registry</description></item>
        /// <item><description><b>8</b>: Container Service for Kubernetes (ACK)</description></item>
        /// <item><description><b>9</b>: Virtual Private Cloud (VPC)</description></item>
        /// <item><description><b>11</b>: ActionTrail</description></item>
        /// <item><description><b>12</b>: Alibaba Cloud CDN (CDN)</description></item>
        /// <item><description><b>13</b>: Certificate Management Service (formerly SSL Certificates Service)</description></item>
        /// <item><description><b>14</b>: Apsara Devops</description></item>
        /// <item><description><b>15</b>: Resource Access Management (RAM)</description></item>
        /// <item><description><b>16</b>: Anti-DDoS</description></item>
        /// <item><description><b>17</b>: Web Application Firewall (WAF)</description></item>
        /// <item><description><b>18</b>: Object Storage Service (OSS)</description></item>
        /// <item><description><b>19</b>: PolarDB</description></item>
        /// <item><description><b>20</b>: ApsaraDB RDS for PostgreSQL</description></item>
        /// <item><description><b>21</b>: Microservices Engine (MSE)</description></item>
        /// <item><description><b>22</b>: File Storage NAS (NAS)</description></item>
        /// <item><description><b>23</b>: Data Security Center (DSC)</description></item>
        /// <item><description><b>24</b>: Elastic IP Address (EIP)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CloudAssetType")]
        [Validation(Required=false)]
        public int? CloudAssetType { get; set; }

        /// <summary>
        /// <para>The type of the server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: an asset provided by Alibaba Cloud</description></item>
        /// <item><description><b>1</b>: a third-party cloud asset</description></item>
        /// <item><description><b>2</b>: an asset in a data center</description></item>
        /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: an asset provided by another cloud</description></item>
        /// <item><description><b>8</b>: a lightweight asset</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public int? Vendor { get; set; }

    }

}
