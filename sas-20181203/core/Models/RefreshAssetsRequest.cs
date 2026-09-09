// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class RefreshAssetsRequest : TeaModel {
        /// <summary>
        /// <para>The type of asset to synchronize. Default value: <b>ecs</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_product</b>: cloud product</description></item>
        /// <item><description><b>ecs</b>: server</description></item>
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
        /// <para>The subtype of the cloud product.</para>
        /// <remarks>
        /// <para>Refer to the following list for valid values.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CloudAssetSubType")]
        [Validation(Required=false)]
        public int? CloudAssetSubType { get; set; }

        /// <summary>
        /// <para>The type of cloud product. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: server</description></item>
        /// <item><description><b>1</b>: load balancing</description></item>
        /// <item><description><b>3</b>: ApsaraDB RDS database</description></item>
        /// <item><description><b>4</b>: ApsaraDB for MongoDB database</description></item>
        /// <item><description><b>5</b>: Tair (Redis® OSS-Compatible) database</description></item>
        /// <item><description><b>6</b>: Container Registry</description></item>
        /// <item><description><b>8</b>: container service for Kubernetes</description></item>
        /// <item><description><b>9</b>: VPC</description></item>
        /// <item><description><b>11</b>: ActionTrail</description></item>
        /// <item><description><b>12</b>: CDN</description></item>
        /// <item><description><b>13</b>: Certificate Management Service (formerly SSL Certificates Service)</description></item>
        /// <item><description><b>14</b>: Apsara Devops</description></item>
        /// <item><description><b>15</b>: access control</description></item>
        /// <item><description><b>16</b>: Anti-DDoS</description></item>
        /// <item><description><b>17</b>: Web Application Firewall</description></item>
        /// <item><description><b>18</b>: OSS</description></item>
        /// <item><description><b>19</b>: cloud-native relational database PolarDB</description></item>
        /// <item><description><b>20</b>: ApsaraDB RDS for PostgreSQL database</description></item>
        /// <item><description><b>21</b>: Microservices Engine</description></item>
        /// <item><description><b>22</b>: File Storage NAS</description></item>
        /// <item><description><b>23</b>: Data Security Center</description></item>
        /// <item><description><b>24</b>: EIP</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CloudAssetType")]
        [Validation(Required=false)]
        public int? CloudAssetType { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account of the member accounts in the resource directory.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The server vendor. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Alibaba Cloud asset</description></item>
        /// <item><description><b>1</b>: asset outside the cloud</description></item>
        /// <item><description><b>2</b>: IDC asset</description></item>
        /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, <b>7</b>: third-party cloud asset</description></item>
        /// <item><description><b>8</b>: lightweight asset</description></item>
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
