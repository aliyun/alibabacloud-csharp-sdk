// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CarSceneQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The operation status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>未开启用车预订服务</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of car service scenario templates. An empty array [] is returned if no data exists.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public List<CarSceneQueryResponseBodyModule> Module { get; set; }
        public class CarSceneQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The scenario template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>travel</para>
            /// </summary>
            [NameInMap("scenarioTemplateId")]
            [Validation(Required=false)]
            public string ScenarioTemplateId { get; set; }

            /// <summary>
            /// <para>The scenario template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>差标用车</para>
            /// </summary>
            [NameInMap("scenarioTemplateName")]
            [Validation(Required=false)]
            public string ScenarioTemplateName { get; set; }

            /// <summary>
            /// <para>The scenario status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVATE</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the query was successful.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Successful.</para>
        /// </description></item>
        /// <item><description><para>false: Failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
