// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class ListOpenJMeterScenesResponseBody : TeaModel {
        /// <summary>
        /// <para>The system status code. If the request was successful, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code. If the request was successful, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The scenarios.</para>
        /// </summary>
        [NameInMap("JMeterScene")]
        [Validation(Required=false)]
        public List<ListOpenJMeterScenesResponseBodyJMeterScene> JMeterScene { get; set; }
        public class ListOpenJMeterScenesResponseBodyJMeterScene : TeaModel {
            /// <summary>
            /// <para>The stress testing duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10分钟</para>
            /// </summary>
            [NameInMap("DurationStr")]
            [Validation(Required=false)]
            public string DurationStr { get; set; }

            /// <summary>
            /// <para>The scenario ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DYYPZIH</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <para>The scenario name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>The status of the scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PREPARING: The scenario is being prepared.</description></item>
            /// <item><description>PREPARED: The scenario has been prepared.</description></item>
            /// <item><description>STARTING: The scenario is starting.</description></item>
            /// <item><description>RUNNING: The scenario is running.</description></item>
            /// <item><description>STOPPING: The scenario is being stopped.</description></item>
            /// <item><description>STOPPED: The scenario waits for startup</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STOPPED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The returned message. If the request was successful, this parameter is left empty.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of returned scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8E16480-15C1-555A-922F-B736A005E52D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of returned scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
