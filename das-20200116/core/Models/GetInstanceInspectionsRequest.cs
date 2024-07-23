// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetInstanceInspectionsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <remarks>
        /// <para> The end time must be later than the start time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1655427625000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>Redis</b></description></item>
        /// <item><description><b>PolarDBMySQL</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The type of the instance on which the database is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RDS</b>: an Alibaba Cloud database instance.</description></item>
        /// <item><description><b>ECS</b>: an ECS instance on which a self-managed database is deployed.</description></item>
        /// <item><description><b>IDC</b>: a self-managed database instance that is not deployed on Alibaba Cloud.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The value IDC specifies that the instance is deployed in a data center.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("InstanceArea")]
        [Validation(Required=false)]
        public string InstanceArea { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer. Default value: 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2eil6npi****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The filter condition, which can be specified in one of the following formats:</para>
        /// <list type="bullet">
        /// <item><description>Specify the ID of a single instance in the {&quot;InstanceId&quot;:&quot;Instance ID&quot;} format.</description></item>
        /// <item><description>Specify the IDs of multiple instances in the {&quot;InstanceIds&quot;:[&quot;Instance ID1&quot;,&quot;Instance ID2&quot;]} format. Separate the instance IDs with commas (,).</description></item>
        /// <item><description>Specify the region in which the instance resides in the {&quot;region&quot;:&quot;Region of the instance&quot;} format.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;InstanceId&quot;:&quot;rm-bp10usoc1erj7****&quot;}</para>
        /// </summary>
        [NameInMap("SearchMap")]
        [Validation(Required=false)]
        public string SearchMap { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1655416825000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
