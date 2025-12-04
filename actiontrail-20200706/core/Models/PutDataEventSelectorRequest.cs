// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class PutDataEventSelectorRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;EventName&quot;:{&quot;Equals&quot;:[&quot;GetObject&quot;,&quot;CopyObject&quot;,&quot;AppendObject&quot;]},&quot;ReadWriteType&quot;:&quot;All&quot;,&quot;ServiceName&quot;:&quot;Oss&quot;}]</para>
        /// </summary>
        [NameInMap("EventSelectors")]
        [Validation(Required=false)]
        public string EventSelectors { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTrailAllRegion")]
        [Validation(Required=false)]
        public bool? IsTrailAllRegion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trail-name</para>
        /// </summary>
        [NameInMap("TrailName")]
        [Validation(Required=false)]
        public string TrailName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai,cn-hangzhou</para>
        /// </summary>
        [NameInMap("TrailRegionIds")]
        [Validation(Required=false)]
        public string TrailRegionIds { get; set; }

    }

}
