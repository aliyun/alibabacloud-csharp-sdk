// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SourceLocation : TeaModel {
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
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-09-12T07:15:52Z</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-22T10:49:14Z</para>
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
