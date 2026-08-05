// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CancelMuteGroupUserRequest : TeaModel {
        /// <summary>
        /// <para>Interactive Messages application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VKL3***</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>System message diffusion type, values:</para>
        /// <list type="bullet">
        /// <item><description>0 (default): No diffusion.</description></item>
        /// <item><description>1: Diffusion to specified users.</description></item>
        /// <item><description>2: Diffusion to the group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BroadCastType")]
        [Validation(Required=false)]
        public int? BroadCastType { get; set; }

        /// <summary>
        /// <para>User ID group.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CancelMuteUserList")]
        [Validation(Required=false)]
        public List<string> CancelMuteUserList { get; set; }

        /// <summary>
        /// <para>Message group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE35-****-T95F</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>Operator\&quot;s user ID.</para>
        /// <remarks>
        /// <para>This parameter must be filled and the user must be the creator of the group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>de1**a0</para>
        /// </summary>
        [NameInMap("OperatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

    }

}
