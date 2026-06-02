// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appflow20230904.Models
{
    public class CreateFlowRequest : TeaModel {
        [NameInMap("FlowDesc")]
        [Validation(Required=false)]
        public string FlowDesc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>flow-647da8e366a74d1cab6e</para>
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        [NameInMap("FlowTemplate")]
        [Validation(Required=false)]
        public string FlowTemplate { get; set; }

        [NameInMap("LaunchStatus")]
        [Validation(Required=false)]
        public bool? LaunchStatus { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<CreateFlowRequestParameters> Parameters { get; set; }
        public class CreateFlowRequestParameters : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>dingdingAuthId</para>
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>uac-cdd8e1cfde534b4db482</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateFlowRequestTag> Tag { get; set; }
        public class CreateFlowRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tl-715d93e708b546b7b464</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
