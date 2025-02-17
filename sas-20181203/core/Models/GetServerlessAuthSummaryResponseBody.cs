// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetServerlessAuthSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned data details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServerlessAuthSummaryResponseBodyData Data { get; set; }
        public class GetServerlessAuthSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Enable auto-binding. Values: </para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Disabled</description></item>
            /// <item><description><b>1</b>: Enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoBind")]
            [Validation(Required=false)]
            public int? AutoBind { get; set; }

            /// <summary>
            /// <para>Indicates whether there is a pre-bound asset configuration. Pre-binding refers to the asset binding configuration selected in advance at the time of purchase. The values are: - <b>0</b>: No - <b>1</b>: Yes</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HasPreBindSetting")]
            [Validation(Required=false)]
            public bool? HasPreBindSetting { get; set; }

            /// <summary>
            /// <para>Whether it is a post-paid instance. Values: </para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes</description></item>
            /// <item><description><b>false</b>: No</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsPostPaid")]
            [Validation(Required=false)]
            public bool? IsPostPaid { get; set; }

            /// <summary>
            /// <para>Serverless post-paid status. Values: </para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Active</description></item>
            /// <item><description><b>false</b>: Expired</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsServerlessPostPaidValid")]
            [Validation(Required=false)]
            public bool? IsServerlessPostPaidValid { get; set; }

            /// <summary>
            /// <para>Pay-as-you-go module switch. Values: </para>
            /// <list type="bullet">
            /// <item><description><b>VUL</b>: Vulnerability Repair Module</description></item>
            /// <item><description><b>CSPM</b>: Cloud Security Posture Management Module</description></item>
            /// <item><description><b>AGENTLESS</b>: Agentless Detection Module</description></item>
            /// <item><description><b>SERVERLESS</b>: Serverless Security Module</description></item>
            /// <item><description><b>CTDR</b>: Threat Analysis and Response Module</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SERVERLESS</para>
            /// </summary>
            [NameInMap("PostPaidModuleSwitch")]
            [Validation(Required=false)]
            public string PostPaidModuleSwitch { get; set; }

            /// <summary>
            /// <para>Post-paid activation time. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1655432638000</para>
            /// </summary>
            [NameInMap("PostPaidOpenTime")]
            [Validation(Required=false)]
            public long? PostPaidOpenTime { get; set; }

            /// <summary>
            /// <para>Post-paid instance status. Values: </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Active</description></item>
            /// <item><description><b>2</b>: Suspended due to unpaid bills</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PostPaidStatus")]
            [Validation(Required=false)]
            public int? PostPaidStatus { get; set; }

            /// <summary>
            /// <para>Post-paid instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-postpay-**</para>
            /// </summary>
            [NameInMap("PostpaidInstanceId")]
            [Validation(Required=false)]
            public string PostpaidInstanceId { get; set; }

            /// <summary>
            /// <para>Region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Total number of bound applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalBindAppCount")]
            [Validation(Required=false)]
            public int? TotalBindAppCount { get; set; }

            /// <summary>
            /// <para>Total number of bound cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalBindCoreCount")]
            [Validation(Required=false)]
            public int? TotalBindCoreCount { get; set; }

            /// <summary>
            /// <para>Total number of bound instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalBindInstanceCount")]
            [Validation(Required=false)]
            public int? TotalBindInstanceCount { get; set; }

            /// <summary>
            /// <para>Total number of unbound applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalUnBindAppCount")]
            [Validation(Required=false)]
            public int? TotalUnBindAppCount { get; set; }

            /// <summary>
            /// <para>Total number of unbound cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalUnBindCoreCount")]
            [Validation(Required=false)]
            public int? TotalUnBindCoreCount { get; set; }

            /// <summary>
            /// <para>Total number of unbound instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalUnBindInstanceCount")]
            [Validation(Required=false)]
            public int? TotalUnBindInstanceCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of this request, which is a unique identifier generated by Alibaba Cloud for this request. It can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8B6F758-BCD4-597A-8A2C-DA5A552C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Success</description></item>
        /// <item><description><b>false</b>: Failure</description></item>
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
