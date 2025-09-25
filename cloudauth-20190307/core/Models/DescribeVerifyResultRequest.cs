// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyResultRequest : TeaModel {
        /// <summary>
        /// <para>Authentication ID. A unique ID that identifies an authentication task, not exceeding 64 characters. For a single authentication task, the system supports an unlimited number of submissions until the final authentication is successful and the task is completed. &gt; You need to use a different BizId for each new authentication task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39ecf51e-2f81-4dc5-90ee-ff86125b****</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Business scenario identifier for real-person authentication service</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FVBioOnlyTest</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

    }

}
