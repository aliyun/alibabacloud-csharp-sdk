// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetServerlessAppAuthDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The data details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServerlessAppAuthDetailResponseBodyData Data { get; set; }
        public class GetServerlessAppAuthDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c932b7a0***</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CoreCount")]
            [Validation(Required=false)]
            public int? CoreCount { get; set; }

            /// <summary>
            /// <para>The number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the authorization is bound. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsBind")]
            [Validation(Required=false)]
            public bool? IsBind { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance uses pay-as-you-go billing. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsPostPaid")]
            [Validation(Required=false)]
            public bool? IsPostPaid { get; set; }

            /// <summary>
            /// <para>The serverless pay-as-you-go status. Valid values:</para>
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
            /// <item><description><b>VUL</b>: vulnerability management module</description></item>
            /// <item><description><b>CSPM</b>: Cloud Security Posture Management (CSPM) module</description></item>
            /// <item><description><b>AGENTLESS</b>: agentless detection module</description></item>
            /// <item><description><b>SERVERLESS</b>: serverless security module</description></item>
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
            /// <para>The time when pay-as-you-go billing was enabled.</para>
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
            /// <para>101</para>
            /// </summary>
            [NameInMap("PostpaidInstanceId")]
            [Validation(Required=false)]
            public string PostpaidInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30CBF632-109F-596F-97F2-451C8B2A****</para>
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
