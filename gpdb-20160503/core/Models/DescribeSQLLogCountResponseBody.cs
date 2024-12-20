// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSQLLogCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-14T11:22Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeSQLLogCountResponseBodyItems> Items { get; set; }
        public class DescribeSQLLogCountResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gp-xxxxxxxx</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Details of the audit logs.</para>
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribeSQLLogCountResponseBodyItemsSeries> Series { get; set; }
            public class DescribeSQLLogCountResponseBodyItemsSeries : TeaModel {
                /// <summary>
                /// <para>Details of the audit logs.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<DescribeSQLLogCountResponseBodyItemsSeriesValues> Values { get; set; }
                public class DescribeSQLLogCountResponseBodyItemsSeriesValues : TeaModel {
                    /// <summary>
                    /// <para>The time when the audit logs were generated and the number of the audit logs.</para>
                    /// </summary>
                    [NameInMap("Point")]
                    [Validation(Required=false)]
                    public List<string> Point { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7565770E-7C45-462D-BA4A-8A**********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-12T11:22Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
