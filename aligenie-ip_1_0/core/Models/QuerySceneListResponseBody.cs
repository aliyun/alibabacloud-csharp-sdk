// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class QuerySceneListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FAFCD152-4791-5F2F-B0BE-2DC06FD4F05B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<QuerySceneListResponseBodyResults> Results { get; set; }
        public class QuerySceneListResponseBodyResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://ailabsaicloudservice.alicdn.com/hotel/icon/changjingmoshi/shuimian.png">https://ailabsaicloudservice.alicdn.com/hotel/icon/changjingmoshi/shuimian.png</a></para>
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>73</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>external</para>
            /// </summary>
            [NameInMap("SceneSource")]
            [Validation(Required=false)]
            public string SceneSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SceneState")]
            [Validation(Required=false)]
            public int? SceneState { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>common</para>
            /// </summary>
            [NameInMap("SceneType")]
            [Validation(Required=false)]
            public string SceneType { get; set; }

            [NameInMap("TemplateInfoDTOList")]
            [Validation(Required=false)]
            public List<QuerySceneListResponseBodyResultsTemplateInfoDTOList> TemplateInfoDTOList { get; set; }
            public class QuerySceneListResponseBodyResultsTemplateInfoDTOList : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6962</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>101</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("UnavailableReason")]
            [Validation(Required=false)]
            public string UnavailableReason { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

    }

}
