// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCloudAssetSchemasResponseBody : TeaModel {
        /// <summary>
        /// <para>List of asset structure definitions</para>
        /// </summary>
        [NameInMap("CloudAssetSchemas")]
        [Validation(Required=false)]
        public List<ListCloudAssetSchemasResponseBodyCloudAssetSchemas> CloudAssetSchemas { get; set; }
        public class ListCloudAssetSchemasResponseBodyCloudAssetSchemas : TeaModel {
            /// <summary>
            /// <para>Subtype of the cloud product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            /// <summary>
            /// <para>The type of the cloud asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Elastic Compute Service (ECS).</description></item>
            /// <item><description><b>1</b>: Server Load Balancer (SLB).</description></item>
            /// <item><description><b>3</b>: ApsaraDB RDS.</description></item>
            /// <item><description><b>4</b>: ApsaraDB for MongoDB.</description></item>
            /// <item><description><b>5</b>: ApsaraDB for Redis.</description></item>
            /// <item><description><b>6</b>: Container Registry.</description></item>
            /// <item><description><b>8</b>: Container Service for Kubernetes.</description></item>
            /// <item><description><b>9</b>: Virtual Private Cloud (VPC).</description></item>
            /// <item><description><b>11</b>: ActionTrail.</description></item>
            /// <item><description><b>12</b>: Alibaba Cloud CDN (CDN).</description></item>
            /// <item><description><b>13</b>: Certificate Management Service.</description></item>
            /// <item><description><b>14</b>: Apsara Devops.</description></item>
            /// <item><description><b>15</b>: Resource Access Management (RAM).</description></item>
            /// <item><description><b>16</b>: Anti-DDoS.</description></item>
            /// <item><description><b>17</b>: Web Application Firewall (WAF).</description></item>
            /// <item><description><b>18</b>: Object Storage Service (OSS).</description></item>
            /// <item><description><b>19</b>: PolarDB.</description></item>
            /// <item><description><b>20</b>: ApsaraDB RDS for PostgreSQL.</description></item>
            /// <item><description><b>21</b>: Microservices Engine (MSE).</description></item>
            /// <item><description><b>22</b>: File Storage NAS (NAS).</description></item>
            /// <item><description><b>23</b>: Data Security Center (DSC).</description></item>
            /// <item><description><b>24</b>: Elastic IP Address (EIP).</description></item>
            /// <item><description><b>25</b>: Identity as a Service (IDaaS)-Employee Identity and Access Management (EIAM).</description></item>
            /// <item><description><b>26</b>: PolarDB-X.</description></item>
            /// <item><description><b>27</b>: Elasticsearch.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <para>Asset structure definition name</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS_ECS_Disk</para>
            /// </summary>
            [NameInMap("DataName")]
            [Validation(Required=false)]
            public string DataName { get; set; }

            /// <summary>
            /// <para>Current asset structure definition text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;associatedData\&quot;:[{\&quot;assetSubType\&quot;:100,\&quot;assetType\&quot;:0,\&quot;dataName\&quot;:\&quot;ACS_ECS_Instance\&quot;,\&quot;properties\&quot;:[{\&quot;name\&quot;:\&quot;InstanceId\&quot;,\&quot;path\&quot;:\&quot;InstanceId\&quot;}],\&quot;vendor\&quot;:0}],\&quot;description\&quot;:\&quot;The ID of the instance to which the disk is attached.\&quot;,\&quot;example\&quot;:\&quot;i-bp67acfmxazb4q****\&quot;,\&quot;name\&quot;:\&quot;InstanceId\&quot;,\&quot;type\&quot;:\&quot;STRING\&quot;,\&quot;withAssociatedData\&quot;:true},{\&quot;description\&quot;:\&quot;Disk name\&quot;,\&quot;example\&quot;:\&quot;testDiskName\&quot;,\&quot;name\&quot;:\&quot;DiskName\&quot;,\&quot;type\&quot;:\&quot;STRING\&quot;},{\&quot;description\&quot;:\&quot;Only encrypted disks\&quot;,\&quot;example\&quot;:\&quot;false\&quot;,\&quot;name\&quot;:\&quot;Encrypted\&quot;,\&quot;type\&quot;:\&quot;BOOLEAN\&quot;},{\&quot;description\&quot;:\&quot;Disk status\&quot;,\&quot;example\&quot;:\&quot;In_use\&quot;,\&quot;name\&quot;:\&quot;Status\&quot;,\&quot;type\&quot;:\&quot;STRING\&quot;},{\&quot;description\&quot;:\&quot;Disk category\&quot;,\&quot;example\&quot;:\&quot;cloud_ssd\&quot;,\&quot;name\&quot;:\&quot;Category\&quot;,\&quot;type\&quot;:\&quot;STRING\&quot;},{\&quot;description\&quot;:\&quot;Disk type\&quot;,\&quot;example\&quot;:\&quot;system\&quot;,\&quot;name\&quot;:\&quot;Type\&quot;,\&quot;type\&quot;:\&quot;STRING\&quot;},{\&quot;description\&quot;:\&quot;Specifies whether to set an automatic snapshot policy for the disk.\&quot;,\&quot;example\&quot;:\&quot;false\&quot;,\&quot;name\&quot;:\&quot;EnableAutomatedSnapshotPolicy\&quot;,\&quot;type\&quot;:\&quot;BOOLEAN\&quot;},{\&quot;description\&quot;:\&quot;The ID of the automatic snapshot policy.\&quot;,\&quot;example\&quot;:\&quot;sp-bp67acfmxazb4p****\&quot;,\&quot;name\&quot;:\&quot;AutoSnapshotPolicyId\&quot;,\&quot;type\&quot;:\&quot;STRING\&quot;},{\&quot;description\&quot;:\&quot;Disk, local disk, or elastic ephemeral disk ID\&quot;,\&quot;example\&quot;:\&quot;d-bp18um4r4f2fve24****\&quot;,\&quot;name\&quot;:\&quot;DiskId\&quot;,\&quot;type\&quot;:\&quot;STRING\&quot;}]</para>
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            /// <summary>
            /// <para>The source of the server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: an asset provided by Alibaba Cloud.</description></item>
            /// <item><description><b>1</b>: a third-party cloud server</description></item>
            /// <item><description><b>2</b>: a server in a data center</description></item>
            /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: other cloud asset</description></item>
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

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCloudAssetSchemasResponseBodyPageInfo PageInfo { get; set; }
        public class ListCloudAssetSchemasResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>Current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>54</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8B6F758-BCD4-597A-8A2C-DA5A552C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful. </description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
