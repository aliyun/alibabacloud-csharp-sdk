// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class ListCallCenterProvidersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCallCenterProvidersResponseBodyData Data { get; set; }
        public class ListCallCenterProvidersResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Providers")]
            [Validation(Required=false)]
            public List<ListCallCenterProvidersResponseBodyDataProviders> Providers { get; set; }
            public class ListCallCenterProvidersResponseBodyDataProviders : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>153*********</para>
                /// </summary>
                [NameInMap("Destination")]
                [Validation(Required=false)]
                public string Destination { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>key1=value1</para>
                /// </summary>
                [NameInMap("Extras")]
                [Validation(Required=false)]
                public string Extras { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>36e9a4cd-a821-4f78-86fa-a9a4aefeea2e</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>010****</para>
                /// </summary>
                [NameInMap("Originator")]
                [Validation(Required=false)]
                public string Originator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxxxxxx</para>
                /// </summary>
                [NameInMap("ProviderId")]
                [Validation(Required=false)]
                public string ProviderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CCC</para>
                /// </summary>
                [NameInMap("ProviderType")]
                [Validation(Required=false)]
                public string ProviderType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("ReferTo")]
                [Validation(Required=false)]
                public string ReferTo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>trunk-xxx</para>
                /// </summary>
                [NameInMap("TrunkId")]
                [Validation(Required=false)]
                public string TrunkId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75BAAB9B-40B2-5FF5-A59A-7BCF8154C6EE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
