// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeUserBuyStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeUserBuyStatusResponseBodyData Data { get; set; }
        public class DescribeUserBuyStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the current account can perform operations on threat analysis orders. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The account can purchase, upgrade, or downgrade threat analysis.</para>
            /// </description></item>
            /// <item><description><para>false: The account cannot perform operations on threat analysis orders.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanBuy")]
            [Validation(Required=false)]
            public bool? CanBuy { get; set; }

            /// <summary>
            /// <para>The purchased capacity of Simple Log Service (SLS) for threat analysis. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public int? Capacity { get; set; }

            /// <summary>
            /// <para>The number of days before threat analysis expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DurationDays")]
            [Validation(Required=false)]
            public long? DurationDays { get; set; }

            /// <summary>
            /// <para>The expiration time of threat analysis. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1669823999000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that purchased threat analysis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123XXXXXX</para>
            /// </summary>
            [NameInMap("MainUserId")]
            [Validation(Required=false)]
            public long? MainUserId { get; set; }

            /// <summary>
            /// <para>The name of the Alibaba Cloud account that purchased threat analysis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas_account_xxx</para>
            /// </summary>
            [NameInMap("MainUserName")]
            [Validation(Required=false)]
            public string MainUserName { get; set; }

            /// <summary>
            /// <para>The ID of the master account of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123XXXXXX</para>
            /// </summary>
            [NameInMap("MasterUserId")]
            [Validation(Required=false)]
            public long? MasterUserId { get; set; }

            /// <summary>
            /// <para>The display name of the master account of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rd_master_xxx</para>
            /// </summary>
            [NameInMap("MasterUserName")]
            [Validation(Required=false)]
            public string MasterUserName { get; set; }

            /// <summary>
            /// <para>The type of the current order.</para>
            /// <list type="bullet">
            /// <item><description><para>0: The order includes threat analysis traffic and capacity.</para>
            /// </description></item>
            /// <item><description><para>1: The order includes only threat analysis capacity.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RdOrder")]
            [Validation(Required=false)]
            public int? RdOrder { get; set; }

            /// <summary>
            /// <para>The ID of the Security Center instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-instance-xxxxx</para>
            /// </summary>
            [NameInMap("SasInstanceId")]
            [Validation(Required=false)]
            public string SasInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the currently logged-on Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123XXXXXX</para>
            /// </summary>
            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

            /// <summary>
            /// <para>The name of the currently logged-on Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas_account_xxx</para>
            /// </summary>
            [NameInMap("SubUserName")]
            [Validation(Required=false)]
            public string SubUserName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81D8EC0C-0804-51AD-8C38-17ED0BC74892</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
