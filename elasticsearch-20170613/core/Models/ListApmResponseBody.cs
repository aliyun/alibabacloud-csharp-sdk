// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListApmResponseBody : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListApmResponseBodyHeaders Headers { get; set; }
        public class ListApmResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public long? XTotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>080D3399-76CF-519D-A540-2C44BC056EB7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListApmResponseBodyResult> Result { get; set; }
        public class ListApmResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-11-16T07:15:51.967Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("deployedReplica")]
            [Validation(Required=false)]
            public long? DeployedReplica { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>APMtest</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>apm-cn-i7m2fuae****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public long? NodeAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>es-cn-i7m2fsfhc001x****</para>
            /// </summary>
            [NameInMap("outputES")]
            [Validation(Required=false)]
            public string OutputES { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>elastic</para>
            /// </summary>
            [NameInMap("outputESUserName")]
            [Validation(Required=false)]
            public string OutputESUserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>133071096032****</para>
            /// </summary>
            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>postpaid</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("replica")]
            [Validation(Required=false)]
            public long? Replica { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>C1M2</para>
            /// </summary>
            [NameInMap("resourceSpec")]
            [Validation(Required=false)]
            public string ResourceSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7.10.2</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-bp1530vdhqkamm9s0****</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("vsArea")]
            [Validation(Required=false)]
            public string VsArea { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-bp1j1mql6r9g5vfb4****</para>
            /// </summary>
            [NameInMap("vswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

    }

}
