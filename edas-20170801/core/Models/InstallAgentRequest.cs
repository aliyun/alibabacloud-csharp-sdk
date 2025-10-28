// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InstallAgentRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b3e3f77b-462e-<b><b>-</b></b>-bec8727a4dc8</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>This parameter is discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DoAsync")]
        [Validation(Required=false)]
        public bool? DoAsync { get; set; }

        /// <summary>
        /// <para>The ID of the ECS instance. Separate multiple IDs with commas (,). Example: instanceId1,instanceId2.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ze7s2v0b789k60pk1af</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

    }

}
