// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetInstanceDownStreamResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("InstanceRelationList")]
        [Validation(Required=false)]
        public List<GetInstanceDownStreamResponseBodyInstanceRelationList> InstanceRelationList { get; set; }
        public class GetInstanceDownStreamResponseBodyInstanceRelationList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DownStreamDepth")]
            [Validation(Required=false)]
            public int? DownStreamDepth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;a&quot;:&quot;x&quot;}</para>
            /// </summary>
            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }

            [NameInMap("FieldInstanceList")]
            [Validation(Required=false)]
            public List<GetInstanceDownStreamResponseBodyInstanceRelationListFieldInstanceList> FieldInstanceList { get; set; }
            public class GetInstanceDownStreamResponseBodyInstanceRelationListFieldInstanceList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>t_23211</para>
                /// </summary>
                [NameInMap("FieldInstanceId")]
                [Validation(Required=false)]
                public string FieldInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("RunStatus")]
                [Validation(Required=false)]
                public string RunStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OPTIONAL</para>
                /// </summary>
                [NameInMap("SelectStatus")]
                [Validation(Required=false)]
                public string SelectStatus { get; set; }

            }

            [NameInMap("InstanceInfo")]
            [Validation(Required=false)]
            public GetInstanceDownStreamResponseBodyInstanceRelationListInstanceInfo InstanceInfo { get; set; }
            public class GetInstanceDownStreamResponseBodyInstanceRelationListInstanceInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>t_232411</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DATA_PROCESS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("RunStatus")]
            [Validation(Required=false)]
            public string RunStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OPTIONAL</para>
            /// </summary>
            [NameInMap("SelectStatus")]
            [Validation(Required=false)]
            public string SelectStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FIELD_DELETED</para>
            /// </summary>
            [NameInMap("SelectStatusCause")]
            [Validation(Required=false)]
            public string SelectStatusCause { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
