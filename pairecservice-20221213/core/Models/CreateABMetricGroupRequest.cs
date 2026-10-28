// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateABMetricGroupRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the AB test metrics, separated by commas.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("ABMetricIds")]
        [Validation(Required=false)]
        public string ABMetricIds { get; set; }

        /// <summary>
        /// <para>The description of the metric group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Traffic-related metrics</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Instance ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a> operation to obtain instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-test1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the metric group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>visits</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether the metric group is real-time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Realtime")]
        [Validation(Required=false)]
        public bool? Realtime { get; set; }

        /// <summary>
        /// <para>The ID of the scene. You can call the <a href="https://help.aliyun.com/document_detail/2402581.html">ListScenes</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

    }

}
