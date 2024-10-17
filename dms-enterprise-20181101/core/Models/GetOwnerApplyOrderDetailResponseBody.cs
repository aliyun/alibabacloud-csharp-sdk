// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetOwnerApplyOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The details of the ticket.</para>
        /// </summary>
        [NameInMap("OwnerApplyOrderDetail")]
        [Validation(Required=false)]
        public GetOwnerApplyOrderDetailResponseBodyOwnerApplyOrderDetail OwnerApplyOrderDetail { get; set; }
        public class GetOwnerApplyOrderDetailResponseBodyOwnerApplyOrderDetail : TeaModel {
            /// <summary>
            /// <para>The type of the submitted ticket. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INSTANCE</b>: the ticket that applies for the permissions to be an instance owner</description></item>
            /// <item><description><b>DB</b>: the ticket that applies for the permissions to be a database owner</description></item>
            /// <item><description><b>TABLE</b>: the ticket that applies for the permissions to be a table owner</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DB</para>
            /// </summary>
            [NameInMap("ApplyType")]
            [Validation(Required=false)]
            public string ApplyType { get; set; }

            /// <summary>
            /// <para>The details of the requested resource.</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<GetOwnerApplyOrderDetailResponseBodyOwnerApplyOrderDetailResources> Resources { get; set; }
            public class GetOwnerApplyOrderDetailResponseBodyOwnerApplyOrderDetailResources : TeaModel {
                /// <summary>
                /// <para>Indicates whether the database is a logical database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The instance is a logical database.</description></item>
                /// <item><description><b>false</b>: The instance is not a logical database.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// <para>The details of the resource.</para>
                /// </summary>
                [NameInMap("ResourceDetail")]
                [Validation(Required=false)]
                public GetOwnerApplyOrderDetailResponseBodyOwnerApplyOrderDetailResourcesResourceDetail ResourceDetail { get; set; }
                public class GetOwnerApplyOrderDetailResponseBodyOwnerApplyOrderDetailResourcesResourceDetail : TeaModel {
                    /// <summary>
                    /// <para>The type of the database engine.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MYSQL</para>
                    /// </summary>
                    [NameInMap("DbType")]
                    [Validation(Required=false)]
                    public string DbType { get; set; }

                    /// <summary>
                    /// <para>The type of the environment to which the instance belongs. For more information, see <a href="https://help.aliyun.com/document_detail/163309.html">Change the environment type of an instance</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PRODUCT</para>
                    /// </summary>
                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    /// <summary>
                    /// <para>The IDs of the original owners.</para>
                    /// </summary>
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<long?> OwnerIds { get; set; }

                    /// <summary>
                    /// <para>The nicknames of the owners.</para>
                    /// </summary>
                    [NameInMap("OwnerNickNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNickNames { get; set; }

                    /// <summary>
                    /// <para>The search name of the resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yuyang【test】</para>
                    /// </summary>
                    [NameInMap("SearchName")]
                    [Validation(Required=false)]
                    public string SearchName { get; set; }

                    /// <summary>
                    /// <para>The name of the table.</para>
                    /// <remarks>
                    /// <para>: This parameter is returned when you submit a Database-OWNER ticket.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

                /// <summary>
                /// <para>The ID of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public string TargetId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB784055-E8CB-4461-AB0B-483A1DA32BB5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
