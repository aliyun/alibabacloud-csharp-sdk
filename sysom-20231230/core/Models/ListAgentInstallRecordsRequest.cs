// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListAgentInstallRecordsRequest : TeaModel {
        /// <summary>
        /// <para>Current page number (starting from 1)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        /// <summary>
        /// <para>If this field is specified, the response filters the Agent installation status for the specified instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp118piqcio9tiwgh84b</para>
        /// </summary>
        [NameInMap("instance_id")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Page size</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>If this parameter is specified, the response filters the installation list for the specified Agent. It can be used together with the plugin_version parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74a86327-3170-412c-8e67-da3389ec56a9</para>
        /// </summary>
        [NameInMap("plugin_id")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>This parameter cannot be used alone. It must be used together with plugin_id to filter the installation list for a specified version of the specified Agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.4.0-1</para>
        /// </summary>
        [NameInMap("plugin_version")]
        [Validation(Required=false)]
        public string PluginVersion { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>Filter widget installation records by status</para>
        /// 
        /// <b>Example:</b>
        /// <para>Installed</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
