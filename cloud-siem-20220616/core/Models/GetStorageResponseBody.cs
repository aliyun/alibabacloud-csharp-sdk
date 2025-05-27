// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class GetStorageResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the storage.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetStorageResponseBodyData Data { get; set; }
        public class GetStorageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the storage region can be changed for once. Default value: false Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CanOperate")]
            [Validation(Required=false)]
            public bool? CanOperate { get; set; }

            /// <summary>
            /// <para>Indicates whether the storage region can be changed. Default value: false Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisplayRegion")]
            [Validation(Required=false)]
            public bool? DisplayRegion { get; set; }

            /// <summary>
            /// <para>The region where the data is stored.</para>
            /// <para>If the data management center is <b>cn-hangzhou</b>, the default value of <b>Region</b> is cn-shanghai, which specifies the China (Shanghai) region. If the data management center is <b>ap-southeast-1</b>, the default value of <b>Region</b> is ap-southeast-1, which specifies the Singapore region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The storage period of logs. Unit: day. Default value: 180. Valid values: 30 to 3000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>97A31C3A-3F9F-5866-8979-5159E3DC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
