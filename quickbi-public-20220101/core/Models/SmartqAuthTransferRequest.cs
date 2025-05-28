// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class SmartqAuthTransferRequest : TeaModel {
        /// <summary>
        /// <para>Source user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASDHASD*************12EASDA</para>
        /// </summary>
        [NameInMap("OriginUserId")]
        [Validation(Required=false)]
        public string OriginUserId { get; set; }

        /// <summary>
        /// <para>Target user ID array, separated by English commas.</para>
        /// <remarks>
        /// <para>Warning: The number of user IDs cannot exceed 100.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12313***<em><b><b>dasfa,ASDASF</b></b></em>SDAFEEG</para>
        /// </summary>
        [NameInMap("TargetUserIds")]
        [Validation(Required=false)]
        public string TargetUserIds { get; set; }

    }

}
