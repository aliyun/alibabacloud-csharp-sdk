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

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribePreCheckProgressListResponseBodyItems Items { get; set; }
        public class DescribePreCheckProgressListResponseBodyItems : TeaModel {
            [NameInMap("PreCheckProgressDetail")]
            [Validation(Required=false)]
            public List<DescribePreCheckProgressListResponseBodyItemsPreCheckProgressDetail> PreCheckProgressDetail { get; set; }
            public class DescribePreCheckProgressListResponseBodyItemsPreCheckProgressDetail : TeaModel {
                [NameInMap("BootTime")]
                [Validation(Required=false)]
                public long? BootTime { get; set; }

                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("Names")]
                [Validation(Required=false)]
                public string Names { get; set; }

                [NameInMap("OrderNum")]
                [Validation(Required=false)]
                public string OrderNum { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// <para>The precheck progress. The value ranges from 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C4A45FE1-A903-470D-B113-F12A4DF942AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The precheck status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>running</b>: The precheck is in progress.</para>
        /// </description></item>
        /// <item><description><para><b>failed</b>: The precheck failed.</para>
        /// </description></item>
        /// <item><description><para><b>finish</b>: The precheck is complete.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>finish</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
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
