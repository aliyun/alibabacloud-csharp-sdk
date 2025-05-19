// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class NodeStatusListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InstanceIds is mandatory for this action.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("NodeStatusList")]
        [Validation(Required=false)]
        public NodeStatusListResponseBodyNodeStatusList NodeStatusList { get; set; }
        public class NodeStatusListResponseBodyNodeStatusList : TeaModel {
            [NameInMap("NodeStatus")]
            [Validation(Required=false)]
            public List<NodeStatusListResponseBodyNodeStatusListNodeStatus> NodeStatus { get; set; }
            public class NodeStatusListResponseBodyNodeStatusListNodeStatus : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoInstall")]
                [Validation(Required=false)]
                public bool? AutoInstall { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i-abcdefgh123456</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1BB8FE8E-9BBE-490F-82EC-BF70FB849D55</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
