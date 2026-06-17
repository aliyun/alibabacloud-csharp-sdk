// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListWorkspacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of workspace details.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListWorkspacesResponseBodyItems> Items { get; set; }
        public class ListWorkspacesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The list of API keys for the workspace.</para>
            /// </summary>
            [NameInMap("Apikeys")]
            [Validation(Required=false)]
            public List<ListWorkspacesResponseBodyItemsApikeys> Apikeys { get; set; }
            public class ListWorkspacesResponseBodyItemsApikeys : TeaModel {
                /// <summary>
                /// <para>The services authorized for the API key.</para>
                /// </summary>
                [NameInMap("AuthServices")]
                [Validation(Required=false)]
                public List<ListWorkspacesResponseBodyItemsApikeysAuthServices> AuthServices { get; set; }
                public class ListWorkspacesResponseBodyItemsApikeysAuthServices : TeaModel {
                    /// <summary>
                    /// <para>The service ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>agdb-eqxwj5tj5ojx</para>
                    /// </summary>
                    [NameInMap("ServiceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                    /// <summary>
                    /// <para>The service type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>memory</description></item>
                    /// <item><description>drama.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>drama</para>
                    /// </summary>
                    [NameInMap("ServiceType")]
                    [Validation(Required=false)]
                    public string ServiceType { get; set; }

                }

                /// <summary>
                /// <para>The creation time of the API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-03-09T02:26:48Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my api key</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api-xxxx</para>
                /// </summary>
                [NameInMap("KeyId")]
                [Validation(Required=false)]
                public string KeyId { get; set; }

                /// <summary>
                /// <para>The name of the API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-apikey</para>
                /// </summary>
                [NameInMap("KeyName")]
                [Validation(Required=false)]
                public string KeyName { get; set; }

                /// <summary>
                /// <para>The prefix of the API key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sk-xxxxxx</para>
                /// </summary>
                [NameInMap("KeyPrefix")]
                [Validation(Required=false)]
                public string KeyPrefix { get; set; }

            }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-09T04:54:08Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The services in the workspace.</para>
            /// </summary>
            [NameInMap("Services")]
            [Validation(Required=false)]
            public List<ListWorkspacesResponseBodyItemsServices> Services { get; set; }
            public class ListWorkspacesResponseBodyItemsServices : TeaModel {
                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-03-09T02:26:48Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The compute resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Cu")]
                [Validation(Required=false)]
                public string Cu { get; set; }

                /// <summary>
                /// <para>The expiration time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-26T16:00:00Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The billing type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>POSTPAY</b>: pay-as-you-go.</description></item>
                /// <item><description><b>PREPAY</b>: subscription.</description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>If this parameter is not specified, the default value is pay-as-you-go.</description></item>
                /// <item><description>In subscription billing mode, a discount is available when you purchase a duration of one year or longer. Select the billing type as needed.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>POSTPAY</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>[Deprecated].</para>
                /// 
                /// <b>Example:</b>
                /// <para>deprecated</para>
                /// </summary>
                [NameInMap("Plan")]
                [Validation(Required=false)]
                public string Plan { get; set; }

                /// <summary>
                /// <para>The service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agdb-xxxx</para>
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>The service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agdb-xxxx</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// <para>The service type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>memory</description></item>
                /// <item><description>drama.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>memory</para>
                /// </summary>
                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public string ServiceType { get; set; }

                /// <summary>
                /// <para>The service status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>creating: The service is being created.</description></item>
                /// <item><description>active: The service is running.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gp-ws-wkb4fp3j9u79ha</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// <para>The workspace name.</para>
            /// <list type="bullet">
            /// <item><description>Maximum length: 50.</description></item>
            /// <item><description>Must be unique.</description></item>
            /// <item><description>Special characters are not allowed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>anchashid8FocugQ.oxs.xaliyun.com/oxspopscand8FocugQ#</para>
            /// </summary>
            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to return. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
