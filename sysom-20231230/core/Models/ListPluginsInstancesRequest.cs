// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListPluginsInstancesRequest : TeaModel {
        /// <summary>
        /// <para>This field exists when paging is used and indicates the current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        /// <summary>
        /// <para>Filter by instance ID or instance name. Fuzzy query is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bpxx</para>
        /// </summary>
        [NameInMap("instance_id_name")]
        [Validation(Required=false)]
        public string InstanceIdName { get; set; }

        /// <summary>
        /// <para>Filter by instance tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;app&quot;,&quot;value&quot;:&quot;sysom-aliyun-com&quot;}</para>
        /// </summary>
        [NameInMap("instance_tag")]
        [Validation(Required=false)]
        public string InstanceTag { get; set; }

        /// <summary>
        /// <para>Filter instances by plugin installation status.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>install</para>
        /// </summary>
        [NameInMap("operation_type")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// <para>Page size. Default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>If this parameter is specified, the response filters and returns the instance list for the specified agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74a86327-3170-412c-8e67-da3389ec56a9</para>
        /// </summary>
        [NameInMap("plugin_id")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>Filter instances by area.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
