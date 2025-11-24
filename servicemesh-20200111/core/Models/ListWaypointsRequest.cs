// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class ListWaypointsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster on the data plane.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ce3c25e247da24f3aab9b7edfae83****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Used in conjunction with Limit, it is used to query waypoints starting from a specified offset. When calling for the first time, no need to care abount it. If the Continue in the returned result is not empty, it means that there is still data that has not been returned, and you need to continue the call with the returned Continue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJ2IjoibWV0YS5rOHMuaW8vdjEiLCJydiI6MjY4Njc5Miwic3RhcnQiOiJkZWZhdWx0L2Jvb2tpbmZvLXByb2R1Y3RwYWdlXHUwMDAwIn0</para>
        /// </summary>
        [NameInMap("Continue")]
        [Validation(Required=false)]
        public string Continue { get; set; }

        /// <summary>
        /// <para>Limit the number of waypoints returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>Waypoint which you want to get. If empty, return all waypoints.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bookinfo-productpage</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The Service Mesh (ASM) instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c08ba3fd1e6484b0f8cc1ad8fe10d****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
