// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSecurityEventLogsRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions. A logical AND relationship exists between multiple filter conditions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public DescribeSecurityEventLogsRequestFilter Filter { get; set; }
        public class DescribeSecurityEventLogsRequestFilter : TeaModel {
            /// <summary>
            /// <para>A list of filter conditions. Each node describes a filter condition.</para>
            /// </summary>
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<DescribeSecurityEventLogsRequestFilterConditions> Conditions { get; set; }
            public class DescribeSecurityEventLogsRequestFilterConditions : TeaModel {
                /// <summary>
                /// <para>The name of the field to filter. This operation supports all fields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>matched_host</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eq</para>
                /// </summary>
                [NameInMap("OpValue")]
                [Validation(Required=false)]
                public string OpValue { get; set; }

                /// <summary>
                /// <para>The filter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.waf-top</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public object Values { get; set; }

            }

            /// <summary>
            /// <para>The time range to query.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DateRange")]
            [Validation(Required=false)]
            public DescribeSecurityEventLogsRequestFilterDateRange DateRange { get; set; }
            public class DescribeSecurityEventLogsRequestFilterDateRange : TeaModel {
                /// <summary>
                /// <para>The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888600</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public long? EndDate { get; set; }

                /// <summary>
                /// <para>The start of the time range to query. The time range cannot exceed the last 30 days. The value is a UNIX timestamp. Unit: seconds.</para>
                /// <remarks>
                /// <para>The start time must be within the last 30 days from the current time.</para>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888000</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public long? StartDate { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_cdnsdf3****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number to return for a paged query. The default value is <b>1</b>, which indicates the first page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query. The maximum value is <b>100</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region of the WAF instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}
