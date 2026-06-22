// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetServerlessAuthSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServerlessAuthSummaryResponseBodyData Data { get; set; }
        public class GetServerlessAuthSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic binding is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoBind")]
            [Validation(Required=false)]
            public int? AutoBind { get; set; }

            /// <summary>
            /// <para>Indicates whether a pre-binding asset configuration exists. Pre-binding refers to the asset binding configuration that is selected in advance during purchase. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: does not exist</description></item>
            /// <item><description><b>1</b>: exists.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HasPreBindSetting")]
            [Validation(Required=false)]
            public bool? HasPreBindSetting { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is a pay-as-you-go instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The instance is a pay-as-you-go instance.</description></item>
            /// <item><description><b>false</b>: The instance is not a pay-as-you-go instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsPostPaid")]
            [Validation(Required=false)]
            public bool? IsPostPaid { get; set; }

            /// <summary>
            /// <para>The Serverless pay-as-you-go status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: active</description></item>
            /// <item><description><b>false</b>: expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsServerlessPostPaidValid")]
            [Validation(Required=false)]
            public bool? IsServerlessPostPaidValid { get; set; }

            /// <summary>
            /// <para>The pay-as-you-go module switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VUL</b>: vulnerability fix module</description></item>
            /// <item><description><b>CSPM</b>: Cloud Security Posture Management (CSPM) module</description></item>
            /// <item><description><b>AGENTLESS</b>: agentless detection module</description></item>
            /// <item><description><b>SERVERLESS</b>: Serverless security module</description></item>
            /// <item><description><b>CTDR</b>: Cloud Threat Detection and Response (CTDR) module.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SERVERLESS</para>
            /// </summary>
            [NameInMap("PostPaidModuleSwitch")]
            [Validation(Required=false)]
            public string PostPaidModuleSwitch { get; set; }

            /// <summary>
            /// <para>The time when pay-as-you-go billing was enabled. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1655432638000</para>
            /// </summary>
            [NameInMap("PostPaidOpenTime")]
            [Validation(Required=false)]
            public long? PostPaidOpenTime { get; set; }

            /// <summary>
            /// <para>The pay-as-you-go instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: active</description></item>
            /// <item><description><b>2</b>: suspended due to overdue payment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PostPaidStatus")]
            [Validation(Required=false)]
            public int? PostPaidStatus { get; set; }

            /// <summary>
            /// <para>The pay-as-you-go instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-postpay-**</para>
            /// </summary>
            [NameInMap("PostpaidInstanceId")]
            [Validation(Required=false)]
            public string PostpaidInstanceId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The total number of bound applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalBindAppCount")]
            [Validation(Required=false)]
            public int? TotalBindAppCount { get; set; }

            /// <summary>
            /// <para>The total number of bound cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalBindCoreCount")]
            [Validation(Required=false)]
            public int? TotalBindCoreCount { get; set; }

            /// <summary>
            /// <para>The total number of bound instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalBindInstanceCount")]
            [Validation(Required=false)]
            public int? TotalBindInstanceCount { get; set; }

            /// <summary>
            /// <para>The total number of unbound applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalUnBindAppCount")]
            [Validation(Required=false)]
            public int? TotalUnBindAppCount { get; set; }

            /// <summary>
            /// <para>The total number of unbound cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalUnBindCoreCount")]
            [Validation(Required=false)]
            public int? TotalUnBindCoreCount { get; set; }

            /// <summary>
            /// <para>The total number of unbound instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalUnBindInstanceCount")]
            [Validation(Required=false)]
            public int? TotalUnBindInstanceCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8B6F758-BCD4-597A-8A2C-DA5A552C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
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
