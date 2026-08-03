// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeScenesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7EC26DF0-35AC-5F37-82B3-F5545D0A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of scenarios.</para>
        /// </summary>
        [NameInMap("SceneList")]
        [Validation(Required=false)]
        public List<DescribeScenesResponseBodySceneList> SceneList { get; set; }
        public class DescribeScenesResponseBodySceneList : TeaModel {
            /// <summary>
            /// <para>The description of the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Query access events for the primary and sub-accounts and access keys under various scenarios, such as access events occurrence, access without MFA authentication, and failed access attempts.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Account-related or AccessKey Pair-related Events</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sc-lpYrjKouRfy3MK-wteJW_Q</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <para>The identifier for the scenario category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>identity</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <para>The type of the scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
