// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribePreCheckProgressListResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Param.NotFound</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter %s value is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of check items.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribePreCheckProgressListResponseBodyItems Items { get; set; }
        public class DescribePreCheckProgressListResponseBodyItems : TeaModel {
            [NameInMap("PreCheckProgressDetail")]
            [Validation(Required=false)]
            public List<DescribePreCheckProgressListResponseBodyItemsPreCheckProgressDetail> PreCheckProgressDetail { get; set; }
            public class DescribePreCheckProgressListResponseBodyItemsPreCheckProgressDetail : TeaModel {
                /// <summary>
                /// <para>The time when the check for the item started. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1583734969000</para>
                /// </summary>
                [NameInMap("BootTime")]
                [Validation(Required=false)]
                public long? BootTime { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>java.lang.RuntimeException: Could not find any schema ......</para>
                /// </summary>
                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                /// <summary>
                /// <para>The time when the check for the item was complete. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1583734969000</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <para>The name of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHECK_OTHER</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// <para>The ID of the job for the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>uvk8f6fxnq5s</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The name of the group to which the check item belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHECK_OTHER</para>
                /// </summary>
                [NameInMap("Names")]
                [Validation(Required=false)]
                public string Names { get; set; }

                /// <summary>
                /// <para>The sequence number of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("OrderNum")]
                [Validation(Required=false)]
                public string OrderNum { get; set; }

                /// <summary>
                /// <para>The state of the check for the item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>init</b>: The check for the item is being initialized.</description></item>
                /// <item><description><b>warning</b>: A warning is reported.</description></item>
                /// <item><description><b>catched</b>: An exception occurs.</description></item>
                /// <item><description><b>running</b>: The check for the item is in progress.</description></item>
                /// <item><description><b>failed</b>: The check for the item fails.</description></item>
                /// <item><description><b>finish</b>: The check for the item is completed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>warning</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// <para>The precheck progress. Valid values: 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C4A45FE1-A903-470D-B113-F12A4DF942AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the precheck. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>running</b>: The precheck is in progress.</description></item>
        /// <item><description><b>failed</b>: The precheck failed.</description></item>
        /// <item><description><b>finish</b>: The precheck is complete.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>failed</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
