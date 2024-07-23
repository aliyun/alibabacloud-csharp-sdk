// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListScenesResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B8987BF7-6028-5B17-80E0-251B7BD67BBA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Scenes")]
        [Validation(Required=false)]
        public List<ListScenesResponseBodyScenes> Scenes { get; set; }
        public class ListScenesResponseBodyScenes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>This is a test.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Flows")]
            [Validation(Required=false)]
            public List<ListScenesResponseBodyScenesFlows> Flows { get; set; }
            public class ListScenesResponseBodyScenesFlows : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>liuliang1</para>
                /// </summary>
                [NameInMap("FlowCode")]
                [Validation(Required=false)]
                public string FlowCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>流量1</para>
                /// </summary>
                [NameInMap("FlowName")]
                [Validation(Required=false)]
                public string FlowName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>scene1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
