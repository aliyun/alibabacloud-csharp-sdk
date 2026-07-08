// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListRenderingSessionsRequest : TeaModel {
        /// <summary>
        /// <para>Cloud application ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cap-b06b26edfhytbn b94a75ae1a79efc90eb</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Unique ID of the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ae7990f4-203d-494b-a5ea-e0babe9fa13d</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>Time range filter parameter. Represented in ISO8601 standard and must use UTC time, in the format yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-31T22:20:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Page number, starting from 1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of rows per page set for paged queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Cloud application patch ID.</para>
        /// <ol>
        /// <item><description>When you enter origin, only sessions that started the original version of the app are filtered.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>patch-03fa76e8e13a49b6a966b063d9d309b4</para>
        /// </summary>
        [NameInMap("PatchId")]
        [Validation(Required=false)]
        public string PatchId { get; set; }

        /// <summary>
        /// <para>Project ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project-422bc38dfgh5eb44149f135ef76304f63b</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>Cloud application service instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

        /// <summary>
        /// <para>Session ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>session-i205217481741918129226</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Time range filter parameter. Represented in ISO8601 standard and must use UTC time, in the format yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-25T02:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Session state. Valid values:</para>
        /// <ol>
        /// <item><description><para>SessionStarting: The session is starting.</para>
        /// </description></item>
        /// <item><description><para>SessionStartSuspended: Session startup is paused. Retry by initiating start again.</para>
        /// </description></item>
        /// <item><description><para>SessionStarted: The session has started/is in use.</para>
        /// </description></item>
        /// <item><description><para>SessionStartFailed: Session startup failed.</para>
        /// </description></item>
        /// <item><description><para>SessionAbnormal: The session is abnormal after successful startup.</para>
        /// </description></item>
        /// <item><description><para>SessionStopping: The session is stopping.</para>
        /// </description></item>
        /// <item><description><para>SessionStopFailed: Session stop failed.</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>SessionStarting</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
