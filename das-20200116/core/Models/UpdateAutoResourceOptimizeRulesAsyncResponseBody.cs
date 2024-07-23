// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class UpdateAutoResourceOptimizeRulesAsyncResponseBody : TeaModel {
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
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateAutoResourceOptimizeRulesAsyncResponseBodyData Data { get; set; }
        public class UpdateAutoResourceOptimizeRulesAsyncResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the asynchronous request was complete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Complete")]
            [Validation(Required=false)]
            public bool? Complete { get; set; }

            /// <summary>
            /// <para>The returned data of the configuration.</para>
            /// <remarks>
            /// <para> The data is returned only if the value of isFinish is <b>true</b>. This value indicates that the asynchronous request is complete.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ConfigResponse")]
            [Validation(Required=false)]
            public UpdateAutoResourceOptimizeRulesAsyncResponseBodyDataConfigResponse ConfigResponse { get; set; }
            public class UpdateAutoResourceOptimizeRulesAsyncResponseBodyDataConfigResponse : TeaModel {
                /// <summary>
                /// <para>The number of database instances for which the parameters failed to be configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ConfigFailInstanceCount")]
                [Validation(Required=false)]
                public long? ConfigFailInstanceCount { get; set; }

                /// <summary>
                /// <para>The database instances for which the parameters failed to be configured.</para>
                /// </summary>
                [NameInMap("ConfigFailInstanceList")]
                [Validation(Required=false)]
                public List<UpdateAutoResourceOptimizeRulesAsyncResponseBodyDataConfigResponseConfigFailInstanceList> ConfigFailInstanceList { get; set; }
                public class UpdateAutoResourceOptimizeRulesAsyncResponseBodyDataConfigResponseConfigFailInstanceList : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the parameters are configured. Valid values:</para>
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
                    /// <para>Only Support DAS Pro High-availability Edition RDS MySQL 5.6, 5.7, 8.0 instance, and CPU cores &gt;= 4, innodb_file_per_table=ON</para>
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
                /// <para>The number of database instances for which the parameters are configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ConfigSuccessInstanceCount")]
                [Validation(Required=false)]
                public long? ConfigSuccessInstanceCount { get; set; }

                /// <summary>
                /// <para>The database instances for which the parameters are configured.</para>
                /// </summary>
                [NameInMap("ConfigSuccessInstanceList")]
                [Validation(Required=false)]
                public List<UpdateAutoResourceOptimizeRulesAsyncResponseBodyDataConfigResponseConfigSuccessInstanceList> ConfigSuccessInstanceList { get; set; }
                public class UpdateAutoResourceOptimizeRulesAsyncResponseBodyDataConfigResponseConfigSuccessInstanceList : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the parameters are configured. Valid values:</para>
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
            /// <para>Indicates whether the asynchronous request failed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Fail")]
            [Validation(Required=false)]
            public bool? Fail { get; set; }

            /// <summary>
            /// <para>Indicates whether the asynchronous request was complete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsFinish")]
            [Validation(Required=false)]
            public bool? IsFinish { get; set; }

            /// <summary>
            /// <para>The ID of the asynchronous request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>async__20ee808e72257f16a4fe024057ca****</para>
            /// </summary>
            [NameInMap("ResultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

            /// <summary>
            /// <para>The state of the asynchronous request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RUNNING</b></description></item>
            /// <item><description><b>SUCCESS</b></description></item>
            /// <item><description><b>FAIL</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The time when the asynchronous request was made. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1645668213000</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

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
        /// <para>9CB97BC4-6479-55D0-B9D0-EA925AFE****</para>
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
