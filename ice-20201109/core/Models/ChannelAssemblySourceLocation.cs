// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ChannelAssemblySourceLocation : TeaModel {
        /// <summary>
        /// <para>The ARN of the source location.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ims:mediaweaver:<regionId>:<UserId>:sourcelocation/MySourceLocation</para>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// <para>The base URL of the source location.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxxx.com">http://xxxx.com</a></para>
        /// </summary>
        [NameInMap("BaseUrl")]
        [Validation(Required=false)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// <para>The time when the source location was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-29T02:03:17Z</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The time when the source location was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-29T02:03:17Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The segment delivery server configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://segmentdelivery.com">http://segmentdelivery.com</a></para>
        /// </summary>
        [NameInMap("SegmentDeliveryConfigurations")]
        [Validation(Required=false)]
        public string SegmentDeliveryConfigurations { get; set; }

        /// <summary>
        /// <para>The name of the source location.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySourceLocation</para>
        /// </summary>
        [NameInMap("SourceLocationName")]
        [Validation(Required=false)]
        public string SourceLocationName { get; set; }

        /// <summary>
        /// <para>The status of the source location. 0: normal. 1: deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public int? State { get; set; }

    }

}
