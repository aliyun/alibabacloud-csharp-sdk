// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class GetStorageResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the storage settings.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetStorageResponseBodyData Data { get; set; }
        public class GetStorageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether you can change the storage region. You can change the storage region only once. The default value is false. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: You can change the storage region.</para>
            /// </description></item>
            /// <item><description><para>false: You cannot change the storage region.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CanOperate")]
            [Validation(Required=false)]
            public bool? CanOperate { get; set; }

            /// <summary>
            /// <para>Indicates whether you have permission to change the storage region. The default value is false. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: You have permission.</para>
            /// </description></item>
            /// <item><description><para>false: You do not have permission.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisplayRegion")]
            [Validation(Required=false)]
            public bool? DisplayRegion { get; set; }

            /// <summary>
            /// <para>The storage region.</para>
            /// <para>If the Data Management hub is in the <b>cn-hangzhou</b> region, the default value of <b>Region</b> is \<c>cn-shanghai\\</c>. If the Data Management hub is in the <b>ap-southeast-1</b> region, the default value of <b>Region</b> is \<c>ap-southeast-1\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The storage duration in days. The default value is 180. The value must be an integer from 30 to 3000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>97A31C3A-3F9F-5866-8979-5159E3DC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
