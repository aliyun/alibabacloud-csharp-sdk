// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDataShareInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The state of data sharing. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>opening</b></description></item>
        /// <item><description><b>opened</b></description></item>
        /// <item><description><b>closing</b></description></item>
        /// <item><description><b>closed</b></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDataShareInstancesResponseBodyItems Items { get; set; }
        public class DescribeDataShareInstancesResponseBodyItems : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDataShareInstancesResponseBodyItemsDBInstance> DBInstance { get; set; }
            public class DescribeDataShareInstancesResponseBodyItemsDBInstance : TeaModel {
                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gp-bp***************</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The resource type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Serverless</b>: Serverless mode</description></item>
                /// <item><description><b>StorageElasic</b>: elastic storage mode</description></item>
                /// <item><description><b>Classic</b>: reserved storage mode</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Serverless</para>
                /// </summary>
                [NameInMap("DBInstanceMode")]
                [Validation(Required=false)]
                public string DBInstanceMode { get; set; }

                /// <summary>
                /// <para>The state of data sharing. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>opening</b>: Data sharing is being enabled.</description></item>
                /// <item><description><b>opened</b>: Data sharing is enabled.</description></item>
                /// <item><description><b>closing</b>: Data sharing is being disabled.</description></item>
                /// <item><description><b>closed</b>: Data sharing is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>opened</para>
                /// </summary>
                [NameInMap("DataShareStatus")]
                [Validation(Required=false)]
                public string DataShareStatus { get; set; }

                /// <summary>
                /// <para>The description of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gp-bp***************</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The region ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The zone ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-j</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D5**********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
