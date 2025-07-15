// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeAutoShowListTasksRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio for which you want to query scheduled tasks.</para>
        /// <remarks>
        /// <para> If the scheduled tasks were created by calling the <a href="https://help.aliyun.com/document_detail/2848056.html">InitializeAutoShowListTask</a> operation, check the value of the response parameter CasterId to obtain the ID. If you do not specify this parameter, the system queries all the scheduled tasks that belong to the user specified by the OwnerId parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>53200b81-b761-4c10-842a-a0726d97****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
