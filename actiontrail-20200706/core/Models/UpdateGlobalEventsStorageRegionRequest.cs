// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class UpdateGlobalEventsStorageRegionRequest : TeaModel {
        /// <summary>
        /// <para>The region where you want to store global events.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ap-southeast-1</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>the Singapore region</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>cn-hangzhou</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>the China (Hangzhou) region</para>
        /// <!-- --></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-1</para>
        /// </summary>
        [NameInMap("StorageRegion")]
        [Validation(Required=false)]
        public string StorageRegion { get; set; }

    }

}
