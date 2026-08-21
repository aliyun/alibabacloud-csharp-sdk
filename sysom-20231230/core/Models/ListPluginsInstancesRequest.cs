// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListPluginsInstancesRequest : TeaModel {
        [NameInMap("X-Debug-Id")]
        [Validation(Required=false)]
        public string XDebugId { get; set; }

        /// <summary>
        /// <para>The page number for pagination. This field indicates the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        /// <summary>
        /// <para>Filters instances by instance ID or instance name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bpxx</para>
        /// </summary>
        [NameInMap("instance_id_name")]
        [Validation(Required=false)]
        public string InstanceIdName { get; set; }

        /// <summary>
        /// <para>Filters instances by instance tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;app&quot;,&quot;value&quot;:&quot;sysom-aliyun-com&quot;}</para>
        /// </summary>
        [NameInMap("instance_tag")]
        [Validation(Required=false)]
        public string InstanceTag { get; set; }

        /// <summary>
        /// <para>Filters instances by plugin installation status.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>install</para>
        /// </summary>
        [NameInMap("operation_type")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies the agent ID to filter the instance list for the specified agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74a86327-3170-412c-8e67-da3389ec56a9</para>
        /// </summary>
        [NameInMap("plugin_id")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>Filters instances by region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("x-sysom-invoke-source")]
        [Validation(Required=false)]
        public string XSysomInvokeSource { get; set; }

    }

}
