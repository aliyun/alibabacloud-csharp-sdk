// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ReimageNodesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i15dfa12e8f27c44f4a006c2c8bb</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow skipping failed nodes. Default value: False.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IgnoreFailedNodeTasks")]
        [Validation(Required=false)]
        public bool? IgnoreFailedNodeTasks { get; set; }

        /// <summary>
        /// <para>The nodes.</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<ReimageNodesRequestNodes> Nodes { get; set; }
        public class ReimageNodesRequestNodes : TeaModel {
            /// <summary>
            /// <para>The hostname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>457db5ca-241d-11ed-9fd7-acde48001122</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>The system image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-8vbf8rpv2nn14y7oybjy</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The logon password.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("LoginPassword")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e01-cn-zvp2tgykr0b</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

        }

        /// <summary>
        /// <para>The user data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>#!/bin/sh
        /// echo &quot;Hello World. The time is now $(date -R)!&quot; | tee /root/userdata_test.txt</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
