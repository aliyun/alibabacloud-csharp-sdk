// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeApikeyAttributeResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeApikeyAttributeResponseBodyItems> Items { get; set; }
        public class DescribeApikeyAttributeResponseBodyItems : TeaModel {
            [NameInMap("Consumer")]
            [Validation(Required=false)]
            public DescribeApikeyAttributeResponseBodyItemsConsumer Consumer { get; set; }
            public class DescribeApikeyAttributeResponseBodyItemsConsumer : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cg-bq6rcdjp02vt</para>
                /// </summary>
                [NameInMap("ConsumerGroupId")]
                [Validation(Required=false)]
                public string ConsumerGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>c-71qh3pscbd3i</para>
                /// </summary>
                [NameInMap("ConsumerId")]
                [Validation(Required=false)]
                public string ConsumerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ConsumerTag")]
                [Validation(Required=false)]
                public string ConsumerTag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-07-18T07:32:30Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pg-2ze5n62ef4s165***</para>
                /// </summary>
                [NameInMap("GwClusterId")]
                [Validation(Required=false)]
                public string GwClusterId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-04-10T01:48:25Z</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("UsageStatistics")]
            [Validation(Required=false)]
            public List<DescribeApikeyAttributeResponseBodyItemsUsageStatistics> UsageStatistics { get; set; }
            public class DescribeApikeyAttributeResponseBodyItemsUsageStatistics : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>c-xxxxxx</para>
                /// </summary>
                [NameInMap("DimensionRefId")]
                [Validation(Required=false)]
                public string DimensionRefId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Consumer</para>
                /// </summary>
                [NameInMap("DimensionType")]
                [Validation(Required=false)]
                public string DimensionType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pg-bp1ln7w98yrhzz7i2</para>
                /// </summary>
                [NameInMap("GwClusterId")]
                [Validation(Required=false)]
                public string GwClusterId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MonthlyCacheToken")]
                [Validation(Required=false)]
                public string MonthlyCacheToken { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MonthlyCostPoints")]
                [Validation(Required=false)]
                public string MonthlyCostPoints { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MonthlyInputToken")]
                [Validation(Required=false)]
                public string MonthlyInputToken { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MonthlyOutputToken")]
                [Validation(Required=false)]
                public string MonthlyOutputToken { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MonthlyToken")]
                [Validation(Required=false)]
                public string MonthlyToken { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalCacheToken")]
                [Validation(Required=false)]
                public string TotalCacheToken { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalCostPoints")]
                [Validation(Required=false)]
                public string TotalCostPoints { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalInputToken")]
                [Validation(Required=false)]
                public string TotalInputToken { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalOutputToken")]
                [Validation(Required=false)]
                public string TotalOutputToken { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalToken")]
                [Validation(Required=false)]
                public string TotalToken { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F3322AFE-083E-4D77-A074-421301******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
