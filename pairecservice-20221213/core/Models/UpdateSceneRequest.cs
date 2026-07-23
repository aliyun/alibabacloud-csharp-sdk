// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateSceneRequest : TeaModel {
        /// <summary>
        /// <para>The scene description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The flows.</para>
        /// </summary>
        [NameInMap("Flows")]
        [Validation(Required=false)]
        public List<UpdateSceneRequestFlows> Flows { get; set; }
        public class UpdateSceneRequestFlows : TeaModel {
            /// <summary>
            /// <para>The flow code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liuliang1</para>
            /// </summary>
            [NameInMap("FlowCode")]
            [Validation(Required=false)]
            public string FlowCode { get; set; }

            /// <summary>
            /// <para>The flow name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>流量1</para>
            /// </summary>
            [NameInMap("FlowName")]
            [Validation(Required=false)]
            public string FlowName { get; set; }

        }

        /// <summary>
        /// <para>The instance ID. To obtain the ID, call the <c>ListInstances</c> API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-abcdefg1234</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The scene name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scene1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
