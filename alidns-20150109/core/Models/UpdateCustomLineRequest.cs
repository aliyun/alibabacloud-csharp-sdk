// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateCustomLineRequest : TeaModel {
        /// <summary>
        /// <para>The list of IP ranges. Use a hyphen (-) to separate the start and end IP addresses. Specify one IP segment per line. You can specify 1 to 50 IP ranges. To specify a single IP address, use the format IP1-IP1. The IP ranges cannot overlap.</para>
        /// </summary>
        [NameInMap("IpSegment")]
        [Validation(Required=false)]
        public List<UpdateCustomLineRequestIpSegment> IpSegment { get; set; }
        public class UpdateCustomLineRequestIpSegment : TeaModel {
            /// <summary>
            /// <para>The end IP address of the IP range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.XX.XX</para>
            /// </summary>
            [NameInMap("EndIp")]
            [Validation(Required=false)]
            public string EndIp { get; set; }

            /// <summary>
            /// <para>The start IP address of the IP range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.XX.XX</para>
            /// </summary>
            [NameInMap("StartIp")]
            [Validation(Required=false)]
            public string StartIp { get; set; }

        }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The unique ID of the custom line. You can call <a href="https://help.aliyun.com/document_detail/2355671.html">DescribeCustomLines</a> to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1*******</para>
        /// </summary>
        [NameInMap("LineId")]
        [Validation(Required=false)]
        public long? LineId { get; set; }

        /// <summary>
        /// <para>The name of the custom line. The name must be 1 to 20 characters long and can contain Chinese characters, letters, digits, hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>望京线路</para>
        /// </summary>
        [NameInMap("LineName")]
        [Validation(Required=false)]
        public string LineName { get; set; }

    }

}
