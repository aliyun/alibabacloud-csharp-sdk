// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class ListPtsSceneResponseBody : TeaModel {
        /// <summary>
        /// <para>The system status code. If the request was successful, no data is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4001</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code. If the request was successful, no data is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message. If the request was successful, no data is returned.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6F2ED8-E31B-497F-85AB-C4E358A5F667</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned scenarios.</para>
        /// </summary>
        [NameInMap("SceneViewList")]
        [Validation(Required=false)]
        public List<ListPtsSceneResponseBodySceneViewList> SceneViewList { get; set; }
        public class ListPtsSceneResponseBodySceneViewList : TeaModel {
            /// <summary>
            /// <para>The time when the PTS scenario was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-26 15:28:39</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The scenario ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DFGVS3S</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <para>The scenario name.</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>The status of the PTS scenario. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>Draft WaitStart Debugging Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
