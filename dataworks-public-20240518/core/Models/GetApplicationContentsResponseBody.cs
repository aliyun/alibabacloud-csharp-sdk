// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetApplicationContentsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetApplicationContentsResponseBodyData Data { get; set; }
        public class GetApplicationContentsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1779675618000</para>
            /// </summary>
            [NameInMap("ApplicationTime")]
            [Validation(Required=false)]
            public long? ApplicationTime { get; set; }

            [NameInMap("Contents")]
            [Validation(Required=false)]
            public List<GetApplicationContentsResponseBodyDataContents> Contents { get; set; }
            public class GetApplicationContentsResponseBodyDataContents : TeaModel {
                [NameInMap("AccessTypes")]
                [Validation(Required=false)]
                public List<string> AccessTypes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ranger</para>
                /// </summary>
                [NameInMap("AuthMethod")]
                [Validation(Required=false)]
                public string AuthMethod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1773972024000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MaxCompute</para>
                /// </summary>
                [NameInMap("DefSchema")]
                [Validation(Required=false)]
                public string DefSchema { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1785835708000</para>
                /// </summary>
                [NameInMap("ExpirationTime")]
                [Validation(Required=false)]
                public long? ExpirationTime { get; set; }

                [NameInMap("FinalAccessTypes")]
                [Validation(Required=false)]
                public List<string> FinalAccessTypes { get; set; }

                [NameInMap("Grantee")]
                [Validation(Required=false)]
                public GetApplicationContentsResponseBodyDataContentsGrantee Grantee { get; set; }
                public class GetApplicationContentsResponseBodyDataContentsGrantee : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ROLE_3133343434</para>
                    /// </summary>
                    [NameInMap("PrincipalId")]
                    [Validation(Required=false)]
                    public string PrincipalId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>RamRole</para>
                    /// </summary>
                    [NameInMap("PrincipalType")]
                    [Validation(Required=false)]
                    public string PrincipalType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Y9H7AKFmjhWzLYdZNDZA5</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>777799223</para>
                /// </summary>
                [NameInMap("ProcessInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                [NameInMap("Resource")]
                [Validation(Required=false)]
                public GetApplicationContentsResponseBodyDataContentsResource Resource { get; set; }
                public class GetApplicationContentsResponseBodyDataContentsResource : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MaxCompute</para>
                    /// </summary>
                    [NameInMap("DefSchema")]
                    [Validation(Required=false)]
                    public string DefSchema { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>v1.0.0</para>
                    /// </summary>
                    [NameInMap("DefVersion")]
                    [Validation(Required=false)]
                    public string DefVersion { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;{\&quot;schema\&quot;:\&quot;default\&quot;,\&quot;threeTierModel\&quot;:false,\&quot;workspace\&quot;:\&quot;449656\&quot;,\&quot;project\&quot;:\&quot;sync_destination\&quot;,\&quot;table\&quot;:\&quot;order_table\&quot;,\&quot;tenant\&quot;:\&quot;524997424564736\&quot;}&quot;</para>
                    /// </summary>
                    [NameInMap("MetaData")]
                    [Validation(Required=false)]
                    public string MetaData { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>table</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>WAIT_APPROVAL</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>69973837489</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1773972024000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("DefSchema")]
            [Validation(Required=false)]
            public string DefSchema { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>332066440109224007</para>
            /// </summary>
            [NameInMap("ProcessInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WaitApproval</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>34267E2E-0335-1A60-A1F0-ADA530890CBA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
