// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class AddDevicesRequest : TeaModel {
        /// <summary>
        /// <para>The type of the client.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: hardware client.</description></item>
        /// <item><description>2: software client.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public int? ClientType { get; set; }

        /// <summary>
        /// <para>The IDs of the devices. You can specify up to 200 IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceIds")]
        [Validation(Required=false)]
        public List<string> DeviceIds { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the regions supported by WUYING Workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
