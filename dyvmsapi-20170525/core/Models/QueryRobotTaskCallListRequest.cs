// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryRobotTaskCallListRequest : TeaModel {
        /// <summary>
        /// <para>The call result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>200002</b>: The line is busy.</description></item>
        /// <item><description><b>200005</b>: The called party cannot be connected.</description></item>
        /// <item><description><b>200010</b>: The phone of the called party is powered off.</description></item>
        /// <item><description><b>200011</b>: The called party is out of service.</description></item>
        /// <item><description><b>200012</b>: The call is lost.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200002</para>
        /// </summary>
        [NameInMap("CallResult")]
        [Validation(Required=false)]
        public string CallResult { get; set; }

        /// <summary>
        /// <para>The called number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1300****0000</para>
        /// </summary>
        [NameInMap("Called")]
        [Validation(Required=false)]
        public string Called { get; set; }

        /// <summary>
        /// <para>The minimum number of conversation rounds in the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DialogCountFrom")]
        [Validation(Required=false)]
        public string DialogCountFrom { get; set; }

        /// <summary>
        /// <para>The maximum number of conversation rounds in the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("DialogCountTo")]
        [Validation(Required=false)]
        public string DialogCountTo { get; set; }

        /// <summary>
        /// <para>The minimum call duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DurationFrom")]
        [Validation(Required=false)]
        public string DurationFrom { get; set; }

        /// <summary>
        /// <para>The maximum call duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("DurationTo")]
        [Validation(Required=false)]
        public string DurationTo { get; set; }

        /// <summary>
        /// <para>The party who hangs up. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: the called party.</description></item>
        /// <item><description><b>1</b>: the robot.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HangupDirection")]
        [Validation(Required=false)]
        public string HangupDirection { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The unique ID of the robocall task. You can call the <a href="https://help.aliyun.com/document_detail/393531.html">CreateRobotTask</a> operation to obtain the task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1045001****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
