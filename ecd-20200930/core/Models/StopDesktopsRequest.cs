// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class StopDesktopsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to create a snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CreateSnapshot")]
        [Validation(Required=false)]
        public string CreateSnapshot { get; set; }

        /// <summary>
        /// <para>The cloud computer IDs. You can specify 1 to 100 IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-7w78ozhjcwa3u****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a patch update when an update is ready. A value of true indicates that the patch update is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OsUpdate")]
        [Validation(Required=false)]
        public bool? OsUpdate { get; set; }

        /// <summary>
        /// <para>The patch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KB5082063</para>
        /// </summary>
        [NameInMap("PatchId")]
        [Validation(Required=false)]
        public string PatchId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The billing mode after the cloud computers are stopped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StopCharging</para>
        /// </summary>
        [NameInMap("StoppedMode")]
        [Validation(Required=false)]
        public string StoppedMode { get; set; }

    }

}
