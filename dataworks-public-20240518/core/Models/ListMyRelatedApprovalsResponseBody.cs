// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMyRelatedApprovalsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMyRelatedApprovalsResponseBodyData Data { get; set; }
        public class ListMyRelatedApprovalsResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListMyRelatedApprovalsResponseBodyDataData> Data { get; set; }
            public class ListMyRelatedApprovalsResponseBodyDataData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1779695088000</para>
                /// </summary>
                [NameInMap("ApplicationTime")]
                [Validation(Required=false)]
                public long? ApplicationTime { get; set; }

                [NameInMap("Contents")]
                [Validation(Required=false)]
                public List<ListMyRelatedApprovalsResponseBodyDataDataContents> Contents { get; set; }
                public class ListMyRelatedApprovalsResponseBodyDataDataContents : TeaModel {
                    [NameInMap("AccessTypes")]
                    [Validation(Required=false)]
                    public List<string> AccessTypes { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("AuthMethod")]
                    [Validation(Required=false)]
                    public string AuthMethod { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-09-11 10:13:21</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MAXCOMPUTE</para>
                    /// </summary>
                    [NameInMap("DefSchema")]
                    [Validation(Required=false)]
                    public string DefSchema { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1779695088000</para>
                    /// </summary>
                    [NameInMap("ExpirationTime")]
                    [Validation(Required=false)]
                    public long? ExpirationTime { get; set; }

                    [NameInMap("FinalAccessTypes")]
                    [Validation(Required=false)]
                    public List<string> FinalAccessTypes { get; set; }

                    [NameInMap("Grantee")]
                    [Validation(Required=false)]
                    public ListMyRelatedApprovalsResponseBodyDataDataContentsGrantee Grantee { get; set; }
                    public class ListMyRelatedApprovalsResponseBodyDataDataContentsGrantee : TeaModel {
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
                    /// <para>1009516415</para>
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
                    public ListMyRelatedApprovalsResponseBodyDataDataContentsResource Resource { get; set; }
                    public class ListMyRelatedApprovalsResponseBodyDataDataContentsResource : TeaModel {
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

                        [NameInMap("MetaData")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> MetaData { get; set; }

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
                    /// <para>2024-03-05 18:24:13</para>
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
                /// <para>176906667488145</para>
                /// </summary>
                [NameInMap("ProcessInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>WAIT_APPROVAL</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eyJpZCI6NDU2fQ==</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0bc5df3a17****903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
