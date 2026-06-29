// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListDataServicePublishedApisResponseBody : TeaModel {
        /// <summary>
        /// <para>Backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Paginated query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListDataServicePublishedApisResponseBodyPageResult PageResult { get; set; }
        public class ListDataServicePublishedApisResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>Paginated API list.</para>
            /// </summary>
            [NameInMap("ApiList")]
            [Validation(Required=false)]
            public List<ListDataServicePublishedApisResponseBodyPageResultApiList> ApiList { get; set; }
            public class ListDataServicePublishedApisResponseBodyPageResultApiList : TeaModel {
                /// <summary>
                /// <para>API ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1022</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public long? ApiId { get; set; }

                /// <summary>
                /// <para>API name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <para>Number of bound applications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AppCount")]
                [Validation(Required=false)]
                public int? AppCount { get; set; }

                /// <summary>
                /// <para>List of referenced application information.</para>
                /// </summary>
                [NameInMap("AppInfoList")]
                [Validation(Required=false)]
                public List<ListDataServicePublishedApisResponseBodyPageResultApiListAppInfoList> AppInfoList { get; set; }
                public class ListDataServicePublishedApisResponseBodyPageResultApiListAppInfoList : TeaModel {
                    /// <summary>
                    /// <para>Application ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10211</para>
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public int? AppId { get; set; }

                    /// <term><b>Obsolete</b></term>
                    /// 
                    /// <summary>
                    /// <para>Application key.</para>
                    /// <remarks>
                    /// <para>Notice: Deprecated. Use AppKeyStr instead.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200000000</para>
                    /// </summary>
                    [NameInMap("AppKey")]
                    [Validation(Required=false)]
                    [Obsolete]
                    public long? AppKey { get; set; }

                    /// <summary>
                    /// <para>Application key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>APP_200000000</para>
                    /// </summary>
                    [NameInMap("AppKeyStr")]
                    [Validation(Required=false)]
                    public string AppKeyStr { get; set; }

                    /// <summary>
                    /// <para>Application name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                }

                /// <summary>
                /// <para>Application status. Valid values: 0 (not all applied), 1 (applied), 2 (no app, need to apply for an app first).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ApplyStatus")]
                [Validation(Required=false)]
                public int? ApplyStatus { get; set; }

                /// <summary>
                /// <para>Number of calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21</para>
                /// </summary>
                [NameInMap("CallCount")]
                [Validation(Required=false)]
                public int? CallCount { get; set; }

                /// <summary>
                /// <para>Creation type. Valid values: 0 (custom mode), 1 (wizard mode), 2 (direct connection API).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CreateType")]
                [Validation(Required=false)]
                public int? CreateType { get; set; }

                /// <summary>
                /// <para>Custom update frequency content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 0/1 * * *</para>
                /// </summary>
                [NameInMap("CustomUpdateRate")]
                [Validation(Required=false)]
                public string CustomUpdateRate { get; set; }

                /// <summary>
                /// <para>Publish time. Time format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 08:00:00</para>
                /// </summary>
                [NameInMap("DeployTime")]
                [Validation(Required=false)]
                public string DeployTime { get; set; }

                /// <summary>
                /// <para>API description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test xx</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Call type. Valid values: 1 (synchronous), 2 (asynchronous).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ExecuteMode")]
                [Validation(Required=false)]
                public int? ExecuteMode { get; set; }

                /// <summary>
                /// <para>Group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>102131</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public int? GroupId { get; set; }

                /// <summary>
                /// <para>API group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>Service unit number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1022</para>
                /// </summary>
                [NameInMap("LogicUnitNo")]
                [Validation(Required=false)]
                public long? LogicUnitNo { get; set; }

                /// <summary>
                /// <para>Mode. Valid values: 0 (basic), 1 (dev_prod).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public int? Mode { get; set; }

                /// <summary>
                /// <para>Owner ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>Owner name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("OwnerUserName")]
                [Validation(Required=false)]
                public string OwnerUserName { get; set; }

                /// <summary>
                /// <para>Data service project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>102101</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public int? ProjectId { get; set; }

                /// <summary>
                /// <para>Service project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>Update frequency. Valid values: 0 (custom), 1 (daily), 2 (hourly), 3 (per minute).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UpdateRate")]
                [Validation(Required=false)]
                public int? UpdateRate { get; set; }

                /// <summary>
                /// <para>Modification time. Time format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 08:00:00</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>API version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>Total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>68</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
