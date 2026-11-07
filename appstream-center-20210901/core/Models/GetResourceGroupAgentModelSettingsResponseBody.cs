// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetResourceGroupAgentModelSettingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of model settings for resource groups. One record is returned for each resource group ID specified in the request. If a resource group is not associated with a model group under the specified agent platform and provider, ModelTemplateId and ModelTemplateName are empty.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetResourceGroupAgentModelSettingsResponseBodyData> Data { get; set; }
        public class GetResourceGroupAgentModelSettingsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The model group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mt-xxxxx</para>
            /// </summary>
            [NameInMap("ModelTemplateId")]
            [Validation(Required=false)]
            public string ModelTemplateId { get; set; }

            /// <summary>
            /// <para>The model group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default model group</para>
            /// </summary>
            [NameInMap("ModelTemplateName")]
            [Validation(Required=false)]
            public string ModelTemplateName { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-xxxxx</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which uniquely identifies the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
