// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSynchronizationJobStatusListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter will be removed in the future.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The <b>ClientToken</b> parameter can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe63****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the data synchronization instances. The value is a JSON array. You can call the <a href="https://help.aliyun.com/document_detail/49454.html">DescribeSynchronizationJobs</a> operation to query the instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;dtsexjk1alb116****&quot;,&quot;dtskfq1149w254****&quot;]</para>
        /// </summary>
        [NameInMap("SynchronizationJobIdListJsonStr")]
        [Validation(Required=false)]
        public string SynchronizationJobIdListJsonStr { get; set; }

    }

}
