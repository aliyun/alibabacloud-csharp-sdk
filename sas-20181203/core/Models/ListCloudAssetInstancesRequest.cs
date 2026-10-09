// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCloudAssetInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The data list to query by keyword.</para>
        /// </summary>
        [NameInMap("CloudAssetQueryData")]
        [Validation(Required=false)]
        public List<ListCloudAssetInstancesRequestCloudAssetQueryData> CloudAssetQueryData { get; set; }
        public class ListCloudAssetInstancesRequestCloudAssetQueryData : TeaModel {
            /// <summary>
            /// <para>The query content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>163.8.8.9</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// <para>The query operator. Only INCLUDE is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INCLUDE</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

        }

        /// <summary>
        /// <para>The asset list of cloud asset instances.</para>
        /// </summary>
        [NameInMap("CloudAssetTypes")]
        [Validation(Required=false)]
        public List<ListCloudAssetInstancesRequestCloudAssetTypes> CloudAssetTypes { get; set; }
        public class ListCloudAssetInstancesRequestCloudAssetTypes : TeaModel {
            /// <summary>
            /// <para>The subtype of the cloud product.</para>
            /// <remarks>
            /// <para>For more information, see the AssetSubType field in <a href="~~GetCloudAssetCriteria~~">GetCloudAssetCriteria</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            /// <summary>
            /// <para>The type of the cloud asset.</para>
            /// <remarks>
            /// <para>For more information, see the AssetType field in <a href="~~GetCloudAssetCriteria~~">GetCloudAssetCriteria</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <para>The server vendor. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Alibaba Cloud asset</description></item>
            /// <item><description><b>1</b>: off-cloud asset</description></item>
            /// <item><description><b>2</b>: IDC asset</description></item>
            /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, <b>7</b>: other cloud assets</description></item>
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

        /// <summary>
        /// <para>The search criteria for assets. This parameter is in JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: The search field.</description></item>
        /// <item><description><b>value</b>: The value of the search field.</description></item>
        /// <item><description><b>logicalExp</b>: The logical relationship between multiple search field values. Valid values:<list type="bullet">
        /// <item><description><b>OR</b>: Multiple search field values are evaluated using an OR relationship.</description></item>
        /// <item><description><b>AND</b>: Multiple search field values are evaluated using an AND relationship.<remarks>
        /// <para>You can call <a href="~~GetCloudAssetCriteria~~">GetCloudAssetCriteria</a> to query the supported search criteria.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;name\&quot;:\&quot;internetIp\&quot;,\&quot;value\&quot;:\&quot;192.168\&quot;,\&quot;logicalExp\&quot;:\&quot;OR\&quot;}]</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>The page number to return in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether to return sale-related data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Returns sale-related data.</description></item>
        /// <item><description><b>false</b>: Does not return sale-related data.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("IsSaleData")]
        [Validation(Required=false)]
        public bool? IsSaleData { get; set; }

        /// <summary>
        /// <para>The logical relationship between multiple search criteria. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OR</b>: Multiple search criteria are evaluated using an OR relationship.</description></item>
        /// <item><description><b>AND</b>: Multiple search criteria are evaluated using an AND relationship.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// <para>The maximum number of rows per page. Maximum value: 100. Default value: 20.</para>
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

        /// <summary>
        /// <para>The ID of the main account of the resource folder member accounts.</para>
        /// <remarks>
        /// <para>Call <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> to obtain this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

    }

}
