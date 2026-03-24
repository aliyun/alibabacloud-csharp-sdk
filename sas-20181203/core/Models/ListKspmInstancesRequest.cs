// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListKspmInstancesRequest : TeaModel {
        /// <summary>
        /// <para>List of Kubernetes asset type information.</para>
        /// </summary>
        [NameInMap("CloudAssetTypes")]
        [Validation(Required=false)]
        public List<ListKspmInstancesRequestCloudAssetTypes> CloudAssetTypes { get; set; }
        public class ListKspmInstancesRequestCloudAssetTypes : TeaModel {
            /// <summary>
            /// <para>Subtype of the product.
            /// Asset type-subtype. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Workload<list type="bullet">
            /// <item><description><b>0</b>: Pod</description></item>
            /// <item><description><b>1</b>: DaemonSet</description></item>
            /// <item><description><b>2</b>: StatefulSet</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>1</b>: Service<list type="bullet">
            /// <item><description><b>0</b>: Service</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>2</b>: Namespace<list type="bullet">
            /// <item><description><b>0</b>: Namespace</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>3</b>: Authorization<list type="bullet">
            /// <item><description><b>0</b>: Role</description></item>
            /// <item><description><b>1</b>: ClusterRole</description></item>
            /// <item><description><b>2</b>: ClusterRoleBinding</description></item>
            /// <item><description><b>3</b>: RoleBinding</description></item>
            /// <item><description><b>4</b>: ServiceAccount</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>4</b>: Storage<list type="bullet">
            /// <item><description><b>0</b>: PersistentVolume</description></item>
            /// <item><description><b>1</b>: PersistentVolumeClaim</description></item>
            /// <item><description><b>2</b>: StorageClass</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>5</b>: Container<list type="bullet">
            /// <item><description><b>0</b>: Image</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>6</b>: Network<list type="bullet">
            /// <item><description><b>0</b>: Route</description></item>
            /// <item><description><b>0</b>: Ingress</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>7</b>: Configuration<list type="bullet">
            /// <item><description><b>0</b>: ConfigMap</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>8</b>: Policies<list type="bullet">
            /// <item><description><b>0</b>: LimitRanges</description></item>
            /// <item><description><b>1</b>: ResourceQuota</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            /// <summary>
            /// <para>Type of the asset. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Workload</description></item>
            /// <item><description><b>1</b>: Service</description></item>
            /// <item><description><b>2</b>: Namespace</description></item>
            /// <item><description><b>3</b>: Authorization</description></item>
            /// <item><description><b>4</b>: Storage</description></item>
            /// <item><description><b>5</b>: Container</description></item>
            /// <item><description><b>6</b>: Network</description></item>
            /// <item><description><b>7</b>: Configuration</description></item>
            /// <item><description><b>8</b>: Policies</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <para>Vendor of the asset. The fixed value is <b>200</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        /// <summary>
        /// <para>Set the conditions for searching assets. This parameter is in JSON format, and case sensitivity should be noted when entering parameters. It includes the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: Search item</description></item>
        /// <item><description><b>value</b>: Value of the search item</description></item>
        /// <item><description><b>logicalExp</b>: The relationship between search items when multiple conditions are used. Values:<list type="bullet">
        /// <item><description><b>OR</b>: Indicates an <b>or</b> relationship between multiple conditions.</description></item>
        /// <item><description><b>AND</b>: Indicates an <b>and</b> relationship between multiple conditions.<remarks>
        /// <para>Supports using region, instance name, instance ID, alarm status, risk status, and tag search conditions.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;vulStatus&quot;,&quot;value&quot;:&quot;YES&quot;,&quot;logicalExp&quot;:&quot;AND&quot;}]</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>Set which page to start displaying the query results from. The default value is 1, indicating that the display starts from the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Set the logical relationship that takes effect between multiple search conditions. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>OR</b>: Indicates an <b>or</b> relationship between multiple search conditions.</description></item>
        /// <item><description><b>AND</b>: Indicates an <b>and</b> relationship between multiple search conditions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// <para>The maximum number of data entries displayed per page during pagination. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
