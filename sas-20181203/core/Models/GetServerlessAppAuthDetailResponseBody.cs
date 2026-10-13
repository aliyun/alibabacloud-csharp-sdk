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
            /// <para>The ID of the application.</para>
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
            /// <para>Indicates whether the instance uses the pay-as-you-go billing method. Valid values:</para>
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
            /// <para>The pay-as-you-go status of the serverless application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Active.</description></item>
            /// <item><description><b>false</b>: Expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsServerlessPostPaidValid")]
            [Validation(Required=false)]
            public bool? IsServerlessPostPaidValid { get; set; }

            /// <summary>
            /// <para>The switch configuration for pay-as-you-go modules. This field returns a JSON-encoded string. Each property name represents a module, and the property value 0 indicates that the module is disabled, whereas 1 indicates that the module is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;AGENTLESS&quot;:1,&quot;CTDR&quot;:1,&quot;VUL&quot;:0,&quot;SERVERLESS&quot;:1}</para>
            /// </summary>
            [NameInMap("PostPaidModuleSwitch")]
            [Validation(Required=false)]
            public string PostPaidModuleSwitch { get; set; }

            /// <summary>
            /// <para>The time when the pay-as-you-go billing method was activated. The value is a UNIX timestamp in milliseconds.</para>
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
            /// <item><description><b>1</b>: Active.</description></item>
            /// <item><description><b>2</b>: Stopped due to overdue payment.</description></item>
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
        /// <para>The ID of the request. The ID is generated by Alibaba Cloud for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30CBF632-109F-596F-97F2-451C8B2A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
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
