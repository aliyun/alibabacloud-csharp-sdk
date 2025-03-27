// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class TestDataSourceConnectivityResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the connectivity test.</para>
        /// </summary>
        [NameInMap("Connectivity")]
        [Validation(Required=false)]
        public TestDataSourceConnectivityResponseBodyConnectivity Connectivity { get; set; }
        public class TestDataSourceConnectivityResponseBodyConnectivity : TeaModel {
            /// <summary>
            /// <para>The error message returned if the connectivity test fails. No such a message is returned if the connectivity test is successful.</para>
            /// </summary>
            [NameInMap("ConnectMessage")]
            [Validation(Required=false)]
            public string ConnectMessage { get; set; }

            /// <summary>
            /// <para>The result of the connectivity test. Valid values: Connectable: The network can be connected. ConfigError: The network can be connected, but the configurations are incorrect. Unreachable: The network cannot be connected. Unsupport: An error is reported due to other causes. For example, the desired resource group is being initialized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Connectable</para>
            /// </summary>
            [NameInMap("ConnectState")]
            [Validation(Required=false)]
            public string ConnectState { get; set; }

            /// <summary>
            /// <para>The detailed logs of each step in the connectivity test.</para>
            /// </summary>
            [NameInMap("DetailLogs")]
            [Validation(Required=false)]
            public List<TestDataSourceConnectivityResponseBodyConnectivityDetailLogs> DetailLogs { get; set; }
            public class TestDataSourceConnectivityResponseBodyConnectivityDetailLogs : TeaModel {
                /// <summary>
                /// <para>The code of the test item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>validate_input_parameters</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The end time of a step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1730217604002</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The name of the step.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The start time of a step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1730217600001</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4CDF7B72-020B-542A-8465-21CFFA81****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
