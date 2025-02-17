// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetServerlessAppAuthDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Data details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServerlessAppAuthDetailResponseBodyData Data { get; set; }
        public class GetServerlessAppAuthDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c932b7a0***</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>Number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CoreCount")]
            [Validation(Required=false)]
            public int? CoreCount { get; set; }

            /// <summary>
            /// <para>Number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// <para>Whether authorization is bound. Values: </para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes</description></item>
            /// <item><description><b>false</b>: No</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsBind")]
            [Validation(Required=false)]
            public bool? IsBind { get; set; }

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
            /// <item><description><b>VUL</b>: Vulnerability repair module</description></item>
            /// <item><description><b>CSPM</b>: Cloud Security Posture Management module</description></item>
            /// <item><description><b>AGENTLESS</b>: Agentless detection module</description></item>
            /// <item><description><b>SERVERLESS</b>: Serverless security module</description></item>
            /// <item><description><b>CTDR</b>: Threat Detection and Response module</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SERVERLESS</para>
            /// </summary>
            [NameInMap("PostPaidModuleSwitch")]
            [Validation(Required=false)]
            public string PostPaidModuleSwitch { get; set; }

            /// <summary>
            /// <para>Post-paid activation time.</para>
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
            /// <para>101</para>
            /// </summary>
            [NameInMap("PostpaidInstanceId")]
            [Validation(Required=false)]
            public string PostpaidInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The ID of this call request, a unique identifier generated by Alibaba Cloud for the request, which can be used to troubleshoot and pinpoint issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30CBF632-109F-596F-97F2-451C8B2A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the API call was successful. Values: </para>
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
