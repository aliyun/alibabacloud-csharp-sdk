// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListKspmInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The list of asset type information for Kubernetes assets.</para>
        /// </summary>
        [NameInMap("CloudAssetTypes")]
        [Validation(Required=false)]
        public List<ListKspmInstancesRequestCloudAssetTypes> CloudAssetTypes { get; set; }
        public class ListKspmInstancesRequestCloudAssetTypes : TeaModel {
            /// <summary>
            /// <para>The subtype of the asset. The value is in the format of asset type - subtype. Valid values:</para>
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
            /// <item><description><b>1</b>: ResourceQuota.</description></item>
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
            /// <para>The type of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Workload</description></item>
            /// <item><description><b>1</b>: Service</description></item>
            /// <item><description><b>2</b>: Namespace</description></item>
            /// <item><description><b>3</b>: Authorization</description></item>
            /// <item><description><b>4</b>: Storage</description></item>
            /// <item><description><b>5</b>: Container</description></item>
            /// <item><description><b>6</b>: Network</description></item>
            /// <item><description><b>7</b>: Configuration</description></item>
            /// <item><description><b>8</b>: Policies.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <para>The asset vendor. This parameter is fixed to <b>200</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        /// <summary>
        /// <para>The search conditions for assets. This parameter is in JSON format. Pay attention to letter case when you specify this parameter. The following fields are included:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the search item.</description></item>
        /// <item><description><b>value</b>: the value of the search item.</description></item>
        /// <item><description><b>logicalExp</b>: the logical relationship between multiple conditions. Valid values:<list type="bullet">
        /// <item><description><b>OR</b>: The conditions are in an OR relationship.</description></item>
        /// <item><description><b>AND</b>: The conditions are in an AND relationship.<remarks>
        /// <para>You can search by region, instance name, instance ID, alert status, risk status, or tag.</para>
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
        /// <para>The page number of the page to return in the query results. Default value: 1, which indicates that the results are returned starting from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The logical relationship between multiple search conditions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OR</b>: The search conditions are in an OR relationship.</description></item>
        /// <item><description><b>AND</b>: The search conditions are in an AND relationship.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paged query. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
