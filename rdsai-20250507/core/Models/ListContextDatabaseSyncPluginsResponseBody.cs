// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListContextDatabaseSyncPluginsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListContextDatabaseSyncPluginsResponseBodyData> Data { get; set; }
        public class ListContextDatabaseSyncPluginsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The authorization method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;kind&quot;:&quot;oauth&quot;,&quot;phases&quot;:[&quot;discovery&quot;]}</para>
            /// </summary>
            [NameInMap("Authorization")]
            [Validation(Required=false)]
            public string Authorization { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R&amp;D team DingTalk data source</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The icon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/icons/dingtalk.svg</para>
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <para>The plugin ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dingtalk</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The plugin type. This operation returns only plugins of the source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>source</para>
            /// </summary>
            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>The datasource config template (JSON character string, structure varies depending on the plugin).</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;hint&quot;:&quot;Select import scope&quot;,&quot;fields&quot;:[{&quot;key&quot;:&quot;folderIds&quot;,&quot;type&quot;:&quot;string-list&quot;,&quot;label&quot;:&quot;Folder / document scope&quot;}]}</para>
            /// </summary>
            [NameInMap("SourceConfig")]
            [Validation(Required=false)]
            public string SourceConfig { get; set; }

            /// <summary>
            /// <para>The version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
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
