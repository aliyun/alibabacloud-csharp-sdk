// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListProductQuotasRequest : TeaModel {
        /// <summary>
        /// <para>The quota dimensions.</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<ListProductQuotasRequestDimensions> Dimensions { get; set; }
        public class ListProductQuotasRequestDimensions : TeaModel {
            /// <summary>
            /// <para>The key of the dimension.</para>
            /// <remarks>
            /// <para> The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>regionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the dimension.</para>
            /// <remarks>
            /// <para> The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The code of the dimension group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>entconsole_w1j3msbo2g</para>
        /// </summary>
        [NameInMap("GroupCode")]
        [Validation(Required=false)]
        public string GroupCode { get; set; }

        /// <summary>
        /// <para>The keyword that you want to use to search for the quotas.</para>
        /// <remarks>
        /// <para> This parameter is available only for quotas that belong to ECS Quotas by Instance Type. The keyword is used to match the values of <c>QuotaName</c> and <c>QuotaActionCode</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs-spec</para>
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// <para>The maximum number of records that can be returned for the query.</para>
        /// <para>Valid values: 1 to 100. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first and last requests.</description></item>
        /// <item><description>You must specify the token that is obtained from the previous query as the value of NextToken.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The abbreviation of the Alibaba Cloud service name.</para>
        /// <remarks>
        /// <para> To query the abbreviation of an Alibaba Cloud service name, call the <a href="https://help.aliyun.com/document_detail/440555.html">ListProducts</a> operation and check the value of the <c>ProductCode</c> parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs-spec</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The quota ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5.2xlarge</para>
        /// </summary>
        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        /// <summary>
        /// <para>The type of the quota.</para>
        /// <para>Default value: CommonQuota.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FlowControl: API rate limit</description></item>
        /// <item><description>WhiteListLabel: privilege</description></item>
        /// <item><description>CommonQuota: general quota</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FlowControl</para>
        /// </summary>
        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

        /// <summary>
        /// <para>The field based on which you want to sort the returned records.</para>
        /// <remarks>
        /// <para> This parameter is available only for quotas that belong to ECS Quotas by Instance Type. You can leave this parameter empty.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TOTAL: sorts the returned records based on the total quota.</description></item>
        /// <item><description>TIME: sorts the returned records based on the time when the quota was last modified.</description></item>
        /// <item><description>RESERVED: sorts the returned records based on the reserved quota.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TIME</para>
        /// </summary>
        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the returned records.</para>
        /// <remarks>
        /// <para> This parameter is available only for quotas that belong to ECS Quotas by Instance Type. You can leave this parameter empty.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Descending</description></item>
        /// <item><description>Ascending</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ascending</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

    }

}
