// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class TestDataSourceConnectivityResponseBody : TeaModel {
        [NameInMap("Connectivity")]
        [Validation(Required=false)]
        public TestDataSourceConnectivityResponseBodyConnectivity Connectivity { get; set; }
        public class TestDataSourceConnectivityResponseBodyConnectivity : TeaModel {
            [NameInMap("ConnectMessage")]
            [Validation(Required=false)]
            public string ConnectMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Connectable</para>
            /// </summary>
            [NameInMap("ConnectState")]
            [Validation(Required=false)]
            public string ConnectState { get; set; }

            [NameInMap("DetailLogs")]
            [Validation(Required=false)]
            public List<TestDataSourceConnectivityResponseBodyConnectivityDetailLogs> DetailLogs { get; set; }
            public class TestDataSourceConnectivityResponseBodyConnectivityDetailLogs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>validate_input_parameters</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1730217604002</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1730217600001</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4CDF7B72-020B-542A-8465-21CFFA81****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
