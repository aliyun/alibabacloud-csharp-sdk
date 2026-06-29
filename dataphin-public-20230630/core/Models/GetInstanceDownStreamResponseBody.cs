// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetInstanceDownStreamResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code. OK indicates a successful request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Downstream instances and dependency relationships.</para>
        /// </summary>
        [NameInMap("InstanceRelationList")]
        [Validation(Required=false)]
        public List<GetInstanceDownStreamResponseBodyInstanceRelationList> InstanceRelationList { get; set; }
        public class GetInstanceDownStreamResponseBodyInstanceRelationList : TeaModel {
            /// <summary>
            /// <para>Depth level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DownStreamDepth")]
            [Validation(Required=false)]
            public int? DownStreamDepth { get; set; }

            /// <summary>
            /// <para>Extended information of the node instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;a&quot;:&quot;x&quot;}</para>
            /// </summary>
            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }

            /// <summary>
            /// <para>Field instance list.</para>
            /// </summary>
            [NameInMap("FieldInstanceList")]
            [Validation(Required=false)]
            public List<GetInstanceDownStreamResponseBodyInstanceRelationListFieldInstanceList> FieldInstanceList { get; set; }
            public class GetInstanceDownStreamResponseBodyInstanceRelationListFieldInstanceList : TeaModel {
                /// <summary>
                /// <para>Field instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_23211</para>
                /// </summary>
                [NameInMap("FieldInstanceId")]
                [Validation(Required=false)]
                public string FieldInstanceId { get; set; }

                /// <summary>
                /// <para>Run status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("RunStatus")]
                [Validation(Required=false)]
                public string RunStatus { get; set; }

                /// <summary>
                /// <para>Selection status of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OPTIONAL</para>
                /// </summary>
                [NameInMap("SelectStatus")]
                [Validation(Required=false)]
                public string SelectStatus { get; set; }

            }

            /// <summary>
            /// <para>Instance information.</para>
            /// </summary>
            [NameInMap("InstanceInfo")]
            [Validation(Required=false)]
            public GetInstanceDownStreamResponseBodyInstanceRelationListInstanceInfo InstanceInfo { get; set; }
            public class GetInstanceDownStreamResponseBodyInstanceRelationListInstanceInfo : TeaModel {
                /// <summary>
                /// <para>Instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_232411</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx测试</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Node type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_PROCESS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Run status of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("RunStatus")]
            [Validation(Required=false)]
            public string RunStatus { get; set; }

            /// <summary>
            /// <para>Selection status of the instance, primarily used for logical fields.</para>
            /// <list type="bullet">
            /// <item><description>OPTIONAL: Optional.</description></item>
            /// <item><description>SELECTED: Required.</description></item>
            /// <item><description>DISABLE: Not selectable.</description></item>
            /// <item><description>GROUP_SELECTED: Select all or deselect all.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OPTIONAL</para>
            /// </summary>
            [NameInMap("SelectStatus")]
            [Validation(Required=false)]
            public string SelectStatus { get; set; }

            /// <summary>
            /// <para>Reason why the instance is selected.</para>
            /// <list type="bullet">
            /// <item><description>PK_CHANGE</description></item>
            /// <item><description>LOGIC_CHANGE</description></item>
            /// <item><description>RELATION</description></item>
            /// <item><description>BIZ_RELATIO</description></item>
            /// <item><description>MV_RELATION</description></item>
            /// <item><description>MODEL_REFRESH</description></item>
            /// <item><description>FIELD_DELETED</description></item>
            /// <item><description>FIELD_ADDED_NO_INSTANCE</description></item>
            /// <item><description>PERMISSION_DENY</description></item>
            /// <item><description>OUTSIDE_INCOMING</description></item>
            /// <item><description>INSTANCE_STATUS</description></item>
            /// <item><description>AFFECT_BY_UPSTREAM</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FIELD_DELETED</para>
            /// </summary>
            [NameInMap("SelectStatusCause")]
            [Validation(Required=false)]
            public string SelectStatusCause { get; set; }

        }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
