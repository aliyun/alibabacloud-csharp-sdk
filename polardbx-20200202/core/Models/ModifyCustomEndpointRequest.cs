// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class ModifyCustomEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the custom endpoint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cep-002</para>
        /// </summary>
        [NameInMap("CustomEndpointId")]
        [Validation(Required=false)]
        public string CustomEndpointId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mydatabase</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The name of the custom endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secondary-endpoint</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether a node automatically joins the cluster and starts providing services after it is added or recovered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NodeAutoEnter")]
        [Validation(Required=false)]
        public bool? NodeAutoEnter { get; set; }

        /// <summary>
        /// <para>The node IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>node3</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIds { get; set; }

        /// <summary>
        /// <para>The role of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>master</para>
        /// </summary>
        [NameInMap("NodeRole")]
        [Validation(Required=false)]
        public string NodeRole { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-zhangjiakou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
