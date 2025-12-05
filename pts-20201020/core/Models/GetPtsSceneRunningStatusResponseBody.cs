// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetPtsSceneRunningStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The system status code. If the operation is successful, this parameter is not returned</para>
        /// 
        /// <b>Example:</b>
        /// <para>4001</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The time when the scenario was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-03-01 16:05:56</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The request status code. If the operation is successful, this parameter is not returned</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message. If the operation is successful, this parameter is not returned.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The last modification time of the scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-03-26 16:03:56</para>
        /// </summary>
        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC4E3177-6745-4925-B423-4E89VV34221A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The name of the scenario.</para>
        /// </summary>
        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        /// <summary>
        /// <para>The status of the scenario. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CREATED</description></item>
        /// <item><description>SYNCING</description></item>
        /// <item><description>SYNC_DONE</description></item>
        /// <item><description>UPLOADING</description></item>
        /// <item><description>UPLOADED</description></item>
        /// <item><description>PREPARING</description></item>
        /// <item><description>READY</description></item>
        /// <item><description>RUNNING</description></item>
        /// <item><description>STOPPING</description></item>
        /// <item><description>STOPPED</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful. Valid values:</para>
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
