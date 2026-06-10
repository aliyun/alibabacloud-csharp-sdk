// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListInstancesEcsInfoListRequest : TeaModel {
        /// <summary>
        /// <para>Type of information to retrieve</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("info_type")]
        [Validation(Required=false)]
        public string InfoType { get; set; }

        /// <summary>
        /// <para>If this field is specified, the response filters and returns the Agent installation status for the specified instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp118piqcio9tiwgh84b</para>
        /// </summary>
        [NameInMap("instance_id")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Management status of the instance</para>
        /// 
        /// <b>Example:</b>
        /// <para>managed</para>
        /// </summary>
        [NameInMap("managed_type")]
        [Validation(Required=false)]
        public string ManagedType { get; set; }

        /// <summary>
        /// <para>If this parameter is specified, the response filters and returns the instance information list for the corresponding widget.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74a86327-3170-412c-8e67-da3389ec56a9</para>
        /// </summary>
        [NameInMap("plugin_id")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>Filter instances by area</para>
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
