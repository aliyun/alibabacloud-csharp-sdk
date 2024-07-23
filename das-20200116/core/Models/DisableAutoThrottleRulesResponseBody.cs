// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DisableAutoThrottleRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DisableAutoThrottleRulesResponseBodyData Data { get; set; }
        public class DisableAutoThrottleRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of database instances for which the automatic SQL throttling feature failed to be disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ConfigFailInstanceCount")]
            [Validation(Required=false)]
            public long? ConfigFailInstanceCount { get; set; }

            /// <summary>
            /// <para>The database instances for which the automatic SQL throttling feature failed to be disabled.</para>
            /// </summary>
            [NameInMap("ConfigFailInstanceList")]
            [Validation(Required=false)]
            public List<DisableAutoThrottleRulesResponseBodyDataConfigFailInstanceList> ConfigFailInstanceList { get; set; }
            public class DisableAutoThrottleRulesResponseBodyDataConfigFailInstanceList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the automatic SQL throttling feature is disabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b></para>
                /// </description></item>
                /// <item><description><para><b>false</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ConfigSuccess")]
                [Validation(Required=false)]
                public bool? ConfigSuccess { get; set; }

                /// <summary>
                /// <para>The error message returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cannot found instance by rm-2ze9xrhze0709****</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The database instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-2ze9xrhze0709****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// <para>The number of database instances for which the automatic SQL throttling feature is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ConfigSuccessInstanceCount")]
            [Validation(Required=false)]
            public long? ConfigSuccessInstanceCount { get; set; }

            /// <summary>
            /// <para>The database instances for which the automatic SQL throttling feature is disabled.</para>
            /// </summary>
            [NameInMap("ConfigSuccessInstanceList")]
            [Validation(Required=false)]
            public List<DisableAutoThrottleRulesResponseBodyDataConfigSuccessInstanceList> ConfigSuccessInstanceList { get; set; }
            public class DisableAutoThrottleRulesResponseBodyDataConfigSuccessInstanceList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the automatic SQL throttling feature is disabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b></para>
                /// </description></item>
                /// <item><description><para><b>false</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ConfigSuccess")]
                [Validation(Required=false)]
                public bool? ConfigSuccess { get; set; }

                /// <summary>
                /// <para>The database instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-2ze8g2am97624****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// <para>The total number of database instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalInstanceCount")]
            [Validation(Required=false)]
            public long? TotalInstanceCount { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
