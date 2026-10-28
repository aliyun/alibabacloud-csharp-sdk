// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetSceneResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of flows.</para>
        /// </summary>
        [NameInMap("Flows")]
        [Validation(Required=false)]
        public List<GetSceneResponseBodyFlows> Flows { get; set; }
        public class GetSceneResponseBodyFlows : TeaModel {
            /// <summary>
            /// <para>The code of the flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liuliang1</para>
            /// </summary>
            [NameInMap("FlowCode")]
            [Validation(Required=false)]
            public string FlowCode { get; set; }

            /// <summary>
            /// <para>The name of the flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Flow 1</para>
            /// </summary>
            [NameInMap("FlowName")]
            [Validation(Required=false)]
            public string FlowName { get; set; }

        }

        /// <summary>
        /// <para>The name of the scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scene1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B8987BF7-6028-5B17-80E0-251B7BD67BBA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
