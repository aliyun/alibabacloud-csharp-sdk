// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListDataServicePublishedApisResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paged query results.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListDataServicePublishedApisResponseBodyPageResult PageResult { get; set; }
        public class ListDataServicePublishedApisResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The paged API list.</para>
            /// </summary>
            [NameInMap("ApiList")]
            [Validation(Required=false)]
            public List<ListDataServicePublishedApisResponseBodyPageResultApiList> ApiList { get; set; }
            public class ListDataServicePublishedApisResponseBodyPageResultApiList : TeaModel {
                /// <summary>
                /// <para>The API code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1022</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public long? ApiId { get; set; }

                /// <summary>
                /// <para>The API name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <para>The number of bound applications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AppCount")]
                [Validation(Required=false)]
                public int? AppCount { get; set; }

                /// <summary>
                /// <para>The list of referenced applications.</para>
                /// </summary>
                [NameInMap("AppInfoList")]
                [Validation(Required=false)]
                public List<ListDataServicePublishedApisResponseBodyPageResultApiListAppInfoList> AppInfoList { get; set; }
                public class ListDataServicePublishedApisResponseBodyPageResultApiListAppInfoList : TeaModel {
                    /// <summary>
                    /// <para>The application ID.</para>
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
                    /// <para>The application key. <b>[Deprecated]</b> Use AppKeyStr instead.</para>
                    /// <remarks>
                    /// <para>Notice: <b>[Deprecated]</b> Use AppKeyStr instead.</notice></para>
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
                    /// <para>The application key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>APP_200000000</para>
                    /// </summary>
                    [NameInMap("AppKeyStr")]
                    [Validation(Required=false)]
                    public string AppKeyStr { get; set; }

                    /// <summary>
                    /// <para>The application name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                }

                /// <summary>
                /// <para>The application status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Not fully applied.</description></item>
                /// <item><description>1: Applied.</description></item>
                /// <item><description>2: No application. You must apply for an application first.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ApplyStatus")]
                [Validation(Required=false)]
                public int? ApplyStatus { get; set; }

                /// <summary>
                /// <para>The number of calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21</para>
                /// </summary>
                [NameInMap("CallCount")]
                [Validation(Required=false)]
                public int? CallCount { get; set; }

                /// <summary>
                /// <para>The creation type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Custom mode.</description></item>
                /// <item><description>1: Wizard mode.</description></item>
                /// <item><description>2: Direct API connection.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CreateType")]
                [Validation(Required=false)]
                public int? CreateType { get; set; }

                /// <summary>
                /// <para>The custom content for the update frequency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 0/1 * * *</para>
                /// </summary>
                [NameInMap("CustomUpdateRate")]
                [Validation(Required=false)]
                public string CustomUpdateRate { get; set; }

                /// <summary>
                /// <para>The publish time. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 08:00:00</para>
                /// </summary>
                [NameInMap("DeployTime")]
                [Validation(Required=false)]
                public string DeployTime { get; set; }

                /// <summary>
                /// <para>The API description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test xx</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The execution mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Synchronous.</description></item>
                /// <item><description>2: Asynchronous.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ExecuteMode")]
                [Validation(Required=false)]
                public int? ExecuteMode { get; set; }

                /// <summary>
                /// <para>The group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>102131</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public int? GroupId { get; set; }

                /// <summary>
                /// <para>The API group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The service unit number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1022</para>
                /// </summary>
                [NameInMap("LogicUnitNo")]
                [Validation(Required=false)]
                public long? LogicUnitNo { get; set; }

                /// <summary>
                /// <para>The mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: basic.</description></item>
                /// <item><description>1: dev_prod.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public int? Mode { get; set; }

                /// <summary>
                /// <para>The owner ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhang San</para>
                /// </summary>
                [NameInMap("OwnerUserName")]
                [Validation(Required=false)]
                public string OwnerUserName { get; set; }

                /// <summary>
                /// <para>The data service project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>102101</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public int? ProjectId { get; set; }

                /// <summary>
                /// <para>The service project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The update frequency. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Custom.</description></item>
                /// <item><description>1: Daily.</description></item>
                /// <item><description>2: Hourly.</description></item>
                /// <item><description>3: Every minute.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UpdateRate")]
                [Validation(Required=false)]
                public int? UpdateRate { get; set; }

                /// <summary>
                /// <para>The update time. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 08:00:00</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The API version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
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
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
