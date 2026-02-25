// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class RestartNodesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RestartNodeGroups")]
        [Validation(Required=false)]
        public List<RestartNodesRequestRestartNodeGroups> RestartNodeGroups { get; set; }
        public class RestartNodesRequestRestartNodeGroups : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("FastMode")]
            [Validation(Required=false)]
            public bool? FastMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ng-dcc7450e06a271b9</para>
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            [NameInMap("NodeIds")]
            [Validation(Required=false)]
            public List<string> NodeIds { get; set; }

        }

    }

}
